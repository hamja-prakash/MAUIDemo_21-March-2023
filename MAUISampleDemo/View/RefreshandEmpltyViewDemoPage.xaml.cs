using MAUISampleDemo.ViewModels;

namespace MAUISampleDemo.View;

public partial class RefreshandEmpltyViewDemoPage : ContentPage
{
	public RefreshandEmpltyViewDemoPage()
    {
        InitializeComponent();
        CommonToolbar.LblToolbarTitle.Text = "Refresh-Empty Page";
        CommonToolbar.ImgToolbarBack.IsVisible = true;
        this.BindingContext = new RefreshandEmptyViewModel();
	}
}