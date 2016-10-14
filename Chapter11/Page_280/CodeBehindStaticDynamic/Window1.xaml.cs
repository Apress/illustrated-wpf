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

namespace CodeBehindStaticDynamic
{
   /// <summary>
   /// Interaction logic for Window1.xaml
   /// </summary>
   public partial class Window1 : Window
   {
      public Window1()
      {
         InitializeComponent();

         sp.Resources.Add( "background", Brushes.Aqua );

         btn2.Background = (Brush) sp.Resources["background"];
         btn3.Background = (Brush) btn3.FindResource( "background" );
         btn4.SetResourceReference( BackgroundProperty, "background" );
      }
   }
}
