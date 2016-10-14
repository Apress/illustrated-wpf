using System;
using System.Windows.Input;    // Required

namespace CommandReverse
{
   public class ReverseCommand
   {
      private static RoutedUICommand reverse;

      public static RoutedUICommand Reverse
      {
         get { return reverse; }
      }

      static ReverseCommand()
      {
         InputGestureCollection gestures = new InputGestureCollection();
         gestures.Add( new KeyGesture(Key.R, ModifierKeys.Control, "Control-R"));

         reverse = new RoutedUICommand
            ( "Reverse", "Reverse", typeof(ReverseCommand), gestures);
      }
   }
}
