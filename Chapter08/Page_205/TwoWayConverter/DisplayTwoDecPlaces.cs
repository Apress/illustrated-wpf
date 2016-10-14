using System;
using System.Windows.Data;

namespace TwoWayConverter
{
   [ValueConversion( typeof( double ), typeof( string ) )]
   public class DisplayTwoDecPlaces : IValueConverter
   {
      public object Convert( object value, Type targetType, object parameter,
         System.Globalization.CultureInfo culture )
      {
         double dValue = (double) value;
         return dValue.ToString( "F2" );
      }

      public object ConvertBack( object value, Type targetType, object parameter,
         System.Globalization.CultureInfo culture )
      {
         double dValue;
         double.TryParse( (string) value, out dValue );
         return dValue;
      }
   }
}
