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

namespace DrawingBrushVideo
{
   /// <summary>
   /// Interaction logic for Window1.xaml
   /// </summary>
   public partial class Window1 : Window
   {
      public Window1()
      {
         InitializeComponent();

         MediaPlayer player = new MediaPlayer();
         player.Open( new Uri( "cat.wmv", UriKind.Relative ) );

         VideoDrawing videoDrawing = new VideoDrawing();
         videoDrawing.Rect = new Rect( 0, 0, 50, 50 );
         videoDrawing.Player = player;

         lakeBrush.Drawing = videoDrawing;
         player.Play();
      }
   }
}
