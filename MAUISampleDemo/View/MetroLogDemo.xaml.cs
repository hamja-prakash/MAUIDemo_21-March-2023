
namespace MAUISampleDemo.View;

public partial class MetroLogDemo : ContentPage
{
    int count = 0;
    public MetroLogDemo()
	{
		InitializeComponent();
    }

    private void OnCounterClicked(object sender, EventArgs e)
    {
        count++;
        string message;

        if (count == 1)
            message = $"Clicked {count} time";
        else
            message = $"Clicked {count} times";
    }
}