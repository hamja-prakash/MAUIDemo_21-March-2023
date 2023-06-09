﻿
#if ANDROID
using Microsoft.Maui.Controls.Compatibility.Platform.Android;
using Android.Content.Res;
#endif

using MAUISampleDemo.Helpers;
using MAUISampleDemo.View;
using System.Globalization;

namespace MAUISampleDemo;

public partial class App : Application
{
    private static Database database;

    public static Database Database
    {
        get
        {
            if (database == null)
            {
                database = new Database(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "people_encrypted.db3"));
            }
            return database;
        }
    }
    public App()
    {
        InitializeComponent();
        Microsoft.Maui.Handlers.EntryHandler.Mapper.AppendToMapping(nameof(BorderlessEntry), (handler, view) =>
        {
#if __ANDROID__
            //handler.PlatformView.BackgroundTintList = ColorStateList.ValueOf(Colors.Transparent.ToAndroid());
            handler.PlatformView.SetBackgroundColor(Android.Graphics.Color.Transparent);
            //handler.PlatformView.TextCursorDrawable.SetTint(Colors.White.ToAndroid());
#elif __IOS__
            handler.PlatformView.BackgroundColor = UIKit.UIColor.Clear;
            handler.PlatformView.BorderStyle = UIKit.UITextBorderStyle.None;
#endif
        });
        
        Microsoft.Maui.Handlers.EditorHandler.Mapper.AppendToMapping(nameof(CustomEditor), (handler, view) =>
        {
#if __ANDROID__
            handler.PlatformView.SetBackgroundColor(Android.Graphics.Color.Transparent);
#endif
        });

        Translator.Instance.CultureInfo = new CultureInfo("en-US");
        MainPage = new AppShell();
        //MainPage = new FlyoutDemo();
        // let's set the initial theme already during the app start
    }
}
