using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TreeBound
{
   class WorldRegion
   {
      public string RegionName { get; set; }
      public List<MapInfo> Maps { get; set; }

      public WorldRegion( string name )
      {
         Maps = new List<MapInfo>();
         RegionName = name;
      }
   }

   class MapInfo
   {
      public string LastName { get; set; }
      public string FirstName { get; set; }
      public string Title { get; set; }
      public string Year { get; set; }
      public string Description { get; set; }
      public Uri Picture { get; set; }

      public MapInfo( string ln, string fn, string title, string year,
                     string desc, string pictUri )
      {
         LastName = ln;
         FirstName = fn;
         Title = title;
         Year = year;
         Description = desc;

         string uriString = string.Format( "Images/{0}", pictUri );
         Picture = new Uri( uriString, UriKind.Relative );
      }
   }
}
