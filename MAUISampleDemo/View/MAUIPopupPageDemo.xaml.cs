using Mopups.Services;

namespace MAUISampleDemo.View;

public partial class MAUIPopupPageDemo
{
    public MAUIPopupPageDemo()
    {
        InitializeComponent();
    }
    private void LoginButton_Clicked(object sender, EventArgs e)
    {
        MopupService.Instance.PopAsync();
    }
}