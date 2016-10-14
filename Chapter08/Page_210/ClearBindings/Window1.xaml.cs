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

namespace ClearBindings
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

      private void ClearFont_Click( object sender, RoutedEventArgs e )
      {
         BindingOperations.ClearBinding( DisplayText, FontFamilyProperty );
      }

      private void ClearAll_Click( object sender, RoutedEventArgs e )
      {
         BindingOperations.ClearAllBindings( DisplayText );
      }

      private void CreateBindings_Click( object sender, RoutedEventArgs e )
      {
         Binding fontBinding = new Binding();
         fontBinding.Source = fontBox;
         fontBinding.Path = new PropertyPath( "Text" );
         fontBinding.Mode = BindingMode.OneWay;
         DisplayText.SetBinding( FontFamilyProperty, fontBinding );

         Binding weightBinding = new Binding();
         weightBinding.Source = weightBox;
         weightBinding.Path = new PropertyPath( "Text" );
         weightBinding.Mode = BindingMode.OneWay;
         DisplayText.SetBinding( FontWeightProperty, weightBinding );
      }
   }
}
