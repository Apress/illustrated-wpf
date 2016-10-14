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

namespace PersonList
{
   /// <summary>
   /// Interaction logic for Window1.xaml
   /// </summary>
   public partial class Window1 : Window
   {
      public Window1()
      {
         InitializeComponent();

         Person[] people = { new Person( "Shirley", 34, "Green"),
                             new Person(  "Roy", 36, "Blue"),
                             new Person(  "Isabel", 25, "Orange"),
                             new Person(  "Manuel", 27, "Red")};

         comboPeople.ItemsSource = people;

         Binding nameBinding = new Binding( "FirstName" );
         lblFName.SetBinding( ContentProperty, nameBinding );

         Binding ageBinding = new Binding( "Age" );
         lblAge.SetBinding( ContentProperty, ageBinding );

         Binding colorBinding = new Binding( "FavoriteColor" );
         lblColor.SetBinding( ContentProperty, colorBinding );
      }
   }
}
