using MAUISampleDemo.ViewModels;

namespace MAUISampleDemo.View;

public partial class MusicPlayDemo : ContentPage
{
	public MusicPlayDemo()
	{
		InitializeComponent();
		this.BindingContext = new MusicPlayViewModel();
	}
}