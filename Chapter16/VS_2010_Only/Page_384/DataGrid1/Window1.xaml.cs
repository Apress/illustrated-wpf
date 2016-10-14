using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;

namespace DataGrid1
{
   class Person
   {
      public string FirstName   { get; set; }
      public string LastName    { get; set; }
      public int    Age         { get; set; }
      public bool   HasRoadster { get; set; }

      public Person(string fName, string lName, int age, bool hasRoadster)
      {
         FirstName   = fName;
         LastName    = lName;
         Age         = age;
         HasRoadster = hasRoadster;
      }
   }

   public partial class Window1 : Window
   {
      List<Person> _people = new List<Person>();

      public Window1()
      {  InitializeComponent();

         _people.Add(new Person("Sherlock", "Holmes", 54, false));
         _people.Add(new Person("Jane", "Marple", 60, false));
         _people.Add(new Person("Nancy", "Drew", 16, true));
         _people.Add(new Person("Charlie", "Chan", 50, false));

         dg.ItemsSource = _people;
      }
   }
}
