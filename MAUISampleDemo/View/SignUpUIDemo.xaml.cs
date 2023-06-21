namespace MAUISampleDemo.View;

public partial class SignUpUIDemo : ContentPage
{
	public SignUpUIDemo()
	{
		InitializeComponent();
	}

    private void Button_Clicked(object sender, EventArgs e)
    {
		Navigation.PopAsync();
    }
}