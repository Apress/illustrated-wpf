using System;
using System.Windows;
using System.Windows.Media;   // Contains the declaration of SolidColorBrush.

namespace IllustratedLinearGradientBrush
{
   class Program
   {
      [STAThread]
      static void Main()
      {
         Window win = new Window();
         win.Height = 200; win.Width = 275; win.Title = "Linear Gradient Brush";

         Point first  = new Point( 0, 0 );   // Start point
         Point second = new Point( 1, 1 );   // End point

         LinearGradientBrush lgb =
            new LinearGradientBrush( Colors.White, Colors.Black, first, second );
         win.Background = lgb;

         Application app = new Application();
         app.Run( win );
      }
   }
}
