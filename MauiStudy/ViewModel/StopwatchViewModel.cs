using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Diagnostics;

namespace MauiStudy.ViewModel
{
    partial class StopwatchViewModel : ObservableObject
    {
        const string _initial_time = "00:00:00.00";
        private readonly Stopwatch _stopwatch = new();

        [ObservableProperty]
        string _startButtonText = "시작";

        [ObservableProperty]
        string _currentTime = _initial_time;

        [RelayCommand]
        async Task Start()
        {
            if (_stopwatch.IsRunning == false)
            {
                StartButtonText = "일시정지";
                _stopwatch.Start();
                await Task.Run(RunStopwatch);
            }
            else
            {
                StartButtonText = "시작";
                _stopwatch.Stop();
            }
        }

        private async void RunStopwatch()
        {
            while(_stopwatch.IsRunning)
            {
                CurrentTime = _stopwatch.Elapsed.ToString()[..11];
                await Task.Delay(10);
            }
        }

        [RelayCommand]
        void Init()
        {
            _stopwatch.Stop();
            _stopwatch.Reset();
            CurrentTime = _initial_time;
            StartButtonText = "시작";
        }

    }
}
