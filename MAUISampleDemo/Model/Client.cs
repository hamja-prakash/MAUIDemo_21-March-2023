using CommunityToolkit.Mvvm.ComponentModel;

namespace MAUISampleDemo.Model
{
    public partial class Client :ObservableObject
    {
        [ObservableProperty]
        public string name;

        [ObservableProperty]
        public string checkboxImg;
    }
}
