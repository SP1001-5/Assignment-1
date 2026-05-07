using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1
{

    public class Employee
    {
        public int EmployeeID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Title { get; set; }
        public DateTime DOB { get; set; }
        public DateTime DOJ { get; set; }
        public string City { get; set; }

        public void DisplayInfo()
        {
            Console.WriteLine($"{EmployeeID} {FirstName} {LastName} Title : {Title}" +
                $" DOB : {DOB.ToString()} DOJ : {DOJ.ToString()} city : {City}");
        }


        
    }

    class List_of_Emp
    {
        public void insert()
        {

            DateTime Dateparser( string empdate )
            {
                var format = "d/M/yyyy"; 
                if (DateTime.TryParseExact(empdate, format, CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime result))
                {
                    return result;
                }
                else
                {
                    Console.WriteLine("Failed");
                }
                return result;
            }


            List<Employee> empList = new List<Employee>
            {
                new Employee { EmployeeID = 1001, FirstName = "Malcolm", LastName = "Daruwalla", Title = "Manager", DOB = Dateparser("16/11/1984"), DOJ = Dateparser("8/6/2011"), City = "Mumbai" },
                new Employee { EmployeeID = 1002, FirstName = "Asdin", LastName = "Dhalla", Title = "AsstManager", DOB = Dateparser("20/08/1984"), DOJ = Dateparser("7/7/2012"), City = "Mumbai" },
                new Employee { EmployeeID = 1003, FirstName = "Madhavi", LastName = "Oza", Title = "Consultant", DOB = Dateparser("14/11/1987"), DOJ = Dateparser("12/4/2015"), City = "Pune" },
                new Employee { EmployeeID = 1004, FirstName = "Saba", LastName = "Shaikh", Title = "SE", DOB = Dateparser("3/6/1990"), DOJ = Dateparser("2/2/2016"), City = "Pune" },
                new Employee { EmployeeID = 1005, FirstName = "Nazia", LastName = "Shaikh", Title = "SE", DOB = Dateparser("8/3/1991"), DOJ = Dateparser("2/2/2016"), City = "Mumbai" },
                new Employee { EmployeeID = 1006, FirstName = "Amit", LastName = "Pathak", Title = "Consultant", DOB = Dateparser("7/11/1989"), DOJ = Dateparser("8/8/2014"), City = "Chennai" },
                new Employee { EmployeeID = 1007, FirstName = "Vijay", LastName = "Natrajan", Title = "Consultant", DOB = Dateparser("2/12/1989"), DOJ = Dateparser("1/6/2015"), City = "Mumbai" },
                new Employee { EmployeeID = 1008, FirstName = "Rahul", LastName = "Dubey", Title = "Associate", DOB = Dateparser("11/11/1993"), DOJ = Dateparser("6/11/2014"), City = "Chennai" },
                new Employee { EmployeeID = 1009, FirstName = "Suresh", LastName = "Mistry", Title = "Associate", DOB = Dateparser("12/8/1992"), DOJ = Dateparser("3/12/2014"), City = "Chennai" },
                new Employee { EmployeeID = 1010, FirstName = "Sumit", LastName = "Shah", Title = "Manager", DOB = Dateparser("12/4/1991"), DOJ = Dateparser("2/1/2016"), City = "Pune" }
            };

            Console.WriteLine("Employee List:");
            foreach (var emp in empList)
            {
                emp.DisplayInfo();
            }

            var dojbefore = empList.Where(e => e.DOJ < Dateparser("1/1/2015"));
            Console.WriteLine("\n1. Joined before 2015:");
            foreach (var e in dojbefore)
                Console.WriteLine(e.FirstName + " " + e.DOJ);

            var dobafter = empList.Where(e => e.DOB > Dateparser("1/1/1990"));
            Console.WriteLine("\n2. DOB after 1990:");
            foreach (var e in dobafter)
                Console.WriteLine(e.FirstName + " " + e.DOB);

            var consultantsAndAssociates = empList.Where(e => e.Title == "Consultant" || e.Title == "Associate");
            Console.WriteLine("\n3. Consultants and Associates:");
            foreach (var emp in consultantsAndAssociates)
                emp.DisplayInfo();

            Console.WriteLine($"\n4. Total employees: {empList.Count}");

            Console.WriteLine($"5. Employees in Chennai: {empList.Count(e => e.City == "Chennai")}");

            Console.WriteLine($"6. Highest EmployeeID: {empList.Max(e => e.EmployeeID)}");

            Console.WriteLine($"7. Employees joined after 1/1/2015: {empList.Count(e => e.DOJ > Dateparser("1/1/2015"))}");

            Console.WriteLine($"8. Employees not Associate: {empList.Count(e => e.Title != "Associate")}");

            Console.WriteLine("\n9. Employees by City:");
            var byCity = empList.GroupBy(e => e.City)
                                .Select(g => new { City = g.Key, Count = g.Count() });
            foreach (var group in byCity)
                Console.WriteLine($"{group.City}: {group.Count}");

            Console.WriteLine("\n10. Employees by City and Title:");
            var byCityTitle = empList.GroupBy(e => new { e.City, e.Title })
                                     .Select(g => new { g.Key.City, g.Key.Title, Count = g.Count() });
            foreach (var group in byCityTitle)
                Console.WriteLine($"{group.City} - {group.Title}: {group.Count}");

            var youngest = empList.OrderByDescending(e => e.DOB).First();
            Console.WriteLine("\n11. Youngest Employee is 1");
            Console.WriteLine($"\nYoungest Employee: {youngest.FirstName} {youngest.LastName}, DOB: {youngest.DOB.ToString()}");

        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            List_of_Emp elist = new List_of_Emp();
            elist.insert();        
        }
    }
}
