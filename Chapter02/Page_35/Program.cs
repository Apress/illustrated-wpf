using System;
using System.Windows;
using System.Windows.Media;
using System.Windows.Controls;

namespace WindowButton
{
   class MyWindow : Window
   {
      public MyWindow()
      {
         Title = "My Program Window";
         Width = 300; Height = 200;

         Button btn = new Button();    // Create a button.
         btn.Content = "Click Me";     // Set the button's text.

         Content = btn;
      }
   }

   class Program
   {
      [STAThread]
      static void Main()
      {
         MyWindow win = new MyWindow();
         win.Show();

         Application app = new Application();
         app.Run();
      }
   }
}
