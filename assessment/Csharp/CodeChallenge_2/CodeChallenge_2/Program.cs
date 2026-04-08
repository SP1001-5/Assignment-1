using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeChallenge_2
{

    abstract class Student
    {
        public string Name { get; set; }
        public int StudentId { get; set; }
        public double Grade { get; set; }

        public Student(string name, int studentId, double grade)
        {
            Name = name;
            StudentId = studentId;
            Grade = grade;
        }

        public abstract bool IsPassed(double Grade);
        public override string ToString()
        {
            return $"Name: {Name}, ID: {StudentId}, Grade: {Grade}";
        }
    }

    class UnderGraduate : Student
    {
        public UnderGraduate(string name, int id, double grade) : base(name, id, grade) { }

        public override bool IsPassed(double Grade)
        {
            if (Grade > 70.0)
            {
                Console.WriteLine("You are Passed");
                return true;
            }
            else
            {
                Console.WriteLine("Sorry You are not Passed");
                return false;
            }
                
        }
    }

    class Graduate : Student
    {
        public Graduate(string name, int id, double grade) : base(name, id, grade) { }

        public override bool IsPassed(double Grade)
        {
            if (Grade > 80.0)
            {
                Console.WriteLine("You are Passed");
                return true;
            }
            else
            {
                Console.WriteLine("Sorry You are not Passed");
                return false;
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Is the student Graduate or UnderGraduate? : ");
            string Posting = Console.ReadLine();
            Console.WriteLine("Enter the Student Name : ");
            string S_name = Console.ReadLine();
            Console.WriteLine("Enter the Student ID : ");
            int S_id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Grade : ");
            double S_grade = Convert.ToDouble(Console.ReadLine());
            if (Posting == "Graduate" || Posting == "graduate")
            {
                Graduate gradStudent = new Graduate(S_name, S_id, S_grade);
                Console.WriteLine(gradStudent.ToString());
                Console.WriteLine("Graduate Passed? " + gradStudent.IsPassed(gradStudent.Grade));

            }
            else if(Posting == "UnderGraduate" || Posting == "undergraduate")
            {
                UnderGraduate ugStudent = new UnderGraduate(S_name, S_id, S_grade);
                Console.WriteLine(ugStudent.ToString());
                Console.WriteLine("Undergraduate Passed? " + ugStudent.IsPassed(ugStudent.Grade));

            }
        }
    }
}
