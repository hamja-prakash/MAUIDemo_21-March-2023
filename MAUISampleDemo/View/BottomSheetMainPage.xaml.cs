using The49.Maui.BottomSheet;

namespace MAUISampleDemo.View;

public partial class BottomSheetMainPage : ContentPage
{
	public BottomSheetMainPage()
	{
		InitializeComponent();
	}

    private void btnSimpleSheet_Clicked(object sender, EventArgs e)
    {
        var page = new BottomsheetDemoPage();
        page.Show(Window);
    }

    private void btnwithHandle_Clicked(object sender, EventArgs e)
    {
        var page = new BottomsheetDemoPage();
        page.IsModal = true;
        page.ShowHandle = true;
        page.Detents = new DetentsCollection()
        {
            new FullscreenDetent(),
            new ContentDetent(),
        };
        page.Show(Window);
    }

    private void btnSpecifyHeight_Clicked(object sender, EventArgs e)
    {
        var page = new BottomsheetDemoPage();
        page.Detents = new DetentsCollection()
        {
            new HeightDetent() { Height = 250 },
        };
        page.Show(Window);
    }

    private void btnBackgroundSheet_Clicked(object sender, EventArgs e)
    {
        var page = new BottomsheetDemoPage();
        page.Detents = new DetentsCollection()
        {
            new FullscreenDetent(),
            new ContentDetent(),
        };
        page.Background = Colors.Salmon;
        page.Show(Window);
    }

    private void btnDismiss_Clicked(object sender, EventArgs e)
    {
        var page = new BottomsheetDemoPage();
        page.IsModal = true;
        page.Dismissed += (s, e) =>
        {
            DisplayAlert("Dismissed", "Sheet was dismissed", "close");
        };
        page.Show(Window);
    }
}