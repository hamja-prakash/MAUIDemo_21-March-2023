using MAUISampleDemo.ViewModels;

namespace MAUISampleDemo.View;

public partial class ExpandableParagraphDemo : ContentPage
{
	public ExpandableParagraphDemo()
	{
		InitializeComponent();
		this.BindingContext = new ExpandableParagraphViewModel();
	}
}