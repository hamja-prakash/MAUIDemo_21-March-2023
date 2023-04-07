using System.Globalization;

namespace MAUISampleDemo.Helpers
{
    public class BytesToImageConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if(value == null)
                return null;
            var bytes = (byte[])value;
            var streamsource = ImageSource.FromStream(()=> new MemoryStream(bytes));
            return streamsource;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
