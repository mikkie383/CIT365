using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplicationWinter2021
{
    class Program
    {
        static void Main(string[] args)
        {
            //2.
            string name = "Michael Tsao";
            string location = "Rexburg, ID";

            //3.
            Console.WriteLine($"My name is {name}.");
            Console.WriteLine("I am from " + location);

            //4.
            DateTime currentDate = DateTime.Now;
            //Optional var currentDate = DateTime.Now;
            Console.WriteLine("The current date is " + currentDate.ToString("d"));

            //5.


            //6.

            
            //7.


            Console.WriteLine("Press any key to exit");
            Console.ReadKey();
        }
    }
}
