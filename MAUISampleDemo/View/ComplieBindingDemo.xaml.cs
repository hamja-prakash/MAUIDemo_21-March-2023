using MAUISampleDemo.ViewModels;

namespace MAUISampleDemo.View;

public partial class ComplieBindingDemo : ContentPage
{
	public ComplieBindingDemo()
	{
		InitializeComponent();
		this.BindingContext = new CompileBindingViewModel();
	}
}