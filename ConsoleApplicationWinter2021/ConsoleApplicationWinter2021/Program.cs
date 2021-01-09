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
            Console.WriteLine($"I am from {location}.");

            //4.
            DateTime currentDate = DateTime.Now;
            //Optional var currentDate = DateTime.Now;
            Console.WriteLine($"The current date is {currentDate.ToString("d")}");

            //5.Output the number of days until Christmas this year(2021)
            DateTime christmas = new DateTime(2021, 12, 25);
            Console.WriteLine($"The number of days until Christmas: {Math.Round((christmas - currentDate).TotalDays)}");

            //6.Add the program example from section 2.1
            double width, height, woodLength, glassArea;
            string widthString, heightString;
            Console.WriteLine("Please enter the width:");
            widthString = Console.ReadLine();
            width = double.Parse(widthString);
            Console.WriteLine("Please enter the height:");
            heightString = Console.ReadLine();
            height = double.Parse(heightString);
            woodLength = 2 * (width + height) * 3.25;
            glassArea = 2 * (width * height);
            Console.WriteLine("The length of the wood is " +
            woodLength + " feet");
            Console.WriteLine("The area of the glass is " +
            glassArea + " square metres");

            //7.
            Console.WriteLine("Press any key to exit");
            Console.ReadKey();
        }
    }
}
