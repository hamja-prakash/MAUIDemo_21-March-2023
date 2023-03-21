using MAUISampleDemo.ViewModels;

namespace MAUISampleDemo.View;

public partial class StateContainerViewDemo : ContentPage
{
	public StateContainerViewDemo()
	{
		InitializeComponent();
		this.BindingContext = new StateContainerViewModel();
	}
}