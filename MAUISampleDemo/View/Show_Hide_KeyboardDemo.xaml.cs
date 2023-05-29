using CommunityToolkit.Maui.Core.Platform;
using Microsoft.Maui.Platform;

namespace MAUISampleDemo.View;

public partial class Show_Hide_KeyboardDemo : ContentPage
{
    public Show_Hide_KeyboardDemo()
    {
        InitializeComponent();
    }

    private async void BtnHideShowKeyboard_Clicked(object sender, EventArgs e)
    {
        try
        {
            if (CommunityToolkit.Maui.Core.Platform.KeyboardExtensions.IsSoftKeyboardShowing(txtFullName))
                await CommunityToolkit.Maui.Core.Platform.KeyboardExtensions.HideKeyboardAsync(txtFullName, default);
            else
                await CommunityToolkit.Maui.Core.Platform.KeyboardExtensions.ShowKeyboardAsync(txtFullName, default);
        }
        catch (Exception ex)
        {
            var err = ex.Message;
        }
    }

    //public async void ShowHideKeyboard(ITextInput Id)
    //{
    //    try
    //    {
    //        if (CommunityToolkit.Maui.Core.Platform.KeyboardExtensions.IsSoftKeyboardShowing(Id))
    //            await CommunityToolkit.Maui.Core.Platform.KeyboardExtensions.HideKeyboardAsync(Id, default);
    //        else
    //            await CommunityToolkit.Maui.Core.Platform.KeyboardExtensions.ShowKeyboardAsync(txtFirstName, default);
    //    }
    //    catch (Exception ex)
    //    {
    //        var err = ex.Message;
    //    }
    //}
}