using System;
using System.Windows;

namespace WindowStyles
{
   class Program
   {
      [STAThread]
      static void Main()
      {
         Window win = new Window();
         win.Height = 75; win.Width = 300;
         win.Title  = "WindowStyles";

         win.WindowStyle = WindowStyle.SingleBorderWindow;
         win.Content     = win.WindowStyle.ToString();

         Application app = new Application();
         app.Run( win);
      }
   }
}
