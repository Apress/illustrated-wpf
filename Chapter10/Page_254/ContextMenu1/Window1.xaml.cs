using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace ContextMenu1
{
   /// <summary>
   /// Interaction logic for Window1.xaml
   /// </summary>
   public partial class Window1 : Window
   {
      public Window1()
      {
         InitializeComponent();
      }

      private void FlipVertical_Click( object sender, RoutedEventArgs e )
      {
         picture.LayoutTransform = new ScaleTransform( -1, 1 );
      }

      private void FlipHorizontal_Click( object sender, RoutedEventArgs e )
      {
         picture.LayoutTransform = new ScaleTransform( 1, -1 );
      }

      private void Original_Click( object sender, RoutedEventArgs e )
      {
         picture.LayoutTransform = new ScaleTransform( 1, 1 );
      }
   }
}
