using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Collections.ObjectModel;

namespace MAUISampleDemo.ViewModels
{
    public partial class ImagechangecolorViewModel : ObservableObject
    {
        private ColorItem _lastSelectedItem;

        [ObservableProperty]
        private ObservableCollection<ColorItem> colors;

        [ObservableProperty]
        private Color tintColor = Color.FromRgba("#000000");

        [ObservableProperty]
        private bool isAttached;

        public ImagechangecolorViewModel()
        {
            Colors = new ObservableCollection<ColorItem>()
            {
                new ColorItem(){ Color = Color.FromArgb("#12AD2B") },
                new ColorItem(){ Color = Color.FromArgb("#F7DC6F") },
                new ColorItem(){ Color = Color.FromArgb("#01F9C6") },
                new ColorItem(){ Color = Color.FromArgb("#FFA500") },
                new ColorItem(){ Color = Color.FromArgb("#A2AD9C") },
                new ColorItem(){ Color = Color.FromArgb("#728FCE") },
                new ColorItem(){ Color = Color.FromArgb("#EB5406") },
                new ColorItem(){ Color = Color.FromArgb("#000000") },
                new ColorItem(){ Color = Color.FromArgb("#045D5D") },
            };
        }

        [RelayCommand]
        public void ColorItemClicked(ColorItem item)
        {
            if (item != null)
            {
                if (_lastSelectedItem != null)
                    _lastSelectedItem.IsSelected = false;
                _lastSelectedItem = item;
                item.IsSelected = true;
            }
        }

        [RelayCommand]
        private void ChangeImageTintColor()
        {
            if (_lastSelectedItem != null)
            {
                IsAttached = false;
                TintColor = _lastSelectedItem.Color;
                IsAttached = true;
            }
        }

        public partial class ColorItem : ObservableObject
        {
            [ObservableProperty]
            private bool isSelected;
            [ObservableProperty]
            private Color color;
        }
    }
}
