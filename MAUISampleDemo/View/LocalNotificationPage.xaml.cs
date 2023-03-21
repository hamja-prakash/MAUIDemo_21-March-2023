using Plugin.LocalNotification;

namespace MAUISampleDemo.View;

public partial class LocalNotificationPage : ContentPage
{
	public LocalNotificationPage()
	{
		InitializeComponent();
	}

    private async void FrmLocalNtf_Tapped(object sender, EventArgs e)
    {
        await FrmLocalNtf.ScaleTo(0.9, 100, Easing.Linear);
        await FrmLocalNtf.ScaleTo(1.0, 100, Easing.Linear);
        var request = new NotificationRequest
			{
			NotificationId = 123,
			Title = "Testing",
			Subtitle = "Test Data",
			Description = "This is testing purpose",
			BadgeNumber = 12,
			Schedule = new NotificationRequestSchedule
			{
				NotifyTime = DateTime.Now.AddSeconds(2),
				NotifyRepeatInterval = TimeSpan.FromDays(1),
			}
			};
			LocalNotificationCenter.Current.Show(request);
    }
}