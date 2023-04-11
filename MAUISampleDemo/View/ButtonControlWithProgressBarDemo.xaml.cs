using MAUISampleDemo.ViewModels;

namespace MAUISampleDemo.View;

public partial class ButtonControlWithProgressBarDemo : ContentPage
{
	public ButtonControlWithProgressBarDemo()
	{
		InitializeComponent();
        this.BindingContext = new BtnCntwithProgressbarViewModel();
    }

    private async void btn1_Tapped(object sender, EventArgs e)
    {
        btn1.IsInProgress = true;
        await Task.Delay(1000);
        btn1.IsInProgress = false;
    }
}