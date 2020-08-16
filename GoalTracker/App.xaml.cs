using System;
using System.Windows;
using System.Windows.Threading;

namespace GoalTracker {
   /// <summary>
   /// Interaction logic for App.xaml
   /// </summary>
   public partial class App : Application {
      private void ApplicationUnhandledException(Object sender, DispatcherUnhandledExceptionEventArgs e) {
         MessageBox.Show("An unhandled exception just occured: " + e.Exception.Message, "Unhandled Exception", MessageBoxButton.OK, MessageBoxImage.Error);
         e.Handled = true;
      }
   }
}
