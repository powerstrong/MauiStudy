using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace MauiStudy.ViewModel
{
    partial class StopwatchViewModel : ObservableObject
    {
        [ObservableProperty]
        string _currentTime = "00:00.00";

        [RelayCommand]
        void Start()
        {

        }

        [RelayCommand]
        void Init()
        {

        }

    }
}
