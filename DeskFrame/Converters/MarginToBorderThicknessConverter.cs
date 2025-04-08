using System.Globalization;
using System.Windows;
using System.Windows.Data;

namespace DeskFrame
{
    public class MarginToBorderThicknessConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is bool enabled)
            {
                return enabled ? new Thickness(-1.3,-1.3,-1.3,0) : new Thickness(0);
            }
            return new Thickness(0);
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}