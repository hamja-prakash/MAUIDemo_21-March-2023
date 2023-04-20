using MvvmHelpers;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace MAUISampleDemo.Model
{
    public class TeacherGroup : ObservableRangeCollection<Teacher>, INotifyPropertyChanged
    {
        public string GroupTitle { get; set; }
        public string FooterTitle { get; set; }

        private string _groupIcon = "down_arrow";
        public string GroupIcon
        {
            get => _groupIcon;
            set => SetProperty(ref _groupIcon, value);
        }

        public TeacherGroup(string groupTitle, List<Teacher> teachers, string footerTitle = "") : base(teachers)
        {
            GroupTitle = groupTitle;
            FooterTitle = footerTitle;
        }

        protected bool SetProperty<T>(ref T backingStore, T value,
        [CallerMemberName] string propertyName = "",
        Action onChanged = null)
        {
            if (EqualityComparer<T>.Default.Equals(backingStore, value))
                return false;

            backingStore = value;
            onChanged?.Invoke();
            OnPropertyChanged(propertyName);
            return true;
        }

        #region INotifyPropertyChanged
        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string propertyName = "")
        {
            var changed = PropertyChanged;
            if (changed == null)
                return;

            changed.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        #endregion
    }
    public class Teacher
    {
        public string FullName { get; set; }
    }
}
