using MAUISampleDemo.ViewModels;

namespace MAUISampleDemo.View;

public partial class CustomizeLoginPage : ContentPage
{
	public CustomizeLoginPage()
	{
		InitializeComponent();
        this.BindingContext = new LoginViewModel();
    }

    protected override void OnAppearing()
    {
        base.OnAppearing();
        txtEmail.Text = string.Empty;
        txtPassword.Text = string.Empty;
    }
}