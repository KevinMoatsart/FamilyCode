//Author: Kevin Moats
//Program Name: MoatsFamily
//Last Updated: 6/8/2016
//Purpose: To enter data and display in a uniform sentence, and display abilities of software development.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoatsFamily
{
    abstract class Person
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
        protected Person(string name, string hobby, int age, Role familyRole)
        {
            Name = name;
            Hobby = hobby;
            Age = age;
            FamilyRole = familyRole;
            AssignTrait();
        }

        //methods
        public static void DisplayFamily(Person[] family)
        {
            foreach (Person person in family)
            {
                Console.WriteLine("\n\n{0} is {1}, their hobby is {2} and they are a {3} in the family.", person.Name, person.Age, person.Hobby, person.FamilyRole);
            }
        }

        public virtual void DisplayInfo()
        {
            Console.WriteLine("Name: {0}, Hobby: {1}, Age: {2}, Role: {3} ", Name, Hobby, Age, FamilyRole );
        }

        public virtual void AssignTrait()
        {
            Console.WriteLine("Say hello to an unreachable statement.");
        }

        static public void AssignRole(string role, out Role toReturn)
        {

            while(true)
            {
                try
                {
                    toReturn = (Person.Role)Enum.Parse(typeof(Person.Role), role);
                    break;
                }
                catch (ArgumentException e)
                {
                    Console.WriteLine("You did not not enter a valid family role: \n\n{0}", e);
                    Console.WriteLine("\n\nPlease copy and paste this code into an email to woops@.woops so we can fix it" +
                       "in the future.\n\n");
                }

            }
        }

        public static Person[] CreateFamily()
        {
            int familySize = 0;

            Console.WriteLine("Please enter the size of your family.");
            while (true)
            {
                try
                {
                    familySize = Int32.Parse(Console.ReadLine());
                    break;
                }
                catch (Exception)
                {
                    Console.WriteLine("Please try entering some valid information.");
                }
            }
            
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
                while (true)
                {
                    try
                    {
                        age = (Int32.Parse(Console.ReadLine()));
                        break;
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("Please try entering some valid information.");
                    }
                }               
                Console.WriteLine("Please enter family member {0}'s role (ex. father, mother, son, daughter)", i + 1);
                testRole = Console.ReadLine();

                Person.AssignRole(testRole, out role);

                switch (role)
                {
                    case Person.Role.father:
                        moatsFamily[i] = new Father(name, hobby, age, role);
                        break;
                    case Person.Role.mother:
                        moatsFamily[i] = new Mother(name, hobby, age, role);
                        break;
                    case Person.Role.son:
                        moatsFamily[i] = new Son(name, hobby, age, role);
                        break;
                    case Person.Role.daughter:
                        moatsFamily[i] = new Daughter(name, hobby, age, role);
                        break;
                    default:
                        Console.WriteLine("You failed to enter a role, so this person does not exist.");
                        break;
                }
            }
            return moatsFamily;
        }

    }
}
