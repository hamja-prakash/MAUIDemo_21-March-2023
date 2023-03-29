using MAUISampleDemo.ViewModels;

namespace MAUISampleDemo.View;

public partial class ContactShareDemo : ContentPage
{
	public ContactShareDemo()
	{
		InitializeComponent();
		this.BindingContext = new ContactPageViewModel();
	}
}