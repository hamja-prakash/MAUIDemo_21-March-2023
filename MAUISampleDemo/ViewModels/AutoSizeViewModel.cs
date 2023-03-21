using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using MAUISampleDemo.Model;
using MAUISampleDemo.View;
using Microsoft.VisualBasic;
using System.Collections.ObjectModel;

namespace MAUISampleDemo.ViewModels
{
    public partial class AutoSizeViewModel : ObservableObject
    {
        [ObservableProperty]
        public ObservableCollection<Client> clientList;

        public string CheckImg = "iconsquarecheck.png";
        public string UnCheckImg = "iconsquareuncheck.png";

        [ObservableProperty]
        public string displayName;

        public AutoSizeViewModel()
        {
            clientList = new ObservableCollection<Client>();
            BindClientData();
        }

        public ObservableCollection<Client> BindClientData()
        {
            try
            {
                ClientList.Add(new Client
                {
                    Name = "Grace Michal",
                    CheckboxImg = "iconsquareuncheck.png"
                });

                ClientList.Add(new Client
                {
                    Name = "Flynn Res",
                    CheckboxImg = "iconsquareuncheck.png"
                });

                ClientList.Add(new Client
                {
                    Name = "Zane Modestr",
                    CheckboxImg = "iconsquareuncheck.png"
                });

                ClientList.Add(new Client
                {
                    Name = "Kleeman xyz",
                    CheckboxImg = "iconsquareuncheck.png"
                });

                ClientList.Add(new Client
                {
                    Name = "Zachary Mongero",
                    CheckboxImg = "iconsquareuncheck.png"
                });

                ClientList.Add(new Client
                {
                    Name = "Cheney Ralet",
                    CheckboxImg = "iconsquareuncheck.png"
                });

                ClientList.Add(new Client
                {
                    Name = "Goffage Marsh",
                    CheckboxImg = "iconsquareuncheck.png"
                });

                ClientList.Add(new Client
                {
                    Name = "Alex Sammy",
                    CheckboxImg = "iconsquareuncheck.png"
                });

                ClientList.Add(new Client
                {
                    Name = "Test1",
                    CheckboxImg = "iconsquareuncheck.png"
                });

                ClientList.Add(new Client
                {
                    Name = "Test2",
                    CheckboxImg = "iconsquareuncheck.png"
                });

                ClientList.Add(new Client
                {
                    Name = "Test3",
                    CheckboxImg = "iconsquareuncheck.png"
                });

                ClientList.Add(new Client
                {
                    Name = "Test4",
                    CheckboxImg = "iconsquareuncheck.png"
                });
            }
            catch (Exception ex)
            {
                var err = ex.Message;
            }
            return ClientList;
        }

        [RelayCommand]
        public void SelectItem(Client mClient)
        {
            if (mClient != null)
            {
                if (mClient.CheckboxImg == UnCheckImg)
                    mClient.CheckboxImg = CheckImg;
                else
                    mClient.CheckboxImg = UnCheckImg;

                var selectedItems = ClientList.Where(x => x.checkboxImg == CheckImg).ToList();
                if (selectedItems != null && selectedItems.Count > 0)
                {
                    var names = selectedItems.Select(x => x.Name).ToList();
                    DisplayName = string.Join(", ", names);
                    var data = DisplayName;
                }
                else
                    DisplayName = string.Empty;
            }
        }
    }
}
