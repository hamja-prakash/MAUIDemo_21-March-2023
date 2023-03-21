namespace MAUISampleDemo.View;

public partial class ResponsiveLayoutPage : ContentPage
{
	public ResponsiveLayoutPage()
	{
		InitializeComponent();
	}

    private void OnPlayPressed(object sender, EventArgs e)
    {
        VideoPlayer.Play();
    }

    private void OnPausePressed(object sender, EventArgs e)
    {
        VideoPlayer.Pause();
    }
}