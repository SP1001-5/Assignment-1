using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Security.Cryptography.X509Certificates;

namespace FirstConsole
{
    class Box
    {
        public int length;
        public int breadth;

        public static Box operator *(Box box1, Box box2)
        {
            Box temp = new Box();
            temp.length = box1.length * box2.length;
            temp.breadth = box1.breadth * box2.breadth;
            return temp;
        }

        //public static Box operator ++(Box box1)
        //{
        //    Box temp = new Box();
        //    temp.length = box1.length++;
        //    temp.breadth = box1.breadth++;
        //    return temp;
        //}
    }

    internal class InheritanceEg
    {
        //    int c = 0;
        //    static void Main(string[] args)
        //    {
        //        int a, b;
        //        InheritanceEg ig = new InheritanceEg();
        //        try
        //        {
        //            Console.Write("Two numbers");
        //            a = int.Parse(Console.ReadLine()); //format exce
        //            b = int.Parse(Console.ReadLine());

        //            ig.c = a / b; //zero exception
        //   int[] arr = { 1, 2, 3, 4}
        //            ;
        //            Console.Write(arr[6]); //range exce
        //            Console.Write(ig.c);
        //        }
        //        catch (DivideByZeroException de)
        //        {
        //            Console.Write(de.Message);
        //            Console.Write("Cannot divide number by zero");

        //    }
        //        catch (FormatException fe)
        //        {
        //            Console.Write(fe.Message + fe.Source);
        //        }
        //        catch (IndexOutOfRangeException ie)
        //        {
        //            Console.Write("You are trying to reach beyond your elements");
        //        }
        //        catch (Exception e)
        //        {
        //            Console.Write("Something went Wrong");  // to handle all exceptions
        //            Console.Write(e.Message);
        //        }
        //        finally
        //        {
        //            Console.Write("Reached finally");
        //            Console.Write(ig.c);
        //        }
        //    }
        public static void MarkToGrade(int mark)
        {
            if (mark <= 100 && mark >= 90)
            {
                Console.WriteLine("Your grade is A");
            }
            else if (mark < 90 && mark >= 70)
            {
                Console.WriteLine("Your grade is B");
            }
            else if (mark < 70 && mark >= 50)
            {
                Console.WriteLine("Your grade is C");
            }
            else if (mark > 0 && mark < 50)
            {
                Console.WriteLine("Your grade is D");
            }
            else
            {
                throw new MarkException("Fill your Mark");
            }

        }

        static void Main()
        {
            int marks;
            Console.WriteLine("Enter Your Mark :");
            try {
                marks = Convert.ToInt32(Console.ReadLine());  
                MarkToGrade(marks);
            }
            catch (FormatException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (MarkException m)
            {
                Console.WriteLine(m.Message);
            }
            Console.Read();
        }
    }



    class MarkException : ApplicationException
    {
        public MarkException(string s) : base(s) { }
    }
}
        

