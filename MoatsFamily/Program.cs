using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoatsFamily
{
    class Program
    {
        static void Main(string[] args)
        {
            int familySize = 0;

            Console.WriteLine("Please enter the size of your family.");
            familySize = Int32.Parse(Console.ReadLine());
            Person[] moatsFamily = new Person[familySize];

            for (int i = 0; i < familySize; i++)
            {
                string name;
                string hobby;
                int age;
                string testRole;
                Person.Role role = Person.Role.son;

                Console.WriteLine("Please enter family member {0}'s name", i + 1);
                name = Console.ReadLine();
                Console.WriteLine("Please enter family member {0}'s hobby", i + 1);
                hobby = Console.ReadLine();
                Console.WriteLine("Please enter family member {0}'s age", i + 1);
                age = (Int32.Parse(Console.ReadLine()));
                Console.WriteLine("Please enter family member {0}'s role (ex. father, mother, son, daughter)", i + 1);
                testRole = Console.ReadLine();
                try
                    {
                         role = (Person.Role)Enum.Parse(typeof(Person.Role), testRole);   
                    }
                catch(ArgumentException e)
                {
                    Console.WriteLine("You did not not enter a valid family role: \n\n{0}", e);
                    Console.WriteLine("\n\nPlease copy and paste this code into an email to woops@.woops so we can fix it" +
                       "in the future.\n\n");
                }

                moatsFamily[i] = new Person(name, hobby, age, role);
             }

            Person.DisplayFamily(moatsFamily);
            Console.ReadLine();
         }
        }
    }
