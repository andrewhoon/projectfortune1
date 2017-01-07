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
        }
    }
}
