namespace MAUISampleDemo.View;

public partial class BasicAnimationDemo : ContentPage
{
	public BasicAnimationDemo()
	{
		InitializeComponent();
	}

    private async void imgFade_Clicked(object sender, EventArgs e)
    {
		try
		{
			//Fade Out
			await imgFade.FadeTo(0, 2000);

			//Fade In
			await imgFade.FadeTo(1, 2000);
		}
		catch (Exception ex)
		{
			var err = ex.Message;
		}
    }

    private async void imgRotation_Clicked(object sender, EventArgs e)
    {
        try
        {
            await imgRotation.RelRotateTo(360, 2000);
            //await imgRotation.RotateTo(360, 2000);
            //imgRotation.Rotation = 0;
        }
        catch (Exception ex)
        {
            var err = ex.Message;
        }
    }

    //Horizantal Rotation
    private async void imgHrRotation_Clicked(object sender, EventArgs e)
    {
        try
        {
            await imgHrRotation.RotateYTo(360, 2000);
        }
        catch (Exception ex)
        {
            var err = ex.Message;
        }
    }

    //Vertical Rotation
    private async void imgVrRotation_Clicked(object sender, EventArgs e)
    {
        try
        {
            await imgVrRotation.RotateXTo(360, 2000);
        }
        catch (Exception ex)
        {
            var err = ex.Message;
        }
    }

    //Scale Animation
    private async void imgScale_Clicked(object sender, EventArgs e)
    {
        try
        {
            await imgScale.ScaleTo(2, 2000);
            await imgScale.ScaleTo(1, 2000);
        }
        catch (Exception ex)
        {
            var err = ex.Message;
        }
    }

    //Translate Animation
    private async void imgTranslate_Clicked(object sender, EventArgs e)
    {
        try
        {
            //translate right
            await imgTranslate.TranslateTo(50,0, 1000);

            //translate left
            await imgTranslate.TranslateTo(0,0, 1000);

            //translate Up
            await imgTranslate.TranslateTo(0, -50, 1000);

            //translate Down
            await imgTranslate.TranslateTo(0, 0, 1000);
        }
        catch (Exception ex)
        {
            var err = ex.Message;
        }
    }

    private async void BtnStartAnimation_Clicked(object sender, EventArgs e)
    {
        try
        {
            await Task.WhenAny(imgTranslate.ScaleTo(2, 2000), imgTranslate.RotateTo(360, 4000));
            await imgTranslate.ScaleTo(1, 2000);       
        }
        catch (Exception ex)
        {
            var err = ex.Message;
        }
    }
}