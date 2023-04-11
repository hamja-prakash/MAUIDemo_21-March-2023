using Firebase.Auth;
using MAUISampleDemo.Helpers;
using System.ComponentModel;

namespace MAUISampleDemo.ViewModels
{
    public class EmailAuthRegisterViewModel : INotifyPropertyChanged
    {
        public string webApiKey = "AIzaSyBL5s134DujtT8Dopjb07VuhaPkt5s3RT8";

        private INavigation _navigation;
        private string email;
        private string password;

        public string Email
        {
            get => email;
            set
            {
                email = value;
                OnPropertyChanged("Email");
            }
        }

        public string Password
        {
            get => password; set
            {
                password = value;
                OnPropertyChanged("Password");
            }
        }

        public Command RegisterUser { get; }

        public EmailAuthRegisterViewModel()
        {
            RegisterUser = new Command(RegisterUserTappedAsync);
        }

        public bool Validation()
        {
            bool isValid = false;
            if (string.IsNullOrEmpty(Email) || string.IsNullOrWhiteSpace(Email))
                DisplayMessages.AlertMessage(CommonMessages.RequireEmail);

            else if (!Common.ValidateEmail(Email.Trim()))
                DisplayMessages.AlertMessage(CommonMessages.InvalidEmail);

            else if (string.IsNullOrEmpty(Password) || string.IsNullOrWhiteSpace(Password))
                DisplayMessages.AlertMessage(CommonMessages.RequirePassword);

            else if (!Common.ValidatePassword(Password))
                DisplayMessages.AlertMessage(CommonMessages.InvalidPassword);

            else
                isValid = true;

            return isValid;
        }


        private async void RegisterUserTappedAsync(object obj)
        {
            try
            {
                if(Validation())
                {
                    var authProvider = new FirebaseAuthProvider(new FirebaseConfig(webApiKey));
                    var auth = await authProvider.CreateUserWithEmailAndPasswordAsync(Email, Password);
                    if (auth != null)
                    {
                        string token = auth.FirebaseToken;
                        if (token != null)
                        {
                            await App.Current.MainPage.DisplayAlert("Alert", "User Registered successfully", "OK");
                            await App.Current.MainPage.Navigation.PopAsync();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                await App.Current.MainPage.DisplayAlert("Alert", ex.Message, "OK");
                throw;
            }
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
