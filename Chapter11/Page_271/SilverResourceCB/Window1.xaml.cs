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

namespace SilverResourceCB
{
   /// <summary>
   /// Interaction logic for Window1.xaml
   /// </summary>
   public partial class Window1 : Window
   {
      public Window1()
      {
         InitializeComponent();

         sp.Resources.Add( "background", Brushes.Silver );

         // Option 1:  Using TryFindResource
         btn1.Background = (Brush) btn1.TryFindResource( "background" );
         if ( btn1.Background == null )
            btn1.Background = Brushes.AliceBlue;

         //// Option 2:  Accessing the StackPanel Resources property directly
         //btn1.Background = (Brush) sp.Resources["background"];
      }
   }
}
