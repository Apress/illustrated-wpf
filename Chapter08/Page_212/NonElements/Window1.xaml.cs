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

namespace NonElements
{
   /// <summary>
   /// Interaction logic for Window1.xaml
   /// </summary>
   public partial class Window1 : Window
   {
      public Window1()
      {
         InitializeComponent();

         Person p = new Person( "Shirley", 34, "Green" );

         Binding nameBinding = new Binding( "FirstName" );
         nameBinding.Source  = p;
         lblFName.SetBinding( ContentProperty, nameBinding );

         Binding ageBinding = new Binding( "Age" );
         ageBinding.Source  = p;
         lblBMonth.SetBinding( ContentProperty, ageBinding );

         Binding colorBinding = new Binding( "FavoriteColor" );
         colorBinding.Source = p;
         lblColor.SetBinding( ContentProperty, colorBinding );
      }
   }
}
