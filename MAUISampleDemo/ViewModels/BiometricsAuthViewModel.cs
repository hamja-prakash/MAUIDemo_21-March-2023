using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Plugin.Fingerprint.Abstractions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace MAUISampleDemo.ViewModels
{
    public partial class BiometricsAuthViewModel : ObservableObject
    {
        private readonly IFingerprint _fingerprint;
        [ObservableProperty]
        private string _userName;
        [ObservableProperty]
        private string _password;

        public BiometricsAuthViewModel(IFingerprint fingerprint)
        {
            _fingerprint = fingerprint;
            FingerprintMethod();
        }

        [RelayCommand]
        async Task FingerprintMethod()
        {
            var isBiometricsAvailable = await _fingerprint.IsAvailableAsync();

            if (isBiometricsAvailable)
            {
                var dialogConfig = new AuthenticationRequestConfiguration
                ("Login using biometrics", "Confirm login with your biometrics")
                {
                    FallbackTitle = "Use Password",
                    AllowAlternativeAuthentication = true,
                };

                var result = await _fingerprint.AuthenticateAsync(dialogConfig);

                if (result.Authenticated)
                {
                    App.Current.MainPage.DisplayAlert("Access", "Done", "Ok", "Cancel");
                }
                else
                {

                }
            }
        }
    }
}
