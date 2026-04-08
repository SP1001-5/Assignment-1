using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeChallenge_2
{
    class inputException : ApplicationException
    {
        public inputException(string msg) : base(msg) { }
    }
    internal class ExceptionEg
    {

        public static void E_Method(int num1)
        {
            if(num1 > 0)
            {

                    Console.WriteLine("You have entered the valid number");
            }
                else
                {
                    throw new inputException("The number you have entered is negative. Please enter a Positive Number");
                }
        }
        static void Main()
        {
                try
                {
                    Console.WriteLine("Enter a number : ");
                    int num = Convert.ToInt32(Console.ReadLine());
                    E_Method(num);
                }
                catch (inputException e)
                {
                    Console.WriteLine(e.Message);
                }
        }
    }
}
