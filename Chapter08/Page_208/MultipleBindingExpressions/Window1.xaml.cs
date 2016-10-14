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

namespace MultipleBindingExpressions
{
   /// <summary>
   /// Interaction logic for Window1.xaml
   /// </summary>
   public partial class Window1 : Window
   {
      public Window1()
      {
         InitializeComponent();

         Binding bindingShared = new Binding();
         bindingShared.Source = sourceInfo;
         bindingShared.Path = new PropertyPath( "Text" );

         displayText.SetBinding( Label.ContentProperty, bindingShared );
         displayText.SetBinding( Label.FontSizeProperty, bindingShared );
      }
   }
}
