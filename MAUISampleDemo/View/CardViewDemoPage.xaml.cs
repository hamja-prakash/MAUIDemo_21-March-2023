namespace MAUISampleDemo.View;

public partial class CardViewDemoPage : ContentPage
{
	public CardViewDemoPage()
	{
		InitializeComponent();
        CommonToolbar.LblToolbarTitle.Text = "CardView";
        CommonToolbar.ImgToolbarBack.IsVisible = true;
    }
}