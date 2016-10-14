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

namespace Image2
{
   /// <summary>
   /// Interaction logic for Window1.xaml
   /// </summary>
   public partial class Window1 : Window
   {
      public Window1()
      {
         InitializeComponent();

         Uri uri = new Uri( "Pictures/SweetieSleeping.jpg", UriKind.Relative);
         BitmapImage bitmap = new BitmapImage( uri );
         Image image = new Image();
         image.Source = bitmap;

         Grid grid = new Grid();

         grid.Children.Add( image );
         Grid.SetRow( image, 0 );
         Grid.SetColumn( image, 0 );

         Content = grid;
      }
   }
}
