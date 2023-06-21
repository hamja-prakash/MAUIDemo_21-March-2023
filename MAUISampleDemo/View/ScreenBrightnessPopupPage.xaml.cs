using Plugin.Maui.ScreenBrightness;

namespace MAUISampleDemo.View;

public partial class ScreenBrightnessPopupPage
{
	public ScreenBrightnessPopupPage()
	{
		InitializeComponent();
		brightnessSlider.Value = ScreenBrightness.Default.Brightness;

    }

    private void Slider_ValueChanged(object sender, ValueChangedEventArgs e)
    {
        ScreenBrightness.Default.Brightness = (float)e.NewValue;
        brightnessLabel.Text = ScreenBrightness.Default.Brightness.ToString("0.00");
    }
}