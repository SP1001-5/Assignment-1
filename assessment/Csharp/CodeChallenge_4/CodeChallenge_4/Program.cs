using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeChallenge_4
{
    class Distance
    {
        int Kilometer { get; set; }

        public Distance(int kilometer)
        {
            this.Kilometer = kilometer;
        }
        public static Distance Add_distance(Distance d1, Distance d2)
        {
            Distance d3 = new Distance(d1.Kilometer + d2.Kilometer);
            return d3;
        }

        public void Display()
        {
            Console.WriteLine($"DIstance {Kilometer} km");
        }
    }

    class Test
    {
        public static void Test_Function()
        {
            Console.WriteLine("Enter the distance 1 : ");
            int d1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the distance 2 : ");
            int d2 = Convert.ToInt32(Console.ReadLine());
            if (d1 < 0 || d2 < 0)
            {
                Console.WriteLine("The kilometer you have given is not valid");
            }
            else
            {
                Distance distance1 = new Distance(d1);
                Distance distance2 = new Distance(d2);
                Distance distance3 = Distance.Add_distance(distance1, distance2);
                Console.WriteLine("After adding the distance");
                distance3.Display();
            }
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            //Test test = new Test();
            Test.Test_Function();
            //Console.WriteLine("Enter the distance 1 : ");
            //int d1 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Enter the distance 2 : ");
            //int d2 = Convert.ToInt32(Console.ReadLine());
            //Distance distance1 = new Distance(d1);
            //Distance distance2 = new Distance(d2);
            //Distance distance3 = Distance.Add_distance(distance1, distance2);
            //Console.WriteLine("After adding the distance");
            //distance3.Display();
        }
    }
}
