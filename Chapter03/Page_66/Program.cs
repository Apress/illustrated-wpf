using System;
using System.Windows;
using System.Windows.Media;
using System.Windows.Controls;   // Contains the declaration of SolidColorBrush.

namespace ApplicationAddEventHandler
{
   class MyWindow : Window
   {
      public MyWindow()
      {
         Width = 300;  Height = 200;
         Title = "My Program Window";
         Content = "This application handles the Startup event.";
      }
   }

   class Program
   {
      static void App_Startup( object sender, StartupEventArgs args )
      {
         MessageBox.Show( "The application is starting.", "Starting Message" );
      }

      [STAThread]
      static void Main()
      {
         MyWindow win = new MyWindow();

         Application app = new Application();
         app.Startup += App_Startup;

         app.Run( win );
      }
   }
}
