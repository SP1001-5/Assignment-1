using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_4
{

    class Program1
    {
        public void StrRemove(string s, int num)
        {
            if (num >= 0 && num < s.Length)
            {
                string result = s.Remove(num,1);
                Console.WriteLine("The string after removal is {0}", result);
            }
            else
            {
                Console.WriteLine("Invalid index");
            }
        }   
        
        public void StrExchange(string s)
        {
            int length = s.Length;
            char[] CArray = s.ToCharArray();
            char temp1, temp2;
            temp1 = CArray[0];
            temp2 = CArray[length - 1];
            CArray[0] = temp2;
            CArray[length - 1] = temp1;
            string news = new string(CArray);
            Console.WriteLine(news);
        }

        public void StackSort(int n)
        {
            Stack<int> st = new Stack<int>();
            for(int i = 0; i < n; i++) 
            {
                Console.Write("Enter the value {0} : ",i+1);
                int val = Convert.ToInt32(Console.ReadLine());
                st.Push(val);
                
            }
            int[] stList = st.ToArray();
            Array.Sort(stList);
            Console.WriteLine("\nThe sorted array is ");
            foreach (int val in stList)
            {
                Console.Write(val + " ");
            }
            //st.Push(2);
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--------Program 1----------");
            Console.Write("Enter the string : ");
            string str1 = Console.ReadLine();
            Console.Write("Enter the index value : ");
            int value = Convert.ToInt32(Console.ReadLine());
            Program1 pr = new Program1();
            pr.StrRemove(str1, value);

            Console.WriteLine("\n--------Program 2----------");
            Console.Write("Enter the string : ");
            string str2 = Console.ReadLine();
            pr.StrExchange(str2);

            Console.WriteLine("\n--------Program 3----------");
            Console.Write("Enter the number of values to be pushed in Stack : ");
            int num = Convert.ToInt32(Console.ReadLine());
            pr.StackSort(num);
            
        }
    }
}
