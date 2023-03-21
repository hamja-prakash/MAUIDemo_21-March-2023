using MAUISampleDemo.ViewModels;

namespace MAUISampleDemo.View;

public partial class MVVM_Databinding : ContentPage
{
	public MVVM_Databinding()
	{
		InitializeComponent();
        CommonToolbar.LblToolbarTitle.Text = "Databinding Page";
        CommonToolbar.ImgToolbarBack.IsVisible = true;
        this.BindingContext = new MVVMDatabindingViewModel();
    }
}