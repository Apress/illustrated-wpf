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

namespace ToolBars1
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

      private void MenuItem_Click_NewGame( object sender, RoutedEventArgs e )
      {
         MessageBox.Show( "Clicked New Game", "Menu Info" );
      }

      private void MenuItem_Click_ChangeOpponent( object sender, RoutedEventArgs e )
      {
         MessageBox.Show( "Clicked Change Opponent", "Menu Info" );
      }

      private void Button_Click_Bet( object sender, RoutedEventArgs e )
      {
         MessageBox.Show( "Clicked Bet Button", "Menu Info" );
      }

      private void Button_Click_Fold( object sender, RoutedEventArgs e )
      {
         MessageBox.Show( "Clicked Fold Button", "Menu Info" );
      }
   }
}
