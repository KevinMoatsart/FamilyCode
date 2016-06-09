using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoatsFamily
{
    sealed class Father : Person
    {
        public bool HasManCave { get; set; }
        public double Salary { get; set; }

        //constructors
        public Father(string name, string hobby, int age, Person.Role role)
            : base(name, hobby, age, role){
            AssignSalary();
        }

        //methods
        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine("{0} has a man cave: {1}", Name, HasManCave);
            Console.WriteLine("{0} currently makes ${1} a year.", Name, Salary);
        }

        public override void AssignTrait()
        {
            while (true)
            {
                try
                {
                    Console.WriteLine("Does {0} have a man cave? (true or false)", Name);
                    HasManCave = Boolean.Parse(Console.ReadLine());
                    break;
                }
                catch (ArgumentException)
                {
                    Console.WriteLine("\nSorry but the answer you entered is invalid. Please try again.");
                }
                catch (FormatException)
                {
                    Console.WriteLine("\nSorry but the answer you entered is invalid. Please try again.");
                }

            }
        }

        public void AssignSalary()
        {
            Console.WriteLine("how much does {0} make a year?", Name);
            while (true)
            {
                try
                {
                    Salary = Double.Parse(Console.ReadLine());
                    break;
                }
                catch (FormatException e)
                {
                    Console.WriteLine("Sorry but that is an invalid answer.");
                    Console.WriteLine("\n\nError: {0}", e);
                }
            }
        }
    }
}
