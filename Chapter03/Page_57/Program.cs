using System;
using System.Windows;
using System.Windows.Media;   // Contains the declaration of SolidColorBrush.

namespace IllustratedSolidColorBrush
{
   class Program
   {
      [STAThread]
      static void Main()
      {
         Window win  = new Window();
         win.Width   = 250;
         win.Height  = 150;
         win.Title   = "Using Colors";

         win.Background = new SolidColorBrush( Colors.CornflowerBlue );
         win.Foreground = new SolidColorBrush( Colors.Crimson );

         win.Content    = "This is some text.";

         Application app = new Application();
         app.Run( win );
      }
   }
}
