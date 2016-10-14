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

namespace CustomConstructor
{
   /// <summary>
   /// Interaction logic for Window1.xaml
   /// </summary>
   public partial class Window1 : Page
   {
      public Window1() { InitializeComponent(); }

      private void Button_Click( object sender, RoutedEventArgs e )
      {
         Page1 p1 = new Page1( "This too shall pass." );

         NavigationService ns = NavigationService.GetNavigationService( this );
         ns.Navigate( p1 );
      }
   }
}
