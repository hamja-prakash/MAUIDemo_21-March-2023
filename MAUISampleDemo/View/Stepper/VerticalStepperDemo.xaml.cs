namespace MAUISampleDemo.View.Stepper;

public partial class VerticalStepperDemo : ContentPage
{
	public VerticalStepperDemo()
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

    private void stepperView_OnStepTapped(object sender, int e)
    {
        try
        {
            stepperView.CurrentStep = e;
        }
        catch (Exception ex)
        {
            var err = ex.Message;
        }
    }
}