using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Remoting.Services;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_7
{
    internal class Program
    {
        public void SquareValue()
        {
            Console.WriteLine("Enter the number of input : ");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] value = new int[n];
            for (int i = 0; i < value.Length; i++)
            {
                Console.Write("Enter the value " + (i + 1) + " : ");
                value[i] = Convert.ToInt32(Console.ReadLine());
            }
            var squarequery = value.Where(x => x * x > 20);
            foreach (var x in squarequery)
            {
                Console.WriteLine(x + " -> " + x * x);
            }
        }
        
        public void LetterContain()
        {
            Console.WriteLine("Enter the number of input : ");
            int n = Convert.ToInt32(Console.ReadLine());
            string[] str = new string[n];
            for (int i = 0; i < str.Length; i++)
            {
                Console.Write("Enter the String value " + (i + 1) + " : ");
                str[i] = Console.ReadLine();
            }
            var wordcontains = str.Where(x => x.StartsWith("a") && x.EndsWith("m"));
            foreach(var x in wordcontains)
            {
                Console.WriteLine(x);
            }
        }
        
        static void Main(string[] args)
        {
            Program program = new Program();
            Console.WriteLine("Program 1");
            program.SquareValue();
            Console.WriteLine("\nProgram 2");
            program.LetterContain();
        }
    }

}
