using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace MediaElementHandlers
{
   /// <summary>
   /// Interaction logic for Window1.xaml
   /// </summary>
   public partial class Window1 : Window
   {
      public Window1()
      {
         InitializeComponent();

         // Music clip is the beginning of "A Short Walk" by composer Taylor Hayward at taylorhayward.com.
         player.Source = new Uri( "ashortwalk.wma", UriKind.Relative );
      }

      private void Play_Click( object sender, RoutedEventArgs e )
      {
         player.Play(); 
      }

      private void Pause_Click( object sender, RoutedEventArgs e )
      {
         player.Pause();
      }

      private void Stop_Click( object sender, RoutedEventArgs e )
      { 
         player.Stop();
      }
   }
}
