using CommunityToolkit.Maui.Core.Platform;
using Microsoft.Maui.Platform;

namespace MAUISampleDemo.View;

public partial class Show_Hide_KeyboardDemo : ContentPage
{
    public Show_Hide_KeyboardDemo()
    {
        InitializeComponent();
    }

    private async void BtnShowHideKeyboard_Clicked(object sender, EventArgs e)
    {
        try
        {
            if (CommunityToolkit.Maui.Core.Platform.KeyboardExtensions.IsSoftKeyboardShowing(Ent1))
                await CommunityToolkit.Maui.Core.Platform.KeyboardExtensions.HideKeyboardAsync(Ent1, default);
            else
                await CommunityToolkit.Maui.Core.Platform.KeyboardExtensions.ShowKeyboardAsync(Ent1, default);
        }
        catch (Exception ex)
        {
            var err = ex.Message;
        }
    }
}