using MAUISampleDemo.ViewModels;

namespace MAUISampleDemo.View;

public partial class CollectionviewinsideScrollviewDemo : ContentPage
{
	public CollectionviewinsideScrollviewDemo()
	{
		InitializeComponent();
		this.BindingContext = new ClvinsidescrViewModel();
	}
}