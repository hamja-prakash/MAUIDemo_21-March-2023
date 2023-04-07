using MAUISampleDemo.ViewModels;

namespace MAUISampleDemo.View;

public partial class DragandDropDemo : ContentPage
{
	public DragandDropDemo()
	{
		InitializeComponent();
		this.BindingContext = new DragandDropViewModel();
    }
}