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

namespace ChildWindows
{
   /// <summary>
   /// Interaction logic for Window1.xaml
   /// </summary>
   public partial class Window1 : Window
   {
      public Window1() { InitializeComponent(); }

      private void Button_Click( object sender, RoutedEventArgs e )
      {
         Window w1 = new Window();
         w1.Background = Brushes.AliceBlue;
         w1.Title = "Win 1"; w1.Height = 120; w1.Width = 170;
         w1.Content = "Independent Window";
         w1.Show();

         Window w2 = new Window();
         w2.Background = Brushes.PaleVioletRed;
         w2.Title = "Win 2"; w2.Height = 120; w2.Width = 170;
         w2.Content = "Child Window";
         w2.Owner = this;
         w2.Show();
      }
   }
}
