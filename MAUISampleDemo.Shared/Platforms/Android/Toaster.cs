using Android.Widget;
using MAUISampleDemo.Helpers;

namespace MAUISampleDemo.PlatformImplementations;

public class Toaster : IToast
{
    public void MakeToast(string message)
    {
        Toast.MakeText(Platform.CurrentActivity, message, ToastLength.Long).Show();
    }
}
