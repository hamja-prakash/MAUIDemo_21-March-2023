namespace MAUISampleDemo.View.CsharpMarkup;

public partial class CsharpMarkupMainPage : ContentPage
{
	public CsharpMarkupMainPage()
	{
		InitializeComponent();
	}

    private void btnCsharpPage_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new MAUICsharpPage());
    }

    private void btnCsharpMarkupPage_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new MAUICsharpMarkup());
    }
}