using MAUISampleDemo.ViewModels;

namespace MAUISampleDemo.View;

public partial class ObservablePropertyDemoPage : ContentPage
{
	public ObservablePropertyDemoPage()
	{
		InitializeComponent();
        BindingContext = new ObservablePropertyViewModel();
    }
}