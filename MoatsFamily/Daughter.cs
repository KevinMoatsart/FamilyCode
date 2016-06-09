using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoatsFamily
{
    sealed class Daughter : Person
    {
        public bool HasBoyfriend { get; set; }

        //constructors
        public Daughter(string name, string hobby, int age, Person.Role role)
            : base(name, hobby, age, role){ }

        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine("{0} has a boyfriend: {1}", Name, HasBoyfriend);
        }

        public override void AssignTrait()
        {
            while (true)
            {
                try
                {
                    Console.WriteLine("Does {0} have a boyfriend? (true or false)", Name);
                    HasBoyfriend = Boolean.Parse(Console.ReadLine());
                    break;
                }
                catch (ArgumentException)
                {
                    Console.WriteLine("\nSorry but the answer you entered is invalid. Please try again.");
                }
                catch(FormatException)
                {
                    Console.WriteLine("\nSorry but the answer you entered is invalid. Please try again.");
                }

            }
        }
    }
}
