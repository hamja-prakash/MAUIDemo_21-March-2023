using Acr.UserDialogs;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Plugin.BLE;
using Plugin.BLE.Abstractions.Contracts;
using Plugin.Permissions.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAUISampleDemo.ViewModels
{
    public partial class BlutoothScanningViewModel : ObservableObject
    {
        private readonly IAdapter _adapter;
        private readonly IBluetoothLE ble;
        
        public BlutoothScanningViewModel()
        {
            DevicesList = new List<IDevice>();
            _adapter = CrossBluetoothLE.Current.Adapter;
            ble = CrossBluetoothLE.Current;
        }

        [ObservableProperty]
        private List<IDevice> devicesList;

        [RelayCommand]
        public async void ScanDevice()
        {
            try
            {
                DevicesList.Clear();
                await CheckBlutooth();
                _adapter.DeviceDiscovered += (s, a) =>
                {
                    DevicesList.Add(a.Device);
                };

                if (!ble.Adapter.IsScanning)
                {
                    // Set the scanning time to 10 seconds (10000 milliseconds)
                    _adapter.ScanTimeout = 10000;
                    UserDialogs.Instance.ShowLoading("Scanning");
                    await _adapter.StartScanningForDevicesAsync();
                    UserDialogs.Instance.HideLoading();
                }
                DevicesList = DevicesList.Where(x => (!string.IsNullOrEmpty(x.Name))).ToList();
            }
            catch (Exception ex)
            {
                App.Current.MainPage.DisplayAlert("Notice", ex.Message.ToString(), "Error !");
            }
            finally
            {
                UserDialogs.Instance.HideLoading();
            }
        }

        [RelayCommand]
        public async void SelectDevice(IDevice mDevice)
        {
            if (mDevice != null)
            {
                await App.Current.MainPage.DisplayAlert("BLE", mDevice.Name.ToString(), "Ok", "Cancel");
            }
        }

        public async Task CheckBlutooth()
        {
            if (DeviceInfo.Platform != DevicePlatform.Android)
                return;
            //var status = Microsoft.Maui.ApplicationModel.PermissionStatus.Unknown;

            var status = await Permissions.CheckStatusAsync<Permissions.LocationWhenInUse>();

            if (status != Microsoft.Maui.ApplicationModel.PermissionStatus.Granted)
            {
                if (await Plugin.Permissions.CrossPermissions.Current.ShouldShowRequestPermissionRationaleAsync(Permission.Location))
                {
                    await App.Current.MainPage.DisplayAlert("Need location", "App needs location permission", "OK");
                }

                var status1 = await Plugin.Permissions.CrossPermissions.Current.RequestPermissionsAsync(new[] { Permission.Location });

                var loca = status1.FirstOrDefault(x => x.Key == Permission.Location);
                //if (loca.Value != null)
                //    if (loca.Value == Microsoft.Maui.ApplicationModel.PermissionStatus.Granted) status = PermissionStatus.Granted;
            }

            if (status != Microsoft.Maui.ApplicationModel.PermissionStatus.Granted)
            {
                await App.Current.MainPage.DisplayAlert("Need location", "App need location permission", "OK");
                return;
            }
        }
    }
}
