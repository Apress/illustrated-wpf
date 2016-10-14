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
using System.Windows.Media.Animation;

namespace Storyboard1
{
   /// <summary>
   /// Interaction logic for Window1.xaml
   /// </summary>
   public partial class Window1 : Window
   {
      public Window1()
      {  InitializeComponent();

         DoubleAnimation animateFontSize = new DoubleAnimation();
         animateFontSize.From = 12.0;
         animateFontSize.To   = 22.0;
         animateFontSize.Duration = TimeSpan.Parse( "0:0:2" );

         DoubleAnimation animateHeight = new DoubleAnimation();
         animateHeight.From = 40.0;
         animateHeight.To   = 80.0;
         animateHeight.Duration = TimeSpan.Parse( "0:0:2" );

         Storyboard sb = new Storyboard();
         sb.Duration = TimeSpan.Parse( "0:0:3" );
         
         sb.Children.Add( animateFontSize );
         sb.Children.Add( animateHeight );

         Storyboard.SetTargetName( animateFontSize, "myButton" );
         Storyboard.SetTargetProperty( animateFontSize,
                       new PropertyPath(Button.FontSizeProperty));

         Storyboard.SetTargetName( animateHeight, "myButton" );
         Storyboard.SetTargetProperty( animateHeight,
                       new PropertyPath( Button.HeightProperty ) );

         sb.Begin( myButton );
      }
   }
}
