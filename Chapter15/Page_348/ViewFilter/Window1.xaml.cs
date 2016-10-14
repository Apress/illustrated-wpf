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
using System.ComponentModel;  // Need this.

namespace PersonList
{
   public partial class Window1 : Window
   {
      CollectionView cv;       // Store the view.

      public Window1()
      {
         InitializeComponent();

         Person[] people = { new Person( "Shirley", 34, "Aquamarine", "F"),
                             new Person( "Roy",     36, "GoldenRod",  "M"),
                             new Person( "Isabel",  25, "DarkGray",   "F"),
                             new Person( "Manuel",  27, "Red",        "M"),
                             new Person( "Roy",     19, "Blue",       "M")
                           };

         listPeople.ItemsSource = people;
         cv = (CollectionView)
                   CollectionViewSource.GetDefaultView( listPeople.ItemsSource );
      }

      private void Default_Click( object sender, RoutedEventArgs e )
      {
         cv.Filter = null;
      }

      private void AgeLessThanThirty_Click( object sender, RoutedEventArgs e )
      {
         cv.Filter = IsLessThan30;
      }

      private void AgeGreaterThanThirty_Click( object sender, RoutedEventArgs e )
      {
         cv.Filter = IsGreaterThan30;
      }

      private bool IsLessThan30( object obj )
      {
         return (obj as Person).Age < 30;
      }

      private bool IsGreaterThan30( object obj )
      {
         return (obj as Person).Age >= 30;
      }
   }
}
