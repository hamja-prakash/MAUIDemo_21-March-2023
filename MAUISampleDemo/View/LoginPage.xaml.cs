using MAUISampleDemo.ViewModels;

namespace MAUISampleDemo.View;

public partial class LoginPage : ContentPage
{
    public LoginPage()
	{
		InitializeComponent();
        this.BindingContext = new LoginViewModel();
    }

    protected override void OnAppearing()
    {
        base.OnAppearing();
        Email.Text = string.Empty;
        Password.Text = string.Empty;
    }
}