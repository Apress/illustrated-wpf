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

namespace UrisDogInSnow
{
   /// <summary>
   /// Interaction logic for Window1.xaml
   /// </summary>
   public partial class Window1 : Window
   {
      public Window1()
      {
         InitializeComponent();

         Uri uri = new Uri( "pack://application:,,,/DogInSnow.jpg" );

         BitmapImage bi = new BitmapImage( uri );
         Image dogInSnow = new Image();
         dogInSnow.Source = bi;

         sp.Children.Add( dogInSnow );
      }
   }
}
