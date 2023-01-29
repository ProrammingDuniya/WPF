using System;
using System.Globalization;
using System.Windows.Data;

namespace WPFValueConverter
{
    /// <summary>
    /// Summary description for Class1
    /// </summary>
    public class CheckBoxCheckConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value?.ToString()?.ToUpper() == "MARRIED")
                return true;

            return false;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            bool married = System.Convert.ToBoolean(value);
            if (married == true)
                return "Married";
            else
                return "Unmarried";
        }
    }
}
