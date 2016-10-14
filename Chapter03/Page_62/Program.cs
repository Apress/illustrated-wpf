using System;
using System.Windows;
using System.Windows.Media;

namespace IllustratedRadialGradientBrush
{
   class Program
   {
      [STAThread]
      static void Main()
      {
         Window win = new Window(); win.Height = 200; win.Width = 275;
         win.Title = "Radial Gradient Brush";

         RadialGradientBrush lgb =
            new RadialGradientBrush ( Colors.White, Colors.Black );

         win.Background = lgb;

         Application app = new Application();
         app.Run( win );
      }
   }
}
