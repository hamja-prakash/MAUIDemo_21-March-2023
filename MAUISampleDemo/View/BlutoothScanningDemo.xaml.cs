using MAUISampleDemo.ViewModels;

namespace MAUISampleDemo.View;

public partial class BlutoothScanningDemo : ContentPage
{
    public BlutoothScanningDemo()
    {
        InitializeComponent();
        this.BindingContext = new BlutoothScanningViewModel();
    }
}