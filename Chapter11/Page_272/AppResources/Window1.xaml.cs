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

namespace AppResources
{
   /// <summary>
   /// Interaction logic for Window1.xaml
   /// </summary>
   public partial class Window1 : Window
   {
      public Window1()
      {
         InitializeComponent();

         SolidColorBrush silverBrush = Brushes.Silver;

         App application = (App) Application.Current;
         application.Resources.Add( "background", silverBrush );

         btn1.Background = (SolidColorBrush) btn1.FindResource( "background" );
      }
   }
}
