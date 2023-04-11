using MAUISampleDemo.ViewModels;

namespace MAUISampleDemo.View;

public partial class EmailAuthDemo : ContentPage
{
    EmailAuthViewModel emailAuthViewModel;
    public EmailAuthDemo()
	{
		InitializeComponent();
        emailAuthViewModel = new EmailAuthViewModel();
        this.BindingContext = emailAuthViewModel;
    }

    protected override void OnAppearing()
    {
        base.OnAppearing();
        emailAuthViewModel.UserName = string.Empty;
        emailAuthViewModel.UserPassword = string.Empty;
    }
}