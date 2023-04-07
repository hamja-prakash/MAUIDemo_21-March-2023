using System.ComponentModel;

namespace MAUISampleDemo.Model
{
    public class WeekDays : INotifyPropertyChanged
    {
        public string Name { get; set; }

        public string _checkImg;
        public string CheckImg
        {
            get
            {
                return _checkImg;
            }
            set
            {
                _checkImg = value;
                OnPropertyChanged("CheckImg");
            }
        }
        //public bool isCheck;
        //public bool IsCheck
        //{
        //    get
        //    {
        //        return isCheck;
        //    }
        //    set
        //    {
        //        isCheck = value;
        //        OnPropertyChanged("IsCheck");
        //    }
        //}


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
