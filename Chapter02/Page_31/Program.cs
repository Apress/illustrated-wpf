using System;
using System.Windows;

namespace MySimpleProgramConsole
{
   class MyWindow : Window
   {
      public MyWindow()                         // Constructor
      {
         Width    = 300;
         Height   = 200;
         Title    = "My Simple Window";
         Content  = "Hi There!";
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
