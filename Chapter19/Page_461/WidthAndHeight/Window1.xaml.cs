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

namespace WidthAndHeight
{
   /// <summary>
   /// Interaction logic for Window1.xaml
   /// </summary>
   public partial class Window1 : Window
   {
      public Window1()
      {  InitializeComponent();

         DoubleAnimation animateSize = new DoubleAnimation();
         animateSize.From = 50.0;
         animateSize.To = 80.0;

         myButton.BeginAnimation( HeightProperty, animateSize );
         myButton.BeginAnimation( WidthProperty, animateSize );
      }
   }
}
