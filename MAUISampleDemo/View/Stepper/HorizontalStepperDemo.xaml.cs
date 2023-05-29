namespace MAUISampleDemo.View.Stepper;

public partial class HorizontalStepperDemo : ContentPage
{
	public HorizontalStepperDemo()
	{
		InitializeComponent();
	}

    private void stepperView_OnStepContinue(object sender, EventArgs e)
    {
		try
		{
			if (stepperView.Steps.Count > stepperView.CurrentStep)
				stepperView.CurrentStep += 1;
		}
        catch (Exception ex)
        {
            var err = ex.Message;
        }
    }

    private void stepperView_OnStepCancel(object sender, EventArgs e)
    {
		try
		{
			if (stepperView.CurrentStep > 0)
				stepperView.CurrentStep -= 1;
		}
        catch (Exception ex)
        {
            var err = ex.Message;
        }
    }
}