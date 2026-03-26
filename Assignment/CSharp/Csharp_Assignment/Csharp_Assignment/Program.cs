using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Program1();
            Program2();
            Program3();
            Program4();
            Program5();
            Console.Read();
        }

        public static void Program1()
        {
            Console.WriteLine("~~~~~~~~~ Program 1 ~~~~~~~~~~~");
            Console.Write("Input 1st number : ");
            int n1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input 2nd number : ");
            int n2 = Convert.ToInt32(Console.ReadLine());
            if (n1 == n2)
            {
                Console.WriteLine($"{n1} and {n2} are equal");
            }
            else
            {
                Console.WriteLine($"{n1} and {n2} are not equal");
            }
         

        }
        public static void Program2()
        {
            Console.WriteLine("~~~~~~~~~ Program 2 ~~~~~~~~~~~");
            Console.Write("Enter a Number : ");
            int n = Convert.ToInt32(Console.ReadLine());
            if (n > 0)
                Console.WriteLine($"{n} is a positive number");
            else
                Console.WriteLine($"{n} is a Negative Number");
        }
        public static void Program3()
        {
            Console.WriteLine("~~~~~~~~~ Program 3 ~~~~~~~~~~~");
            Console.Write("Input the first number : ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input Operation : ");
            char op = Convert.ToChar(Console.ReadLine());
            Console.Write("Input the second number : ");
            int num2 = Convert.ToInt32(Console.ReadLine());
            switch (op)
            {
                case '+':
                    Console.WriteLine($"{num1} {op} {num2} = {num1 + num2}");
                    break;
                case '-':
                    Console.WriteLine($"{num1} {op} {num2} = {num1 - num2}");
                    break;
                case '*':
                    Console.WriteLine($"{num1} {op} {num2} = {num1 * num2}");
                    break;
                case '/':
                    Console.WriteLine($"{num1} {op} {num2} = {num1 / num2}");
                    break;
            }
        }
        public static void Program4()
        {
            Console.WriteLine("~~~~~~~~~ Program 4 ~~~~~~~~~~~");
            Console.Write("Enter the NUmber : ");
            int n = Convert.ToInt32(Console.ReadLine());
            for(int i=0; i <= 10; i++)
            {
                Console.WriteLine($"{n} * {i} = {n * i}");
            }
        }

        public static void Program5()
        {
            Console.WriteLine("~~~~~~~~~ Program 5 ~~~~~~~~~~~");
            Console.Write("Enter Number1 : ");
            int n1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Number2 : ");
            int n2 = Convert.ToInt32(Console.ReadLine());
            if (n1 == n2)
            {
                Console.WriteLine($"The sum is : {(n1 + n2) * 3}");
            }
            else
                Console.WriteLine($"the sum is : {n1 + n2}");
        }
    }
}
