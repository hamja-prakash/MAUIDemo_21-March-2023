using MAUISampleDemo.ViewModels;

namespace MAUISampleDemo.View;

public partial class AutoSizeEditorDemo : ContentPage
{
    public string CheckImg = "iconsquarecheck.png";
    public string UnCheckImg = "iconsquareuncheck.png";
    public AutoSizeEditorDemo()
    {
        InitializeComponent();
        CommonToolbar.LblToolbarTitle.Text = "AutoSize Editor";
        CommonToolbar.ImgToolbarBack.IsVisible = true;
        this.BindingContext = new AutoSizeViewModel();
    }
}