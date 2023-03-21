using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Collections.ObjectModel;

namespace MAUISampleDemo.ViewModels
{
    public partial class StateContainerViewModel : ObservableObject
    {
        [ObservableProperty]
        private ObservableCollection<string> userList;

        [ObservableProperty]
        private string state;

        [ObservableProperty]
        private string user;

        public StateContainerViewModel()
        {
            State = "Loading";
            UserList = new ObservableCollection<string>();
            Task.Delay(5000).ContinueWith(t => GetList());
        }

        private void GetList()
        {
            UserList = new ObservableCollection<string>()
            {
                "User 1",
                "User 2",
                "User 3",
                "User 4",
            };
            // Change current state from "Loading" to "Success"
            State = "Success";
        }


        [RelayCommand]
        public void DeleteUser(string mUser)
        {
            Application.Current.Dispatcher.Dispatch(() =>
            {
                if (!string.IsNullOrEmpty(mUser))
                {
                    UserList.Remove(mUser);
                    if (UserList.Count <= 0)
                    {
                        State = "Empty";
                    }
                }
            });
        }

        [RelayCommand]
        public void AddUser()
        {
            Application.Current.Dispatcher.Dispatch(() =>
            {
                if (!string.IsNullOrEmpty(User))
                {
                    var userExist = userList.Where(x => x.Equals(User)).FirstOrDefault();   
                    if (userExist == null)
                    {
                        UserList.Add(User);
                        if (UserList.Count > 0)
                        {
                            State = "Success";
                        }
                        User = string.Empty;
                    }
                }
            });
        }
    }
}
