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

namespace SimpleEvents
{
   /// <summary>
   /// Interaction logic for Window1.xaml
   /// </summary>
   public partial class Window1 : Window
   {
      public Window1() { InitializeComponent(); }

      private void myButton_Click( object sender, RoutedEventArgs e )
      {
         string c = myButton.Content.ToString();
         myButton.Content = (c == "Clicked" || c == "Clicked Again")
            ? "Clicked Again"
            : "Clicked";
      }

      private void myButton_MouseEnter( object sender, MouseEventArgs e )
      {
         myButton.Content = "Mouse Over";
      }

      private void myButton_MouseLeave( object sender, MouseEventArgs e )
      {
         myButton.Content = "Click Me";
      }
   }
}
