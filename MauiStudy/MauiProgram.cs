﻿using MauiStudy.Pages;
using MauiStudy.ViewModel;
using Microsoft.Extensions.Logging;

namespace MauiStudy
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                });

#if DEBUG
		builder.Logging.AddDebug();
#endif

            builder.Services.AddSingleton<NetmauiforbeginnersPage>();
            builder.Services.AddSingleton<NetmauiforbeginnersViewModel>();

            return builder.Build();
        }
    }
}