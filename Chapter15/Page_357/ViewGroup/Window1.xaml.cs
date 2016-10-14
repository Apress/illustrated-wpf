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

         Person[] people = {
                             new Person( "Shirley", 34, "Red",    "F"),
                             new Person( "Roy",     36, "Blue",   "M"),
                             new Person( "Frank",   25, "Yellow", "M"),
                             new Person( "Manuel",  21, "Red",    "M"),
                             new Person( "Amy",     29, "Blue",   "F"),
                             new Person( "Roy",     42, "Yellow", "M"),
                             new Person( "Isabel",  30, "Red",    "F"),
                             new Person( "Sam",     27, "Blue",   "M"),
                             new Person( "Tom",     19, "Yellow", "M")
                           };

         listPeople.ItemsSource = people;
         cv = (CollectionView)
                   CollectionViewSource.GetDefaultView( listPeople.ItemsSource );

         PropertyGroupDescription pgd = new PropertyGroupDescription( "Sex" );
         cv.GroupDescriptions.Add( pgd );
         pgd = new PropertyGroupDescription( "FavoriteColor" );
         cv.GroupDescriptions.Add( pgd );
      }
   }
}
