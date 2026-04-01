using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_3
{
    internal class Student
    {
        public int RollNo;
        public string Name;
        public int Semester;
        public string Branch;
        public string S_Class;

        public Student(int rollNo, string name, int semester, string branch, string s_class)
        {
            RollNo = rollNo;
            Name = name;
            Semester = semester;
            Branch = branch;
            S_Class = s_class;
        }

        public void Display()
        {
            Console.WriteLine("Roll No: " + RollNo);
            Console.WriteLine("Name: " + Name);
            Console.WriteLine("Semester: " + Semester);
            Console.WriteLine("Branch: " + Branch);
            Console.WriteLine("Class: " + S_Class);
        }
    }

    class Mark
    {
        public int[] Marks = new int[5];

        public void GetMarks()
        {
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Enter the mark {0}: ", i+1);
                Marks[i] = Convert.ToInt32(Console.ReadLine());
            }
        }

        public void DisplayResult()
        {
            int sum = 0;
            int count = 0;
            foreach (int mark in Marks)
            {
                sum += mark;
                if(sum < 35)
                {
                    count++;
                }
            }
            double average = sum / 5.0;
            if (count != 0)
            {
                Console.WriteLine("Failed");
            }
            else if (average < 50)
            {
                Console.WriteLine("Failed");
            }
            else
            {
                Console.WriteLine("Passed");
            }
        }

    }
    class Sample
    {
        static void Main()
        {
            Console.WriteLine("Enter the Roll no : ");
            int RollNo = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Name : ");
            string Name = Console.ReadLine();
            Console.WriteLine("Enter the Semester : ");
            int Semester = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Branch : ");
            string Branch = Console.ReadLine();
            Console.WriteLine("Enter the Class : ");
            string S_Class = Console.ReadLine();   
            Student student = new Student(RollNo, Name, Semester, Branch, S_Class);
            
            Mark mark = new Mark();
            mark.GetMarks();
            student.Display();
            Console.WriteLine("\nResult : ");
            mark.DisplayResult();
    }
    }
}
