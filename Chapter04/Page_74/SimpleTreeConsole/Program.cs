using System;
using System.Windows;
using System.Windows.Controls;

namespace SimpleTreeConsole
{
   class Program
   {
      class MyWindow : Window
      {
         public MyWindow()
         {
            StackPanel sp = new StackPanel();
            TextBlock txt = new TextBlock();
            Button btn    = new Button();

            txt.Text    = "Illustrated WPF";
            btn.Content = "Click Me";
            sp.Children.Add( txt );
            sp.Children.Add( btn );
            Content = sp;
         }
      }

      [STAThread]
      static void Main( string[] args )
      {
         Application app = new Application();
         MyWindow win    = new MyWindow();

         app.Run( win );
      }
   }
}
