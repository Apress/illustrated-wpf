using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PersonListStage1
{
   class Person
   {
      public string FirstName { get; set; }
      public int Age { get; set; }
      public string FavoriteColor { get; set; }

      public Person( string fName, int age, string color )
      {
         FirstName = fName;
         Age = age;
         FavoriteColor = color;
      }
   }
}
