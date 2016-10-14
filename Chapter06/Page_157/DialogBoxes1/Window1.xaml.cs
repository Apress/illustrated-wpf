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

namespace DialogBoxes1
{
   /// <summary>
   /// Interaction logic for Window1.xaml
   /// </summary>
   public partial class Window1 : Window
   {
      public Window1() { InitializeComponent(); }

      private void Button_Click( object sender, RoutedEventArgs e )
      {
         MyDialog dlg = new MyDialog();    // Create the Window object.
         bool? result = dlg.ShowDialog();  // Display it as a modal window.
      }
   }
}
