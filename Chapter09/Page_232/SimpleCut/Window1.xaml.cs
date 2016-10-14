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

namespace SimpleCut
{
   /// <summary>
   /// Interaction logic for Window1.xaml
   /// </summary>
   public partial class Window1 : Window
   {
      public Window1() { InitializeComponent(); }

      private void Button_Click( object sender, RoutedEventArgs e )
      {
         if ( txtBox.SelectedText.Length <= 0 )
            return;

         Clipboard.SetData( DataFormats.Text, (object) txtBox.SelectedText );

         string pre  = txtBox.Text.Substring( 0, txtBox.SelectionStart );
         string post = txtBox.Text.Substring( txtBox.SelectionStart + txtBox.SelectionLength );

         txtBox.Text = txtBox.Text = pre + post;
      }
   }
}
