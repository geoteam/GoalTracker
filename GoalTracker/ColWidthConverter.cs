using System;
using System.Globalization;
using System.Windows.Data;

namespace GoalTracker {
   class ColWidthConverter : IMultiValueConverter {
      public object Convert(object[] values, Type targetType, object parameter, CultureInfo culture) {
         return ((Double)values[0] * (Double)values[1]) / 100.0;
      }

      public object[] ConvertBack(object value, Type[] targetTypes, object parameter, CultureInfo culture) {
         throw new NotImplementedException();
      }
   }
}
