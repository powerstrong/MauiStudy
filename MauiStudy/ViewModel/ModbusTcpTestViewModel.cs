using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiStudy.ViewModel
{
    partial class ModbusTcpTestViewModel : ObservableObject
    {
        [ObservableProperty] 
        string _ip = "192.168.1.101";

        [ObservableProperty]
        int _port = 502;

        [RelayCommand]
        void Connect()
        {
            EasyModbus.ModbusClient client = new(Ip, Port);
            client.Connect();
        }
    }
}
