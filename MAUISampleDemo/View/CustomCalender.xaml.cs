using MAUISampleDemo.ViewModels;

namespace MAUISampleDemo.View;

public partial class CustomCalender : ContentPage
{
	public CustomCalender()
	{
		InitializeComponent();
		this.BindingContext = new CalenderViewModel();
	}
}