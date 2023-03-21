using MAUISampleDemo.ViewModels;

namespace MAUISampleDemo.View;

public partial class HomePage : ContentPage
{
	public HomePage()
	{
		InitializeComponent();
        CommonToolbar.LblToolbarTitle.Text = "Home Page";
        CommonToolbar.ImgToolbarBack.IsVisible = true;
        this.BindingContext= new HomePageViewModel();
    }
}