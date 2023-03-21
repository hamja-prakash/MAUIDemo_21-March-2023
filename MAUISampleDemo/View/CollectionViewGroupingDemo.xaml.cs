namespace MAUISampleDemo.View;

public partial class CollectionViewGroupingDemo : ContentPage
{
	public CollectionViewGroupingDemo()
	{
		InitializeComponent();
	}

    private async void FrmOption1_Tapped(object sender, EventArgs e)
    {
        await FrmOption1.ScaleTo(0.9, 100, Easing.Linear);
        await FrmOption1.ScaleTo(1.0, 100, Easing.Linear);
        Navigation.PushAsync(new ColGrouping1());
    }

    private async void FrmOption2_Tapped(object sender, EventArgs e)
    {
        await FrmOption2.ScaleTo(0.9, 100, Easing.Linear);
        await FrmOption2.ScaleTo(1.0, 100, Easing.Linear);
        Navigation.PushAsync(new ColGrouping2());
    }
}