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
         win.Title   = "Creating Colors";

         Color MyColor = new Color();
         // Set the properties to values between 0 and 255.
         MyColor.A = 255;     // 0xFF
         MyColor.R = 100;     // 0x64
         MyColor.G = 150;     // 0x96
         MyColor.B = 200;     // 0xC8

         SolidColorBrush scb = new SolidColorBrush( MyColor );

         win.Background = scb;
         win.Content    = MyColor.ToString();      // Produces the string #FF6496C8

         Application app = new Application();
         app.Run( win );
      }
   }
}
