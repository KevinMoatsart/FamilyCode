using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoatsFamily
{
    class Son : Person
    {

        public bool HasGirlfriend { get; set; }
        //constructors
        public Son(string name, string hobby, int age, Person.Role role)
            : base(name, hobby, age, role){ }

        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine("{0} has a girlfriend: {1}", Name, HasGirlfriend);
        }

        public override void AssignTrait()
        {
            while (true)
            {
                try
                {
                    Console.WriteLine("Does {0} have a girlfriend? (true or false)", Name);
                    HasGirlfriend = Boolean.Parse(Console.ReadLine());
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
