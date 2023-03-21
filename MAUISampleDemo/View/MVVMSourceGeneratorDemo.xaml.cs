using MAUISampleDemo.ViewModels;

namespace MAUISampleDemo.View;

public partial class MVVMSourceGeneratorDemo : ContentPage
{
	public MVVMSourceGeneratorDemo()
	{
		InitializeComponent();
		this.BindingContext = new MVVMSourceGeneratorViewModel();

    }
}