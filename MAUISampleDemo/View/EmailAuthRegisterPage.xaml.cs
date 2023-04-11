using MAUISampleDemo.ViewModels;

namespace MAUISampleDemo.View;

public partial class EmailAuthRegisterPage : ContentPage
{
	public EmailAuthRegisterPage()
	{
		InitializeComponent();
		this.BindingContext = new EmailAuthRegisterViewModel();
	}
}