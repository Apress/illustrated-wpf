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

namespace MenuCommands
{
   /// <summary>
   /// Interaction logic for Window1.xaml
   /// </summary>
   public partial class Window1 : Window
   {
      public Window1()
      {
         InitializeComponent();

         // Create the binding for the New command.
         CommandBinding nBinding = new CommandBinding();
         nBinding.Command = ApplicationCommands.New;
         nBinding.Executed += DoNew_Executed;
         nBinding.CanExecute += DoNew_CanExecute;

         // Create the binding for the Open command.
         CommandBinding oBinding = new CommandBinding();
         oBinding.Command = ApplicationCommands.Open;
         oBinding.Executed += DoOpen_Executed;
         oBinding.CanExecute += DoOpen_CanExecute;

         CommandBindings.Add( nBinding );
         CommandBindings.Add( oBinding );
      }

      public void DoNew_Executed( object sender, ExecutedRoutedEventArgs e )
      {
         MessageBox.Show( "New Command Executed", "Command Info" );
      }

      public void DoNew_CanExecute( object sender, CanExecuteRoutedEventArgs e )
      {
         e.CanExecute = true;
      }

      public void DoOpen_Executed( object sender, ExecutedRoutedEventArgs e )
      {
         MessageBox.Show( "Open Command Executed", "Command Info" );
      }

      public void DoOpen_CanExecute( object sender, CanExecuteRoutedEventArgs e )
      {
         e.CanExecute = true;
      }
   }
}
