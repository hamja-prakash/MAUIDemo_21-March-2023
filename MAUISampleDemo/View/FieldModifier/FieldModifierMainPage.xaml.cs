namespace MAUISampleDemo.View.FieldModifier;

public partial class FieldModifierMainPage : ContentPage
{
	public FieldModifierMainPage()
	{
		InitializeComponent();
        CommonToolbar.LblToolbarTitle.Text = "Field Page";
        CommonToolbar.ImgToolbarBack.IsVisible = true;
    }

    private async void NavigateToSecondPage(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new SecondPage());
    }

    public partial class MainPage2 : FieldModifierMainPage
    {
        public MainPage2()
        {
            // Accessing MainPage Image
            ImgDotNet.HeightRequest = 100;
            ImgDotNet.WidthRequest = 100;
        }
    }
}