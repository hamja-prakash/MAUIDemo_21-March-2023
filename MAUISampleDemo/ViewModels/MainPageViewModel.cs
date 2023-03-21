using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using MAUISampleDemo.Helpers;
using MAUISampleDemo.View.Navigation;

namespace MAUISampleDemo.ViewModels
{
    public partial class MainPageViewModel : ObservableObject
    {
        IToast toast;
        IConnectivity connectivity;

        public MainPageViewModel(IConnectivity connectivity, IToast toast)
        {
            this.connectivity = connectivity;
            this.toast = toast;
        }

        [RelayCommand]
        public void CheckInternet()
        {
            NetworkAccess accessType = this.connectivity.NetworkAccess;

            if (accessType == NetworkAccess.Internet)
                toast.MakeToast("You Have Internet!");
            else
                toast.MakeToast("You Have no Internet!");
        }

        [RelayCommand]
        public async void CheckBlutooth()
        {
            if (DeviceInfo.Platform != DevicePlatform.Android)
                return;
            var status = PermissionStatus.Unknown;

            if (DeviceInfo.Version.Major >= 12)
            {
                status = await Permissions.CheckStatusAsync<CustomBluetoothPermission>();

                if (status == PermissionStatus.Granted)
                    return;

                if (Permissions.ShouldShowRationale<CustomBluetoothPermission>())
                {
                    await Shell.Current.DisplayAlert("Permissions", "Needs Permission", "OK");
                }

                status = await Permissions.RequestAsync<CustomBluetoothPermission>();
            }

            //var status = PermissionStatus.Unknown;

            //status = await Permissions.CheckStatusAsync<Permissions.LocationWhenInUse>();
            //if (status == PermissionStatus.Granted)
            //    return;

            //if(Permissions.ShouldShowRationale<Permissions.LocationWhenInUse>())
            //    await Shell.Current.DisplayAlert("Alert", "Need Location permission", "Ok", "Cancel");

            //status = await Permissions.RequestAsync<Permissions.LocationWhenInUse>();
            //if(status != PermissionStatus.Granted)
            //    await Shell.Current.DisplayAlert("Alert", "Need Location permission", "Ok", "Cancel");
        }

        int Count = 20;
        [RelayCommand]
        Task Navigate() =>
        Shell.Current.GoToAsync($"{nameof(NavPage1)}?Count={Count}");
        //new Dictionary<string, object>
        //{
        //    ["Monkey"] = monkey
        //});
    }
}
