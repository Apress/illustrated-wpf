using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PersonList
{
   class Person
   {
      public string FirstName { get; set; }
      public int Age { get; set; }
      public string FavoriteColor { get; set; }
      public string Sex{ get; set; }

      public Person( string fName, int age, string color, string sex )
      {
         FirstName     = fName;
         Age           = age;
         FavoriteColor = color;
         Sex = sex;
      }
   }
}
