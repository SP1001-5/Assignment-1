using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Assignment2
{
    internal class StringEg
    {
        public static void Length_str()
        {
            Console.Write("Enter the word : ");
            string str = Console.ReadLine();
            Console.WriteLine("The length of the word is : {0}", str.Length);
        }

        public static void reverse_str()
        {
            Console.Write("Enter the word : ");
            string str = Console.ReadLine();
            Console.WriteLine("The reverse of the word is : ");
            char[] chars = str.ToCharArray();
            Array.Reverse(chars);
            string reversed = new string(chars);
            Console.WriteLine(reversed);
        }

        public static void equal_str()
        {
            Console.WriteLine("Enter the word 1 : ");
            string str1 = Console.ReadLine();
            Console.WriteLine("Enter the word 2 : ");
            string str2 = Console.ReadLine();
            if(str1 == str2)
            {
                Console.WriteLine("The strings are same");
            }
            else
            {
                Console.WriteLine("The strings are not same");
            }
                
        }
        static void Main()
        {
            Console.WriteLine("Program 1");
            Length_str();
            Console.WriteLine("Program 2");
            reverse_str();
            Console.WriteLine("Program 3");
            equal_str();
        }
    }
}
