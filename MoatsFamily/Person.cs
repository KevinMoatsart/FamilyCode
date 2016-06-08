using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoatsFamily
{
    class Person
    {

        //enums
        public enum Role
        {
            father,
            mother,
            son,
            daughter
        }


        //data values
        public string Name { get; set; }
        public string Hobby { get; set; }
        public int Age { get; set; }
        public Role FamilyRole { get; set; }

        //constructors
        public Person() { }
        public Person(string name, string hobby, int age, Role familyRole)
        {
            Name = name;
            Hobby = hobby;
            Age = age;
            FamilyRole = familyRole;
        }

        //methods
        public static void DisplayFamily(Person[] family)
        {
            foreach (Person person in family)
            {
                Console.WriteLine("{0} is {1}, their hobby is {2} and they are a {3} in the family.", person.Name, person.Age, person.Hobby, person.FamilyRole);
            }
        }

    }
}
