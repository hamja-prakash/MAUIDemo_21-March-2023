namespace MAUISampleDemo.View.Stepper;

public partial class StepperDemo : ContentPage
{
	public StepperDemo()
	{
		InitializeComponent();
	}

    private void btnVertical_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new VerticalStepperDemo());
    }

    private void btnHorizontal_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new HorizontalStepperDemo());
    }
}