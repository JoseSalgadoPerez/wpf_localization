using System;
using System.Windows.Data;

namespace wpf_localization.Converters
{
    public class IntegerToTimespanConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            return System.TimeSpan.FromMilliseconds((int)value);
        }

        public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
