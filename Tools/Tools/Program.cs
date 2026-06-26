using Microsoft.Extensions.DependencyInjection;
using Tools.Services;
using Tools.Services.VideoTrimming;

namespace Tools;

internal static class Program
{
    /// <summary>
    ///  The main entry point for the application.
    /// </summary>
    [STAThread]
    static void Main()
    {
        // To customize application configuration such as set high DPI settings or default font,
        // see https://aka.ms/applicationconfiguration.
        ApplicationConfiguration.Initialize();

        var services = new ServiceCollection()
            .AddScoped<IVideoTrimmingService, VideoTrimmingService>()
            .AddScoped<IFormSwitchingService, FormSwitchingService>()
            .AddSingleton<IAppSettingsService, AppSettingsService>()
            .AddSingleton<MainForm>()
            .AddTransient<VideoTrimmingForm>()
            .AddTransient<Form1>()
            .BuildServiceProvider();

        // Load the app settings once
        services.GetRequiredService<IAppSettingsService>().Load();

        Application.Run(services.GetRequiredService<MainForm>());
    }
}