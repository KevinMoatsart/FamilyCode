using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoatsFamily
{
    class Mother : Person
    {

        public bool LovesToCook { get; set; }
        //constructors
        public Mother(string name, string hobby, int age, Person.Role role)
            : base(name, hobby, age, role){ }

        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine("{0} loves to cook: {1}", Name, LovesToCook);
        }

        public override void AssignTrait()
        {
            while (true)
            {
                try
                {
                    Console.WriteLine("Does {0} love to cook? (true or false)", Name);
                    LovesToCook = Boolean.Parse(Console.ReadLine());
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
    }
}
