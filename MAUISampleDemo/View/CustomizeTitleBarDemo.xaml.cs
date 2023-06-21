using Mopups.Services;

namespace MAUISampleDemo.View;

public partial class CustomizeTitleBarDemo : ContentPage
{
	public CustomizeTitleBarDemo()
	{
		InitializeComponent();
	}

    private void BtnAppThemeMode_Clicked(object sender, EventArgs e)
    {
        try
        {
           // var currentTheme = Application.Current.RequestedTheme;
            if (Application.Current.UserAppTheme == AppTheme.Light)
            {
                Application.Current.UserAppTheme = AppTheme.Dark;
            }
            else
            {
                Application.Current.UserAppTheme = AppTheme.Light;
            }

            //Application.Current.UserAppTheme = currentTheme;
        }
        catch (Exception ex)
        {
            var err = ex.Message;
        }
    }

    private void BtnBrightness_Clicked(object sender, EventArgs e)
    {
		try
		{
			MopupService.Instance.PushAsync(new ScreenBrightnessPopupPage());
		}
		catch (Exception ex)
		{
			var err = ex.Message;
		}
    }
}