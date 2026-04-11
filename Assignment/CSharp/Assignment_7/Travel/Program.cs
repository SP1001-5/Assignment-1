using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravelLibrary;

namespace Travel
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your Name:");
            string name = Console.ReadLine();

            Console.WriteLine("Enter your Age:");
            int age = Convert.ToInt32(Console.ReadLine());

            Class1 calculator = new Class1();
            string result = calculator.CalculateConcession(name, age);

            Console.WriteLine(result);
        }
    }
}
