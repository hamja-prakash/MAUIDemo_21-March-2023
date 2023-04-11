using Newtonsoft.Json;

namespace MAUISampleDemo.View;

public partial class EmailAuthDashboradPage : ContentPage
{
    public EmailAuthDashboradPage()
    {
        InitializeComponent();
        GetProfileData();
    }

    public void GetProfileData()
    {
        try
        {
            var userInfo = JsonConvert.DeserializeObject<Firebase.Auth.FirebaseAuth>(Preferences.Get("FreshFirebaseToken", ""));
            if (userInfo != null)
                UserEmail.Text = userInfo.User.Email;
        }
        catch (Exception ex)
        {
            var err = ex.Message;
        }
    }
}