using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAUISampleDemo.Helpers
{
    public class MultiBindingToColorConverter : IMultiValueConverter
    {
        private string Name { get; set; }
        private int Age { get; set; }
        private bool IsAdmin { get; set; }

        public object Convert(object[] values, Type targetType, object parameter, CultureInfo culture)
        {
            if (values != null)
            {
                foreach (var value in values)
                {
                    if (value is int age)
                    {
                        Age = age;
                    }

                    if (value is bool isAdmin)
                    {
                        IsAdmin = isAdmin;
                    }

                    if (value is string name)
                    {
                        Name = name;
                    }
                }

                if (string.IsNullOrEmpty(Name))
                {
                    return Colors.Black;
                }

                if (Age >= 18 && !IsAdmin)
                {
                    return Colors.Red;
                }
                else if (Age < 18 && !IsAdmin)
                {
                    return Colors.Blue;
                }
                else if (Age < 18 && IsAdmin)
                {
                    return Colors.Green;
                }
                else if (Age >= 18 && IsAdmin)
                {
                    return Colors.Fuchsia;
                }
            }

            return Colors.Black;
        }

        public object[] ConvertBack(object value, Type[] targetTypes, object parameter, CultureInfo culture) => targetTypes;
    }
}
