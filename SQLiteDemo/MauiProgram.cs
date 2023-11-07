﻿using Microsoft.Extensions.Logging;
using SQLiteDemo.Views;
using SQLiteDemo.ViewModels;
using SQLiteDemo.Services;

namespace SQLiteDemo
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
            //Services

            builder.Services.AddSingleton<IStudentService, StudentService>();

            //Views Registeration

            builder.Services.AddSingleton<StudentListPage>();
            builder.Services.AddTransient<AddUpdateStudentDetail>();
            //ViewModel Registration
            builder.Services.AddSingleton<StudentListPageViewModel>();
            builder.Services.AddTransient<AddUpdateStudentDetailViewModel>();



            return builder.Build();
        }
    }
}