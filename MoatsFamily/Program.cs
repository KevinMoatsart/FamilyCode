using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoatsFamily
{
    class Program
    {
        static int exitCode = 0;
        static void Main(string[] args)
        {
                Person[] moatsFamily = Person.CreateFamily();

                foreach (Person member in moatsFamily)
                {
                    member.DisplayInfo();
                }
                Console.ReadLine();
            }
        }
    }
