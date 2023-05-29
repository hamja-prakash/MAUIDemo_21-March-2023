using Sentry;

namespace MAUISampleDemo.View;

public partial class CustomiseControlwithHandlerDemo : ContentPage
{
    int count = 0;
    public CustomiseControlwithHandlerDemo()
	{
		InitializeComponent();
	}

    private void OnCounterClicked(object sender, EventArgs e)
    {
        count++;
        CounterLabel.Text = $"Current count: {count}";

        SemanticScreenReader.Announce(CounterLabel.Text);
        SentrySdk.CaptureMessage($"Count:{count}");
    }
}