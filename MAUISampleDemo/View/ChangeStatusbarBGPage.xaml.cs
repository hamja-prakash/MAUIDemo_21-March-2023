using MAUISampleDemo.ViewModels;

namespace MAUISampleDemo.View;

public partial class ChangeStatusbarBGPage : ContentPage
{
	public ChangeStatusbarBGPage()
	{
		InitializeComponent();
		this.BindingContext = new ChangeStatusbarBGViewModel();
	}
}