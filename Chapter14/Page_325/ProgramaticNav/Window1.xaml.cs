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

namespace ProgramaticNav
{
   /// <summary>
   /// Interaction logic for Window1.xaml
   /// </summary>
   public partial class Window1 : Page
   {
      public Window1() { InitializeComponent(); }

      private void Button_Click( object sender, RoutedEventArgs e )
      {
         NavigationService navService = NavigationService.GetNavigationService(this);
         string selString = ((ListBoxItem) lbxSelection.SelectedItem).Content.ToString();
         if ( selString == "Portrait" )
         {
            PagePortrait pp = new PagePortrait();
            navService.Navigate( pp );
         }
         else
         {
            PageLandscape pl = new PageLandscape();
            navService.Navigate( pl );
         } 
      }
   }
}
