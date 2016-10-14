using System;
using System.Windows;
using System.Windows.Controls;

namespace DrawShape
{
   public partial class Window1 : Window
   {
      public static readonly DependencyProperty SidesProperty;

      public int Sides
      {
         get { return (int) GetValue( SidesProperty ); }
         set { SetValue( SidesProperty, value ); }
      }

      static Window1()
      {
         FrameworkPropertyMetadata md = new FrameworkPropertyMetadata();
         md.PropertyChangedCallback = OnSidesChanged;
         SidesProperty = DependencyProperty.Register(
                              "Sides",
                              typeof(int),
                              typeof(Window1),
                              md );
      }

      private void input_TextChanged( object sender, TextChangedEventArgs e )
      {
         int sideCount;
         bool success = int.TryParse( input.Text, out sideCount );
         if( success && sideCount > 2 )
            Sides = sideCount;
      }

      static void OnSidesChanged( DependencyObject obj,
                           DependencyPropertyChangedEventArgs args)
      {
         Window1 win = obj as Window1;
         if ( win == null || win.poly == null ) return;

         const int xCenter = 65;
         const int yCenter = 50;
         const int radius  = 40;

         double rads = Math.PI / win.Sides * 2;

         win.poly.Points.Clear();
         win.poly.Points.Add( new Point( xCenter + radius, yCenter ) );
         for ( double i=1; i <= win.Sides - 1; i++ )
         {
            double x = ( Math.Cos( rads * i ) * radius ) + xCenter;
            double y = ( Math.Sin( rads * i ) * radius ) + yCenter;
            win.poly.Points.Add( new Point( x, y ) );
         }
      }

      public Window1() { InitializeComponent(); }
   }
}
