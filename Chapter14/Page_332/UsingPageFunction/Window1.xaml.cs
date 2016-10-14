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

namespace UsingPageFunction
{
   /// <summary>
   /// Interaction logic for Window1.xaml
   /// </summary>
   public partial class Window1 : Page
   {
      public Window1() { InitializeComponent(); }

      private void Button_Click( object sender, RoutedEventArgs e )
      {
         UserInputPageFunction uiPageFunction = new UserInputPageFunction();
         uiPageFunction.Return += handlePageFunctionInput;
         this.NavigationService.Navigate( uiPageFunction );
      }

      private void handlePageFunctionInput( object sender, ReturnEventArgs<string> e )
      {
         string stringReturned = (string) e.Result;
         if ( stringReturned != null )
            textBox.Text = stringReturned;
      }
   }
}
