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

namespace TreeBound
{
   /// <summary>
   /// Interaction logic for Window1.xaml
   /// </summary>
   public partial class Window1 : Window
   {
      List<WorldRegion> mapRegions;

      public Window1()
      {
         InitializeComponent();

         mapRegions = new List<WorldRegion>();
         CreateMapsDataStructure();
         oldMaps.ItemsSource = mapRegions;
      }

      private void CreateMapsDataStructure()
      {
         WorldRegion region = new WorldRegion( "Double Hemisphere" );
         region.Maps.Add( new MapInfo( "Seutter", "Mattheus",
               "Diversi Globi Terr-Aquei",
               "c. 1730", "Double hemisphere", "Seutter.jpg" ) );
         region.Maps.Add( new MapInfo( "Stoopendahl", "Daniel", "Orbis Terrarum",
               "c. 1680", "Double hemisphere", "Stoopendahl.jpg" ) );
         region.Maps.Add( new MapInfo( "Valck", "Gerard", "Mappe Monde",
               "c. 1700", "Double Hemisphere", "Valck.jpg" ) );
         mapRegions.Add( region );

         region = new WorldRegion( "Western Hemisphere" );
         region.Maps.Add( new MapInfo( "Sanson", "Nicholas",
               "California as an Island",
               "c. 1657", "Calif. as an island", "Sanson.jpg" ) );
         mapRegions.Add( region );

         region = new WorldRegion( "Eastern Hemisphere" );
         region.Maps.Add( new MapInfo( "Bowen", "Emanuel", "Spain and Portugal",
               "c. 1752", "Spain and Portugal", "Stoopendahl.jpg" ) );
         region.Maps.Add( new MapInfo( "Janvier", "Jean",
               "Les Isles Britanniques",
               "c. 1762", "The British Isles", "Janvier.jpg" ) );
         region.Maps.Add( new MapInfo( "Mortier", "Pierre",
               "Les Isles Britanniques",
               "c. 1738", "The British Isles", "Stoopendahl.jpg" ) );
         mapRegions.Add( region );
      }

      private void oldMaps_SelectedItemChanged( object sender,
                           RoutedPropertyChangedEventArgs<object> e )
      {
         MapInfo map = oldMaps.SelectedItem as MapInfo;
         if ( map == null )
            return;

         name.Text  = map.LastName + ", " + map.FirstName;
         title.Text = map.Title;
         date.Text  = map.Year;
         desc.Text  = map.Description;
      }
   }
}
