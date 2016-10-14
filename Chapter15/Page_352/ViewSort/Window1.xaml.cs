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
         cv.SortDescriptions.Clear();
      }

      private void SortByName_Click( object sender, RoutedEventArgs e )
      {
         cv.SortDescriptions.Clear();

         SortDescription sd = 
            new SortDescription( "FirstName", ListSortDirection.Ascending );
         cv.SortDescriptions.Add( sd );
      }

      private void SortByAge_Click( object sender, RoutedEventArgs e )
      {
         cv.SortDescriptions.Clear();

         SortDescription sd =
            new SortDescription( "Age", ListSortDirection.Ascending );
         cv.SortDescriptions.Add( sd );
      }

      private void SortBySexAndAge_Click( object sender, RoutedEventArgs e )
      {
         cv.SortDescriptions.Clear();

         SortDescription sd1 = new SortDescription( "Sex", ListSortDirection.Ascending );
         SortDescription sd2 = new SortDescription( "Age", ListSortDirection.Ascending );
         cv.SortDescriptions.Add( sd1 );
         cv.SortDescriptions.Add( sd2 );
      }
   }
}
