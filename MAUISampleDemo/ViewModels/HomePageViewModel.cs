using MAUISampleDemo.Model;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace MAUISampleDemo.ViewModels
{

    public class HomePageViewModel : INotifyPropertyChanged
    {
        public ObservableCollection<User> _Users;

        public ObservableCollection<User> Users
        {
            get => _Users;
            set { _Users = value; OnPropertyChanged(); }
        }

        public Command<User> DeleteItemCommand { get; set; }
        public Command FrmTestCommand { get; set; }
        public Command<User> FrmUserDetailsCommand { get; set; }

        private string nodatamsg = "No Data Available!";
        public string NoDataMsg
        {
            get { return nodatamsg; }
            set
            {
                nodatamsg = value;
                PropertyChanged(this, new PropertyChangedEventArgs("NoDataMsg"));
            }
        }

        private bool msgVisibility = false;
        public bool MsgVisibility
        {
            get { return msgVisibility; }
            set
            {
                msgVisibility = value;
                PropertyChanged(this, new PropertyChangedEventArgs("MsgVisibility"));
            }
        }

        private bool listVisibility;
        public bool ListVisibility
        {
            get { return listVisibility; }
            set
            {
                listVisibility = value;
                PropertyChanged(this, new PropertyChangedEventArgs("ListVisibility"));
            }
        }

        public HomePageViewModel()
        {
            Users = new ObservableCollection<User>();
            DeleteItemCommand = new Command<User>(OnDeleteItem);
            FrmTestCommand = new Command(OnUserClick);
            FrmUserDetailsCommand = new Command<User>(OnUserDetails);
            BindUserData();
        }

        private void OnDeleteItem(User item)
        {
            if (Users != null && Users.Count > 0)
            {
                ListVisibility = true;
                MsgVisibility = false;
                Users.Remove(item);
                if (Users.Count == 0)
                {
                    ListVisibility = false;
                    MsgVisibility = true;
                }
            }
        }

        private async void OnUserDetails(User user)
        {
            if (user != null)
            {
                await App.Current.MainPage.DisplayAlert("test", user.FirstName, "Ok", "Cancel");
            }
        }

        private async void OnUserClick(object sender)
        {
            var frmuser = sender as Frame;
            await frmuser.ScaleTo(0.9, 100, Easing.Linear);
            await frmuser.ScaleTo(1.0, 100, Easing.Linear);
        }

        public ObservableCollection<User> BindUserData()
        {
            try
            {
                Users.Add(new User
                {
                    FirstName = "Grace",
                    LastName = "Flynn",
                    Email = "GraceFlynn@rhyta.com",
                    MobileNo = "508-392-8946",
                    Gender = "Male"
                });

                Users.Add(new User
                {
                    FirstName = "Zane",
                    LastName = "Kleeman",
                    Email = "ZaneKleeman@jourrapide.com",
                    MobileNo = "484-786-2089",
                    Gender = "Male"
                });

                Users.Add(new User
                {
                    FirstName = "Keira",
                    LastName = "Beauchamp",
                    Email = "KeiraBeauchamp@dayrep.com",
                    MobileNo = "786-554-5913",
                    Gender = "Female"
                });

                Users.Add(new User
                {
                    FirstName = "Zachary",
                    LastName = "Cheney",
                    Email = "ZacharyCheney@teleworm.us",
                    MobileNo = "618-206-2235",
                    Gender = "Male"
                });

                Users.Add(new User
                {
                    FirstName = "Archer",
                    LastName = "Goffage",
                    Email = "ArcherGoffage@teleworm.us",
                    MobileNo = "661-443-7850",
                    Gender = "Female"
                });
                Users.Add(new User
                {
                    FirstName = "Grace",
                    LastName = "Flynn",
                    Email = "GraceFlynn@rhyta.com",
                    MobileNo = "508-392-8946",
                    Gender = "Male"
                });

                Users.Add(new User
                {
                    FirstName = "Zane",
                    LastName = "Kleeman",
                    Email = "ZaneKleeman@jourrapide.com",
                    MobileNo = "484-786-2089",
                    Gender = "Male"
                });

                Users.Add(new User
                {
                    FirstName = "Keira",
                    LastName = "Beauchamp",
                    Email = "KeiraBeauchamp@dayrep.com",
                    MobileNo = "786-554-5913",
                    Gender = "Female"
                });

                Users.Add(new User
                {
                    FirstName = "Zachary",
                    LastName = "Cheney",
                    Email = "ZacharyCheney@teleworm.us",
                    MobileNo = "618-206-2235",
                    Gender = "Male"
                });

                Users.Add(new User
                {
                    FirstName = "Archer",
                    LastName = "Goffage",
                    Email = "ArcherGoffage@teleworm.us",
                    MobileNo = "661-443-7850",
                    Gender = "Female"
                });
                Users.Add(new User
                {
                    FirstName = "Grace",
                    LastName = "Flynn",
                    Email = "GraceFlynn@rhyta.com",
                    MobileNo = "508-392-8946",
                    Gender = "Male"
                });

                Users.Add(new User
                {
                    FirstName = "Zane",
                    LastName = "Kleeman",
                    Email = "ZaneKleeman@jourrapide.com",
                    MobileNo = "484-786-2089",
                    Gender = "Male"
                });

                Users.Add(new User
                {
                    FirstName = "Keira",
                    LastName = "Beauchamp",
                    Email = "KeiraBeauchamp@dayrep.com",
                    MobileNo = "786-554-5913",
                    Gender = "Female"
                });

                Users.Add(new User
                {
                    FirstName = "Zachary",
                    LastName = "Cheney",
                    Email = "ZacharyCheney@teleworm.us",
                    MobileNo = "618-206-2235",
                    Gender = "Male"
                });

                Users.Add(new User
                {
                    FirstName = "Archer",
                    LastName = "Goffage",
                    Email = "ArcherGoffage@teleworm.us",
                    MobileNo = "661-443-7850",
                    Gender = "Female"
                });
                Users.Add(new User
                {
                    FirstName = "Grace",
                    LastName = "Flynn",
                    Email = "GraceFlynn@rhyta.com",
                    MobileNo = "508-392-8946",
                    Gender = "Male"
                });

                Users.Add(new User
                {
                    FirstName = "Zane",
                    LastName = "Kleeman",
                    Email = "ZaneKleeman@jourrapide.com",
                    MobileNo = "484-786-2089",
                    Gender = "Male"
                });

                Users.Add(new User
                {
                    FirstName = "Keira",
                    LastName = "Beauchamp",
                    Email = "KeiraBeauchamp@dayrep.com",
                    MobileNo = "786-554-5913",
                    Gender = "Female"
                });

                Users.Add(new User
                {
                    FirstName = "Zachary",
                    LastName = "Cheney",
                    Email = "ZacharyCheney@teleworm.us",
                    MobileNo = "618-206-2235",
                    Gender = "Male"
                });

                Users.Add(new User
                {
                    FirstName = "Archer",
                    LastName = "Goffage",
                    Email = "ArcherGoffage@teleworm.us",
                    MobileNo = "661-443-7850",
                    Gender = "Female"
                });
                Users.Add(new User
                {
                    FirstName = "Grace",
                    LastName = "Flynn",
                    Email = "GraceFlynn@rhyta.com",
                    MobileNo = "508-392-8946",
                    Gender = "Male"
                });

                Users.Add(new User
                {
                    FirstName = "Zane",
                    LastName = "Kleeman",
                    Email = "ZaneKleeman@jourrapide.com",
                    MobileNo = "484-786-2089",
                    Gender = "Male"
                });

                Users.Add(new User
                {
                    FirstName = "Keira",
                    LastName = "Beauchamp",
                    Email = "KeiraBeauchamp@dayrep.com",
                    MobileNo = "786-554-5913",
                    Gender = "Female"
                });

                Users.Add(new User
                {
                    FirstName = "Zachary",
                    LastName = "Cheney",
                    Email = "ZacharyCheney@teleworm.us",
                    MobileNo = "618-206-2235",
                    Gender = "Male"
                });

                Users.Add(new User
                {
                    FirstName = "Archer",
                    LastName = "Goffage",
                    Email = "ArcherGoffage@teleworm.us",
                    MobileNo = "661-443-7850",
                    Gender = "Female"
                });
                Users.Add(new User
                {
                    FirstName = "Grace",
                    LastName = "Flynn",
                    Email = "GraceFlynn@rhyta.com",
                    MobileNo = "508-392-8946",
                    Gender = "Male"
                });

                Users.Add(new User
                {
                    FirstName = "Zane",
                    LastName = "Kleeman",
                    Email = "ZaneKleeman@jourrapide.com",
                    MobileNo = "484-786-2089",
                    Gender = "Male"
                });

                Users.Add(new User
                {
                    FirstName = "Keira",
                    LastName = "Beauchamp",
                    Email = "KeiraBeauchamp@dayrep.com",
                    MobileNo = "786-554-5913",
                    Gender = "Female"
                });

                Users.Add(new User
                {
                    FirstName = "Zachary",
                    LastName = "Cheney",
                    Email = "ZacharyCheney@teleworm.us",
                    MobileNo = "618-206-2235",
                    Gender = "Male"
                });

                Users.Add(new User
                {
                    FirstName = "Archer",
                    LastName = "Goffage",
                    Email = "ArcherGoffage@teleworm.us",
                    MobileNo = "661-443-7850",
                    Gender = "Female"
                });
                Users.Add(new User
                {
                    FirstName = "Grace",
                    LastName = "Flynn",
                    Email = "GraceFlynn@rhyta.com",
                    MobileNo = "508-392-8946",
                    Gender = "Male"
                });

                Users.Add(new User
                {
                    FirstName = "Zane",
                    LastName = "Kleeman",
                    Email = "ZaneKleeman@jourrapide.com",
                    MobileNo = "484-786-2089",
                    Gender = "Male"
                });

                Users.Add(new User
                {
                    FirstName = "Keira",
                    LastName = "Beauchamp",
                    Email = "KeiraBeauchamp@dayrep.com",
                    MobileNo = "786-554-5913",
                    Gender = "Female"
                });

                Users.Add(new User
                {
                    FirstName = "Zachary",
                    LastName = "Cheney",
                    Email = "ZacharyCheney@teleworm.us",
                    MobileNo = "618-206-2235",
                    Gender = "Male"
                });

                Users.Add(new User
                {
                    FirstName = "Archer",
                    LastName = "Goffage",
                    Email = "ArcherGoffage@teleworm.us",
                    MobileNo = "661-443-7850",
                    Gender = "Female"
                });
                Users.Add(new User
                {
                    FirstName = "Grace",
                    LastName = "Flynn",
                    Email = "GraceFlynn@rhyta.com",
                    MobileNo = "508-392-8946",
                    Gender = "Male"
                });

                Users.Add(new User
                {
                    FirstName = "Zane",
                    LastName = "Kleeman",
                    Email = "ZaneKleeman@jourrapide.com",
                    MobileNo = "484-786-2089",
                    Gender = "Male"
                });

                Users.Add(new User
                {
                    FirstName = "Keira",
                    LastName = "Beauchamp",
                    Email = "KeiraBeauchamp@dayrep.com",
                    MobileNo = "786-554-5913",
                    Gender = "Female"
                });

                Users.Add(new User
                {
                    FirstName = "Zachary",
                    LastName = "Cheney",
                    Email = "ZacharyCheney@teleworm.us",
                    MobileNo = "618-206-2235",
                    Gender = "Male"
                });

                Users.Add(new User
                {
                    FirstName = "Archer",
                    LastName = "Goffage",
                    Email = "ArcherGoffage@teleworm.us",
                    MobileNo = "661-443-7850",
                    Gender = "Female"
                });
                Users.Add(new User
                {
                    FirstName = "Grace",
                    LastName = "Flynn",
                    Email = "GraceFlynn@rhyta.com",
                    MobileNo = "508-392-8946",
                    Gender = "Male"
                });

                Users.Add(new User
                {
                    FirstName = "Zane",
                    LastName = "Kleeman",
                    Email = "ZaneKleeman@jourrapide.com",
                    MobileNo = "484-786-2089",
                    Gender = "Male"
                });

                Users.Add(new User
                {
                    FirstName = "Keira",
                    LastName = "Beauchamp",
                    Email = "KeiraBeauchamp@dayrep.com",
                    MobileNo = "786-554-5913",
                    Gender = "Female"
                });

                Users.Add(new User
                {
                    FirstName = "Zachary",
                    LastName = "Cheney",
                    Email = "ZacharyCheney@teleworm.us",
                    MobileNo = "618-206-2235",
                    Gender = "Male"
                });

                Users.Add(new User
                {
                    FirstName = "Archer",
                    LastName = "Goffage",
                    Email = "ArcherGoffage@teleworm.us",
                    MobileNo = "661-443-7850",
                    Gender = "Female"
                });
                Users.Add(new User
                {
                    FirstName = "Grace",
                    LastName = "Flynn",
                    Email = "GraceFlynn@rhyta.com",
                    MobileNo = "508-392-8946",
                    Gender = "Male"
                });

                Users.Add(new User
                {
                    FirstName = "Zane",
                    LastName = "Kleeman",
                    Email = "ZaneKleeman@jourrapide.com",
                    MobileNo = "484-786-2089",
                    Gender = "Male"
                });

                Users.Add(new User
                {
                    FirstName = "Keira",
                    LastName = "Beauchamp",
                    Email = "KeiraBeauchamp@dayrep.com",
                    MobileNo = "786-554-5913",
                    Gender = "Female"
                });

                Users.Add(new User
                {
                    FirstName = "Zachary",
                    LastName = "Cheney",
                    Email = "ZacharyCheney@teleworm.us",
                    MobileNo = "618-206-2235",
                    Gender = "Male"
                });

                Users.Add(new User
                {
                    FirstName = "Archer",
                    LastName = "Goffage",
                    Email = "ArcherGoffage@teleworm.us",
                    MobileNo = "661-443-7850",
                    Gender = "Female"
                });
                return Users;
            }
            catch (Exception)
            {

                throw;
            }
        }


        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged([CallerMemberName] string propertyName = "")
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}
