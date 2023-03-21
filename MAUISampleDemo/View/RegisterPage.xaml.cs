using MAUISampleDemo.ViewModels;

namespace MAUISampleDemo.View;

public partial class RegisterPage : ContentPage
{
	public RegisterPage()
	{
		InitializeComponent();
		this.BindingContext = new RegisterViewModel();
	}
}