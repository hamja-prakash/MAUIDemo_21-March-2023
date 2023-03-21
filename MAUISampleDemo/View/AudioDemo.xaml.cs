using Plugin.Maui.Audio;

namespace MAUISampleDemo.View;

public partial class AudioDemo : ContentPage
{
	IAudioManager audioManager; 

	public AudioDemo()
	{
		InitializeComponent();
		audioManager = AudioManager.Current;
    }

    private async void BtnAudio_Clicked(object sender, EventArgs e)
    {
        var player = audioManager.CreatePlayer(await FileSystem.OpenAppPackageFileAsync("audio.mp3"));
        player.Play();
        player.Dispose();
    }
}