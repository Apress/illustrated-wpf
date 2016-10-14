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

namespace Nested
{
   /// <summary>
   /// Interaction logic for Window1.xaml
   /// </summary>
   public partial class Window1 : Window
   {
      public Window1()
      {
         InitializeComponent();
      }

      private void cat_MouseUp( object sender, MouseButtonEventArgs e )
      {
         tb.Text += "Image sees it.\r\n";
      }

      private void myLabel_MouseUp( object sender, MouseButtonEventArgs e )
      {
         tb.Text += "Label sees it.\r\n";
      }

      private void myBorder_MouseUp( object sender, MouseButtonEventArgs e )
      {
         tb.Text += "Border sees it.\r\n";
      }

      private void Clear_Click( object sender, RoutedEventArgs e )
      {
         tb.Text = "";
      }
   }
}
