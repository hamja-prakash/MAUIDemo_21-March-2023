using System.ComponentModel;
using System.Globalization;

namespace MAUISampleDemo
{
    public class LocalizationResourceManager : INotifyPropertyChanged
    {
        private LocalizationResourceManager()
        {
            MAUISampleDemo.Resources.Language.AppResources.Culture = CultureInfo.CurrentCulture;
        }

        public static LocalizationResourceManager Instance { get; } = new();

        public object this[string resourceKey]
            => MAUISampleDemo.Resources.Language.AppResources.ResourceManager.GetObject(resourceKey, MAUISampleDemo.Resources.Language.AppResources.Culture) ?? Array.Empty<byte>();

        public event PropertyChangedEventHandler PropertyChanged;

        public void SetCulture(CultureInfo culture)
        {
            MAUISampleDemo.Resources.Language.AppResources.Culture = culture;
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(null));
        }
    }
}
