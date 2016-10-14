using System;
using System.Windows;
using System.Media;

namespace SimpleSystemSounds
{
   public partial class Window1 : Window
   {
      public Window1() { InitializeComponent(); }

      private void Button_Click( object sender, RoutedEventArgs e )
      {
         SystemSounds.Asterisk.Play();
      }
   }
}
