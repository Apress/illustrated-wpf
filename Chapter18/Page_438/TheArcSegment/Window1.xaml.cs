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

namespace TheArcSegment
{
   /// <summary>
   /// Interaction logic for Window1.xaml
   /// </summary>
   public partial class Window1 : Window
   {
      public Window1()
      {
         InitializeComponent();

         string startPoint = string.Format("StartPoint: {0}, {1}",
                              pfStartPoint.StartPoint.X, pfStartPoint.StartPoint.Y);
         lblStartPoint.Content = new TextBlock( new Run( startPoint ) );

         string point = string.Format( "Point: {0}, {1}", arc.Point.X, arc.Point.Y );
         lblPoint.Content = new TextBlock( new Run( point ) );

         string size = string.Format( "Size: {0}, {1}", arc.Size.Width, arc.Size.Height );
         lblSize.Content = new TextBlock( new Run( size ) );

         string largeArc = string.Format( "IsLargeArc: {0}", arc.IsLargeArc.ToString() );
         lblIsLargeArc.Content = new TextBlock( new Run( largeArc ) );

         string sweepdirection = string.Format( "SweepDirection: {0}", arc.SweepDirection.ToString() );
         lblSweepDirection.Content = new TextBlock( new Run( sweepdirection ) );
      }
   }
}
