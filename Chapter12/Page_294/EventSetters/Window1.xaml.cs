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

namespace EventSetters
{
   public partial class Window1 : Window
   {
      public Window1()
      {
         InitializeComponent(); 
      }

      private void ChangeValue_OnEnter( object sender, RoutedEventArgs e )
      {
         Button btn = (Button) sender;
         int value;

         if ( int.TryParse( (string) btn.Content, out value ) )
         {
            value++;
            btn.Content = value.ToString();
         }
      }
   }
}
