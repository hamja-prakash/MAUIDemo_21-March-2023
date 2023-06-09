﻿using Acr.UserDialogs;
using BarcodeScanner.Mobile;
using Camera.MAUI;
using CommunityToolkit.Maui;
using CommunityToolkit.Maui.Core;
using FFImageLoading.Maui;
using MAUISampleDemo.Helpers;
using MAUISampleDemo.PlatformImplementations;
using MAUISampleDemo.View;
using MAUISampleDemo.View.Navigation;
using MAUISampleDemo.ViewModels;
using Microsoft.AppCenter;
using Microsoft.AppCenter.Analytics;
using Microsoft.AppCenter.Crashes;
using Microsoft.Maui.LifecycleEvents;
using Mopups.Hosting;
using Plugin.LocalNotification;
using SkiaSharp.Views.Maui.Controls.Hosting;
using SkiaSharp.Views.Maui.Handlers;
using ZXing.Net.Maui;
using ZXing.Net.Maui.Controls;

namespace MAUISampleDemo;
public static class MauiProgram
{
    public static MauiApp CreateMauiApp()
    {
        var builder = MauiApp.CreateBuilder();
        builder.UseMauiApp<App>()
            .UseLocalNotification()
            .ConfigureMopups()
            .UseMauiCommunityToolkit()
            .UseMauiCommunityToolkitCore()
            .UseBarcodeReader()
            .UseSkiaSharp()
            .UseMauiCommunityToolkitMediaElement()
            .UseMauiCameraView()
            .UseFFImageLoading()
            .UseProgressBar()
            .UseSentry(options =>
            {
                // The DSN is the only required setting.
                options.Dsn = "https://6f49c41adfb947beaa59abcc8883ab93@o4505192262598656.ingest.sentry.io/4505225785311232";
            })
            .ConfigureFonts(fonts =>
            {
                fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                fonts.AddFont("fa-brands-400.ttf", "FaBrands");
                fonts.AddFont("fa-solid-900.ttf", "FAS");
                fonts.AddFont("OpenSans-Bold.ttf", "OpenSansBold");
                fonts.AddFont("Sitka.ttf", "Sitka");
                fonts.AddFont("MaterialIcons-Regular.ttf", "MaterialIcons-Regular");
                fonts.AddFont("Strande2.ttf", "Strande2");
            })
            .ConfigureLifecycleEvents(events =>
            {
#if ANDROID
                events.AddAndroid(android => android.OnApplicationCreate(app => UserDialogs.Init(app)));
#endif
            })

        .ConfigureMauiHandlers(h =>
        {
            h.AddBarcodeScannerHandler();
            h.AddHandler(typeof(ZXing.Net.Maui.Controls.CameraBarcodeReaderView), typeof(CameraBarcodeReaderViewHandler));
            h.AddHandler(typeof(ZXing.Net.Maui.Controls.CameraView), typeof(ZXing.Net.Maui.CameraViewHandler));
            h.AddHandler(typeof(ZXing.Net.Maui.Controls.BarcodeGeneratorView), typeof(BarcodeGeneratorViewHandler));
        }).UseMauiCommunityToolkit();

        AppCenter.Start("windowsdesktop={Your Windows App secret here};" +
                "android=69cfd5df-6ce1-4659-bc88-040a96a5f695;" +
                "ios=dfe2d75d-8425-446e-8b1e-6f96ca6ca7cb;" +
                "macos={Your macOS App secret here};",
                typeof(Analytics), typeof(Crashes));

        builder.Services.AddSingleton<IConnectivity>((e) => Connectivity.Current);
        builder.Services.AddSingleton<Helpers.IToast>((e) => new Toaster());
        builder.Services.AddSingleton<MainPage>();
        builder.Services.AddSingleton<MainPageViewModel>();
        builder.Services.AddSingleton<NavPage1>();
        builder.Services.AddTransient<NavPage1ViewModel>();
        builder.Services.AddTransient<SemanticOrderViewDemo>();
        return builder.Build();
    }
}