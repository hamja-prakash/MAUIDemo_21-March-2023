using MAUISampleDemo.ViewModels;

namespace MAUISampleDemo.View;

public partial class ConverterwithMultiPrmDemo : ContentPage
{
	public ConverterwithMultiPrmDemo()
	{
		InitializeComponent();
		this.BindingContext = new ConverterWithPrmViewModel();
	}
}