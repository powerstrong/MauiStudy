using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace MauiStudy.ViewModel
{
    partial class ModbusTcpTestViewModel : ObservableObject
    {
        [ObservableProperty] 
        string _ip = "192.168.1.101";

        [ObservableProperty]
        int _port = 502;

        [ObservableProperty]
        string _jointAngle;

        [ObservableProperty]
        bool _connectButtonEnable = true;

        [ObservableProperty]
        bool _updateButtonEnable = false;

        private EasyModbus.ModbusClient _client;

        [RelayCommand]
        void Connect()
        {
            _client = new(Ip, Port);
            _client.Connect();

            ConnectButtonEnable = false;
            UpdateButtonEnable = true;
        }

        [RelayCommand]
        void UpdateJointAngle()
        {
            ushort address = 201;
            ushort size = 12;
            var result = _client.ReadInputRegisters(address, size);
            var angles = new double[6];

            // double 6개로 변환
            Utilities.RadianDegreeConverter conv = new();
            for (int i = 0; i < 6; i++)
            {
                double rad = conv.ConvertToDegree(result[i * 2 + 1], result[i * 2]);
                angles[i] = rad;
            }

            JointAngle = string.Format("{0}, {1}, {2}, {3}, {4}, {5}",
                angles[0], angles[1], angles[2], angles[3], angles[4], angles[5]);
        }
    }
}
