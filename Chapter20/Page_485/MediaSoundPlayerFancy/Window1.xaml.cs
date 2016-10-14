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

namespace MediaSoundPlayerFancy
{
   /// <summary>
   /// Interaction logic for Window1.xaml
   /// </summary>
   public partial class Window1 : Window
   {
      MediaPlayer player;

      public Window1()
      {
         InitializeComponent();

         player = new MediaPlayer();

         // Music clip is the beginning of "A Short Walk" by composer Taylor Hayward at taylorhayward.com.
         player.Open( new Uri( "AShortWalk.wma", UriKind.Relative ) );

         radioCenter.IsChecked = true;
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

      private void radioButton_Checked( object sender, RoutedEventArgs e )
      {
         if ( radioLeft.IsChecked.Value )
            player.Balance = -1.0;
         else if ( radioRight.IsChecked.Value )
            player.Balance = 1.0;
         else
            player.Balance = 0;
      }
   }
}
