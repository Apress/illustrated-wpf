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

namespace SimpleVideo
{
   /// <summary>
   /// Interaction logic for Window1.xaml
   /// </summary>
   public partial class Window1 : Window
   {
      public Window1()
      {  InitializeComponent();

         // To show the first frame.
         videoElement.Play();
         videoElement.Pause();
         videoElement.Position = TimeSpan.Zero;
      }

      private void Stop_Click( object sender, RoutedEventArgs e )
      {
         videoElement.Stop();
      }

      private void Play_Click( object sender, RoutedEventArgs e )
      {
         videoElement.Play();
      }

      private void Pause_Click( object sender, RoutedEventArgs e )
      {
         videoElement.Pause();
      }
   }
}
