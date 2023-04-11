using Firebase.Auth;
using MAUISampleDemo.Helpers;
using MAUISampleDemo.View;
using Newtonsoft.Json;
using System.ComponentModel;

namespace MAUISampleDemo.ViewModels
{
    public class EmailAuthViewModel : INotifyPropertyChanged
    {
        public string webApiKey = "AIzaSyBL5s134DujtT8Dopjb07VuhaPkt5s3RT8";
        private string userName;
        private string userPassword;

        public Command RegisterBtn { get; }
        public Command LoginBtn { get; }

        public string UserName
        {
            get => userName; set
            {
                userName = value;
                OnPropertyChanged("UserName");
            }
        }

        public string UserPassword
        {
            get => userPassword; set
            {
                userPassword = value;
                OnPropertyChanged("UserPassword");
            }
        }

        public EmailAuthViewModel()
        {
            RegisterBtn = new Command(RegisterBtnTappedAsync);
            LoginBtn = new Command(LoginBtnTappedAsync);
        }

        public bool Validation()
        {
            bool isValid = false;
            if (string.IsNullOrEmpty(UserName) || string.IsNullOrWhiteSpace(UserName))
                DisplayMessages.AlertMessage(CommonMessages.RequireEmail);

            else if (string.IsNullOrEmpty(UserPassword) || string.IsNullOrWhiteSpace(UserPassword))
                DisplayMessages.AlertMessage(CommonMessages.RequirePassword);
            else
                isValid = true;

            return isValid;
        }

        private async void LoginBtnTappedAsync(object obj)
        {
            try
            {
                if (Validation())
                {
                    var authProvider = new FirebaseAuthProvider(new FirebaseConfig(webApiKey));
                    var auth = await authProvider.SignInWithEmailAndPasswordAsync(UserName, UserPassword);
                    if(auth != null)
                    {
                        var content = await auth.GetFreshAuthAsync();
                        var serializedContent = JsonConvert.SerializeObject(content);
                        Preferences.Set("FreshFirebaseToken", serializedContent);
                        await App.Current.MainPage.Navigation.PushAsync(new EmailAuthDashboradPage());
                    }
                }
            }
            catch (Exception ex)
            {
                await App.Current.MainPage.DisplayAlert("Alert", ex.Message, "OK");
                //DisplayMessages.AlertMessage(ex.Message);
            }
        }

        private async void RegisterBtnTappedAsync(object obj)
        {
            await App.Current.MainPage.Navigation.PushAsync(new EmailAuthRegisterPage());
        }

        protected virtual void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
        public event PropertyChangedEventHandler PropertyChanged;
    }
}
