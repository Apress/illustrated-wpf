using System;
using System.Windows.Markup;

namespace MarkupExtensions
{
   class ShowTime: MarkupExtension
   {
      private string header = string.Empty;

      public string Header
      {
         get { return header; }
         set { header = value; }
      }

      public ShowTime()
      {
      }

      public ShowTime( string input)
      {
         header = input;
      }

      public override object ProvideValue( IServiceProvider serviceProvider )
      {
         return string.Format( "{0}:  {1}",
                  header, DateTime.Now.ToLongTimeString() );
      }
   }
}
