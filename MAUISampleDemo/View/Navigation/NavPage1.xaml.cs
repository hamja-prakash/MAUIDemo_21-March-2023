using CommunityToolkit.Maui.Alerts;
using MAUISampleDemo.ViewModels;
using Microsoft.AppCenter.Analytics;

namespace MAUISampleDemo.View.Navigation;

public partial class NavPage1 : ContentPage
{
    int count = 0;
    public NavPage1(NavPage1ViewModel vm)
	{
		InitializeComponent();
		this.BindingContext = vm;
	}

    protected override void OnNavigatedTo(NavigatedToEventArgs args)
    {
        base.OnNavigatedTo(args);
    }

    private void OnCounterClicked(object sender, EventArgs e)
    {
        count++;
        string message;

        if (count == 1)
            message = $"Clicked {count} time";
        else
            message = $"Clicked {count} times";

        SemanticScreenReader.Announce(message);

        CounterBtn.Text = message;

        //var toast = Toast.Make(message, CommunityToolkit.Maui.Core.ToastDuration.Long, 30);
        //toast.Show();

        var snackbar = Snackbar.Make(message, () => DisplayAlert("Test", "this is testing", "OK"), "YES!",
            TimeSpan.FromSeconds(10), new CommunityToolkit.Maui.Core.SnackbarOptions
            {
                BackgroundColor = Colors.Red,
                TextColor = Colors.White,
            }, lblcount);

        snackbar.Show();

        Analytics.TrackEvent("Counter", new Dictionary<string, string> { { "Counter", count.ToString() } });
    }
}