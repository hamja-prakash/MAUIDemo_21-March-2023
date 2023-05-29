using CommunityToolkit.Maui.Views;

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

        //VideoPlayer.Source = new Uri("https://commondatastorage.googleapis.com/gtv-videos-bucket/sample/BigBuckBunny.mp4");
       // VideoPlayer.Play();
    }

    private void OnPausePressed(object sender, EventArgs e)
    {
        VideoPlayer.Pause();
    }
}