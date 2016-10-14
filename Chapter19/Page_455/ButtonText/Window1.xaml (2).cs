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
namespace ButtonText
{
   /// <summary>
   /// Interaction logic for Window1.xaml
   /// </summary>
   public partial class Window1 : Window
   {
      public Window1()
      {
         InitializeComponent();

         DoubleAnimation animateFontSize = new DoubleAnimation();
         animateFontSize.From = 12.0;
         animateFontSize.To   = 22.0;
         animateFontSize.Duration = TimeSpan.Parse( "0:0:5" );
         animateFontSize.By = 5.0;

         //animateFontSize.AutoReverse = true;
         //animateFontSize.RepeatBehavior = RepeatBehavior.Forever;
         myButton.BeginAnimation( FontSizeProperty, animateFontSize );

         //DoubleAnimation animateOpacity = new DoubleAnimation();
         //animateOpacity.From = 0.0;
         //animateOpacity.To = 1.0;
         //animateOpacity.BeginTime = TimeSpan.Parse( "0:0:0.5" );
         //animateOpacity.AutoReverse = true;
         //animateOpacity.Duration = TimeSpan.Parse( "0:0:10" );
         //myButton.BeginAnimation( OpacityProperty, animateOpacity );

      }
   }
}
