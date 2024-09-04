using CommunityToolkit.Mvvm.ComponentModel;
using Microcharts;
using SkiaSharp;
using System.Collections.ObjectModel;

namespace MauiStudy.ViewModel
{
    internal partial class ChartViewModel : ObservableObject
    {
        [ObservableProperty]
        Chart chart;

        public ChartViewModel()
        {
            //Task.Run(() =>
            //{
            //    while (true)
            //    {
                    List<ChartEntry> entries = new()
                    {
                        new(Random.Shared.Next(0, 100))
                        {
                            Label = "10",
                            ValueLabel = "10",
                            Color = SKColor.Parse("#FF9800"),
                            TextColor = SKColor.Parse("#FF9800")
                        },
                        new(Random.Shared.Next(0, 100))
                        {
                            Label = "20",
                            ValueLabel = "20",
                            Color = SKColor.Parse("#FF9800"),
                            TextColor = SKColor.Parse("#FF9800")
                        },
                        new(Random.Shared.Next(0, 100))
                        {
                            Label = "30",
                            ValueLabel = "30",
                            Color = SKColor.Parse("#FF9800"),
                            TextColor = SKColor.Parse("#FF9800")
                        }
                    };

                    MainThread.BeginInvokeOnMainThread(() =>
                    {
                        Chart tempChart = new LineChart()
                        {
                            Entries = entries,
                            LineMode = LineMode.Straight,
                            LineSize = 8,
                            PointMode = PointMode.Circle,
                            PointSize = 18,
                        };
                        Chart = tempChart;
                    });
                    
            //        Thread.Sleep(1000);
            //    }
            //});
        }
    }
}
