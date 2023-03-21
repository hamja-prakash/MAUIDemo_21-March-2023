using MAUISampleDemo.Helpers;

namespace MAUISampleDemo.View;

public partial class PlatformSpecificCodeDemo : ContentPage
{
    int count = 0;
    public PlatformSpecificCodeDemo()
	{
		InitializeComponent();
        orientationLabel.Text = new DeviceOrientationService().GetOrientation().ToString();
    }

    private void OnCounterClicked(object sender, EventArgs e)
    {
        count++;
        CounterLabel.Text = $"Current count: {count}";

        SemanticScreenReader.Announce(CounterLabel.Text);
    }
}