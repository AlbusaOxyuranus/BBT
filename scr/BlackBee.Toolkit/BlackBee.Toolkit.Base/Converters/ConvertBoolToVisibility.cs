using System;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Data;

namespace BlackBee.Toolkit.Base.Converters
{
    /// <summary>
    /// 
    /// </summary>
    public class ConvertBoolToVisibility : IValueConverter
    {
        //public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        //{
        //    if (bool.Parse(value.ToString()))
        //        return Visibility.Visible;
        //    return Visibility.Collapsed;
        //}

        //public object ConvertBack(object value, Type targetType, object parameter,
        //    CultureInfo culture)
        //{
        //    Visibility visibility;
        //    Visibility.TryParse(value.ToString(), true, out visibility);
        //    if (visibility == Visibility.Visible)
        //        return true;
        //    return false;
        //}

        public object Convert(object value, Type targetType, object parameter, string language)
        {
            if (bool.Parse(value.ToString()))
                return Visibility.Visible;
            return Visibility.Collapsed;
        }

        public object ConvertBack(object value, Type targetType, object parameter, string language)
        {
            Visibility visibility;
            Visibility.TryParse(value.ToString(), true, out visibility);
            if (visibility == Visibility.Visible)
                return true;
            return false;
        }
    }
}
