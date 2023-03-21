using CommunityToolkit.Mvvm.ComponentModel;

namespace MAUISampleDemo.Model
{
    public partial class CalenderModel : ObservableObject
    {
        [ObservableProperty]
        public DateTime date;
        [ObservableProperty]
        public string day;
        [ObservableProperty]
        public DateTime month;
        [ObservableProperty]
        public string year;
        [ObservableProperty]
        public Color bgColor;
        [ObservableProperty]
        public Color textcolor;
    }
}
