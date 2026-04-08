using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeChallenge_2
{
    internal class Calculator
    {
        public delegate int CalculatorDelegate(int x, int y);

        public static int Add(int a, int b)
        {
            return a + b;
        }

        public static int Subtract(int a, int b)
        {
            return a - b;
        }

        public static int Multiply(int a, int b)
        {
            return a * b;
        }

        public static int Division(int a, int b)
        {
            return (a / b);
        }

        static void Main()
        {
            Console.WriteLine("Enter the first Number : ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the second Number : ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            CalculatorDelegate add = new CalculatorDelegate(Add);
            CalculatorDelegate subtract = new CalculatorDelegate(Subtract);
            CalculatorDelegate multiply = new CalculatorDelegate(Multiply);
            CalculatorDelegate division = new CalculatorDelegate(Division);

            int sum = add(num1, num2);
            int difference = subtract(num1, num2);
            int product = multiply(num1, num2);
            int divide = division(num1, num2);

            Console.WriteLine($"Addition : {sum}");
            Console.WriteLine($"Subtraction : {difference}");
            Console.WriteLine($"Multiplication : {product}");
            Console.WriteLine($"Division : {divide}");
        }
    }
}
