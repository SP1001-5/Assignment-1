using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeChallenge__1
{
    struct Employeedb
    {
        public string Name { get; set; }
        public DOB Details;

        public struct DOB
        {
            public int Day { get; set; }
            public int Month { get; set; }
            public int Year { get; set; }
        }
    }
    internal class EmployeeDOB
    {
        static void Main()
        {
            
            
                Employeedb eDB = new Employeedb();
                Console.WriteLine("Enter name : ");
                string name = Console.ReadLine();
                eDB.Name = name;
                Console.WriteLine("Enter day : ");
                int day = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter month : ");
                int month = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter year : ");
                int year = Convert.ToInt32(Console.ReadLine());
                eDB.Details = new Employeedb.DOB()
                {
                    Day = day,
                    Month = month,
                    Year = year
                };

                Console.WriteLine("Name : " +  eDB.Name);
                Console.WriteLine("Day : " + eDB.Details.Day);
                Console.WriteLine("Month : " + eDB.Details.Month);
                Console.WriteLine("Year : " + eDB.Details.Year);
            
        }
    }
}
