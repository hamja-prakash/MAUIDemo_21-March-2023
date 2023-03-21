using CommunityToolkit.Mvvm.ComponentModel;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;

namespace MAUISampleDemo.ViewModels
{
    public partial class ClvinsidescrViewModel : ObservableObject
    {
        public ClvinsidescrViewModel()
        {
            var images = new ObservableCollection<string>();

            for (int i = 0; i < 100; i++)
            {
                images.Add("img1.jpg");
                images.Add("img2.jpg");
            }
            ImagesList = images;
        }

        [ObservableProperty]
        public ObservableCollection<string> imagesList;

        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged(string name)
        {
            if (this.PropertyChanged != null)
                this.PropertyChanged(this, new PropertyChangedEventArgs(name));
        }
    }
}
