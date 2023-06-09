using System.Globalization;
using Microsoft.Maui.Graphics;

namespace BezierCurve
{
    public class CoordsConcatMultiConverter : IMultiValueConverter
    {
        public object Convert(object[] values, Type targetType, object parameter, CultureInfo culture)
        {
            if (values is null)
                return null;

            if (values[0] is not double X)
                return null;

            if (values[1] is not double Y)
                return null;

            return new Point(X, Y);
        }

        public object[] ConvertBack(object value, Type[] targetTypes, object parameter, CultureInfo culture)
        {
            var p = (Point)value;
            return new object[] { p.X, p.Y };
        }
    }
}
