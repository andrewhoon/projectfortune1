using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectFortune1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your first name.");
            string firstName = (Console.ReadLine());

            Console.WriteLine("Please enter your last name.");
            string lastName = (Console.ReadLine());

            Console.WriteLine("How old were you on your last birthday?");
            int age = int.Parse(Console.ReadLine());

            Console.WriteLine("In numerical form, what month were you born?");
            int monthBorn = int.Parse(Console.ReadLine());

            Console.WriteLine("What is your favorite ROYGBIV Color? Enter \"Help\" if you are unsure what ROYGBIV is.");
            string roygbiv = (Console.ReadLine());

            if (roygbiv.ToUpper() == "HELP")
            {
                Console.WriteLine("R is Red \nO is Orange\nY is Yellow\nG is Green\nB is Blue\nI is Indigo\nV is Violet\nPlease enter your favorite ROYGBIV color.");

            }

            else
            {
                Console.WriteLine("Please re-enter your favorite ROYGBIV color.");
            }
            string favColor = (Console.ReadLine());

            Console.WriteLine("Please enter numerically how many siblings you have.");
            int siblings = int.Parse(Console.ReadLine());

            if (age % 2 == 0)
            {
                Console.WriteLine("You will retire in 25 years.");
            }
            else
            {
                Console.WriteLine("You will retire in 17 years.");
            }

            if (siblings <= -1)
            {
                Console.WriteLine("You will have a horrible vacation home near Heinz Field in Pittsburgh!");
            }
            else if (siblings == 1)
            {
                Console.WriteLine("You will have a vacation home in the Outer Banks.");
            }
            else if (siblings == 2)
            {
                Console.WriteLine("You will have a vacation home in Fiji.");
            }
            else if (siblings == 3)
            {
                Console.WriteLine("You will have a vacation home in Hawai\'i.");
            }
            else if (siblings >= 4)
            {
                Console.WriteLine("You will have a vacation home in Key West.");
            }       


            }

        }
    }

