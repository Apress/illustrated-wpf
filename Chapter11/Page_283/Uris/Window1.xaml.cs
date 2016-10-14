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

namespace Uris
{
   /// <summary>
   /// Interaction logic for Window1.xaml
   /// </summary>
   public partial class Window1 : Window
   {
      public Window1()
      {
         InitializeComponent();

         Uri uri1 = new Uri( "/Balloons.jpg", UriKind.Relative );

         ///////////////////////////////////////////////////////////////////////////////
         //
         // !! IMPORTANT !!
         //
         // You must set the string in the following constructor to specify the location
         // of the DogInSnow.jpg file on your computer.
         //
         ///////////////////////////////////////////////////////////////////////////////
         Uri uri2 = new Uri( "C:/Pictures/DogInSnow.jpg" );

         BitmapImage bi1 = new BitmapImage( uri1 );
         Image balloons = new Image();
         balloons.Source = bi1;

         BitmapImage bi2 = new BitmapImage( uri2 );
         Image dogInSnow = new Image();
         dogInSnow.Source = bi2;

         sp.Children.Add( balloons );
         sp.Children.Add( dogInSnow );
      }
   }
}
