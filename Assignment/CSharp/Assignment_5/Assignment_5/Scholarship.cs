using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_5
{
    class ScholarshipException : ApplicationException
    {
        public ScholarshipException(string msg) : base (msg)
        {

        }

    }
    internal class Scholarship
    {
        
        public void Merit(double marks, double fees)
        {
            double S_amount;
            if (marks > 90)
            {
                S_amount = fees / 2;
            }
            else if(marks > 80 && marks <= 90)
            {
                S_amount = (30.0 / 100.0) * fees;
            }
            else if( marks>=70 && marks <= 80)
            {
                S_amount = (20.0/100.0) * fees;
            }
            else
            {
                throw new ScholarshipException("You are not eligible for the scholarship");
            }
            Console.WriteLine("The scholarship amount is " + S_amount);
        }
        static void Main()
        {
            double Marks;
            double Fees;
            try
            {
                Scholarship sc = new Scholarship();
                Console.WriteLine("Enter the Mark : ");
                Marks = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Enter the Fees : ");
                Fees = Convert.ToDouble(Console.ReadLine());
                sc.Merit(Marks, Fees);
            }
            catch(FormatException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (ScholarshipException e)
            {
                Console.WriteLine(e .Message); 
            }
        }
    }
}
