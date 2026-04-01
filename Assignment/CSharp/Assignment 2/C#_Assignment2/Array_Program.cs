using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Assignment2
{
    class Average
    {
        public void Program1()
        {
            Console.Write("Enter the number to get the size of the Array : ");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] arr1 = new int[n];
            int sum = 0;
            Console.WriteLine("Enter the Values : ");
            for (int i = 0; i < n; i++)
            {
                arr1[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.Write("The average value is : ");
            for (int i = 0; i < n; i++)
            {
                sum = sum + arr1[i];
            }
            int res = sum / n;
            Console.WriteLine(res);
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = i + 1; j < n; j++)
                {
                    if (arr1[i] > arr1[j])
                    {
                        int temp = arr1[i];
                        arr1[i] = arr1[j];
                        arr1[j] = temp;
                    }
                }
            }
            Console.WriteLine($"The minimum value is : {arr1[0]}");
            Console.WriteLine($"The maximum value is : {arr1[n - 1]}");


        }
    }

    class Marks
    {
        public void Program2()
        {
            Console.WriteLine("Enter the marks : ");
            int total = 0, average = 0;
            int[] mark = new int[10];
            for (int i = 0; i < 10; i++)
            {
                mark[i] = Convert.ToInt32(Console.ReadLine());
            }
            for(int i = 0; i < 10; i++)
            {
                total += mark[i];
            }
            average = total / 10;
            Console.WriteLine($"The total mark is {total}");
            Console.WriteLine($"The average for the mark is : {average}");
            Console.WriteLine($"The minimum value is : {mark.Min()}");
            Console.WriteLine($"The maximum value is : {mark.Max()}");
            Console.Write("The ascending order of the mark is : ");
            Array.Sort( mark );
            for (int i = 0; i < 10; i++)
            {
                Console.Write(mark[i] + " ");
            }
            Console.WriteLine();    
            Console.Write("The descending order of the mark is : ");
            for (int i = 9; i >= 0; i--)
            {
                Console.Write(mark[i] + " ");
            }
            Console.WriteLine() ;

        }
    }
    class Copy_Array
    {
      
        public void Program3()
        {
            Console.Write("Enter the number to get the size of the Array : ");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] arr1 = new int[n];
            Console.WriteLine("Enter the Values : ");
            for(int i=0; i<n; i++)
            {
                arr1[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("The Original Array values are :");
            for (int i = 0; i < arr1.Length; i++)
            {
                Console.Write($"{arr1[i]} ");
            }
            Console.WriteLine();
            int[] arr2 = new int[n];
            for(int j=0; j<n; j++ )
            {
                arr2[j] = arr1[j];
            }
            Console.WriteLine("The copy of the array is");
            for(int i = 0; i<arr2.Length; i++)
            {
                Console.Write(arr2[i]);
            }
        }
        
    }
    internal class Array_Program
    {
        static void Main() { 
            Average average = new Average();
            Marks marks = new Marks();
            Copy_Array copy = new Copy_Array();
            Console.WriteLine("Program 1 : ");
            average.Program1();
            Console.WriteLine("Program 2 : ");
            marks.Program2();
            Console.WriteLine("Program 3 : ");
            copy.Program3();
        }
    }
}
