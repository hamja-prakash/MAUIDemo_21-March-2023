using MAUISampleDemo.ViewModels;

namespace MAUISampleDemo.View;

public partial class LoginDataPage : ContentPage
{
	public LoginDataPage()
	{
		InitializeComponent();
        CommonToolbar.LblToolbarTitle.Text = "Login Data";
        CommonToolbar.ImgToolbarBack.IsVisible = true;
        this.BindingContext = new LoginDataViewModel();
    }
}