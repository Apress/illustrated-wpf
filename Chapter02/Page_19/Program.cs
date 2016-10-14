using System;
using System.Windows;

namespace MySimpleProgramConsole
{
   class Program
   {
      [STAThread]
      static void Main( string[] args )
      {
         Window myWin  = new Window();               // Create the Window object.
         myWin.Title   = "My Simple Window";         // Set the title.
         myWin.Content = "Hi there!";                // Set the window content.

         Application myApp = new Application();      // Create an Application object.

         myApp.Run( myWin );                         // Start application running.
      }
   }
}
