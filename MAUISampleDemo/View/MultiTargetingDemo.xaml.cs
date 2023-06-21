
using MAUISampleDemo.Platforms;

namespace MAUISampleDemo.View;

public partial class MultiTargetingDemo : ContentPage
{
	public MultiTargetingDemo()
	{
		InitializeComponent();
	}

    //Way 2
    private async void Button_OnPressed(object sender, EventArgs e)
    {
		try
		{
            await this.SayHello();
        }
		catch (Exception ex)
		{
			var err = ex.Message;
		}
    }

    //Way 1

//    private async void Button_OnPressed(object sender, EventArgs e)
//    {
//#if ANDROID
//        await DisplayAlert("Hello", "Hello from Android!", "OK");
//#elif IOS
//        await DisplayAlert("Hello", "Hello from iOS!", "OK");
//#elif WINDOWS
//        await DisplayAlert("Hello", "Hello from Windows!", "OK");
//#else
//        await DisplayAlert("Hello", "Hello from another platform (MacCatalyst, Tizen, ...)", "OK");
//#endif
//    }
}