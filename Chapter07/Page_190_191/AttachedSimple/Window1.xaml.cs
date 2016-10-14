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

namespace AttachedSimple
{
   /// <summary>
   /// Interaction logic for Window1.xaml
   /// </summary>
   public partial class Window1 : Window
   {
      public static readonly DependencyProperty CountProperty;

      static Window1()    // Static Constructor
      {
         CountProperty = DependencyProperty.RegisterAttached(
                              "Count", typeof( int ), typeof( Window1 ) );
      }

      public static int GetCount( IntStorage ints )
      {
         return (int) ints.GetValue( CountProperty );
      }

      public static void SetCount( IntStorage ints, int value )
      {
         ints.SetValue( CountProperty, value );
      }

      public Window1()    // Instance Constructor
      {
         InitializeComponent();

         IntStorage is1 = new IntStorage();  // Create Targets.
         IntStorage is2 = new IntStorage();

         SetCount( is1, 28 );                // Store Values.
         SetCount( is2, 500 );

         int i1 = GetCount( is1 );           // Retrieve the values.
         int i2 = GetCount( is2 );

         txt1.Text = i1.ToString();          // Display the values.
         txt2.Text = i2.ToString();
      }
   }
}
