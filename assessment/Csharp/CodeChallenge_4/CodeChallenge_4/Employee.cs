using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeChallenge_4
{
    
    internal class Employee
    {
        public int EmployeeID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Title { get; set; }
        public string DOB { get; set; }
        public string DOJ { get; set; }
        public string City { get; set; }

        public void Display()
        {
            Console.WriteLine($"{EmployeeID}\t{FirstName}\t{LastName}\t{Title}\t{DOB}\t{DOJ}\t{City}");
        }

    }

    class List_of_Employees
    {
        List<Employee> employees;
        public void Add_Employees()
        {
            employees = new List<Employee>
            {
            new Employee { EmployeeID = 1001, FirstName = "Malcolm", LastName = "Daruwalla", Title = "Manager", DOB = "16/11/1984", DOJ = "8/6/2011", City = "Mumbai" },
            new Employee { EmployeeID = 1002, FirstName = "Asdin", LastName = "Dhalla", Title = "AsstManager", DOB = "20/08/1984", DOJ = "7/7/2012", City = "Mumbai" },
            new Employee { EmployeeID = 1003, FirstName = "Madhavi", LastName = "Oza", Title = "Consultant", DOB = "14/11/1987", DOJ = "12/4/2015", City = "Pune" },
            new Employee { EmployeeID = 1004, FirstName = "Saba", LastName = "Shaikh", Title = "SE", DOB = "3/6/1990", DOJ = "2/2/2016", City = "Pune" },
            new Employee { EmployeeID = 1005, FirstName = "Nazia", LastName = "Shaikh", Title = "SE", DOB = "8/3/1991", DOJ = "2/2/2016", City = "Mumbai" },
            new Employee { EmployeeID = 1006, FirstName = "Amit", LastName = "Pathak", Title = "Consultant", DOB = "7/11/1989", DOJ = "8/8/2014", City = "Chennai" },
            new Employee { EmployeeID = 1007, FirstName = "Vijay", LastName = "Natrajan", Title = "Consultant", DOB = "2/12/1989", DOJ = "1/6/2015", City = "Mumbai" },
            new Employee { EmployeeID = 1008, FirstName = "Rahul", LastName = "Dubey", Title = "Associate", DOB = "11/11/1993", DOJ = "6/11/2014", City = "Chennai" },
            new Employee { EmployeeID = 1009, FirstName = "Suresh", LastName = "Mistry", Title = "Associate", DOB = "12/8/1992", DOJ = "3/12/2014", City = "Chennai" },
            new Employee { EmployeeID = 1010, FirstName = "Sumit", LastName = "Shah", Title = "Manager", DOB = "12/4/1991", DOJ = "2/1/2016", City = "Pune" }
            };
        }

        public void Display_AllEmployees()
        {
            Console.WriteLine("\nAll Employees:");
            var allEmployees = from e in employees select e;
            foreach (var emp in allEmployees) 
                emp.Display();
        }

        public void Not_Mumbai()
        {
            Console.WriteLine("\nEmployees not in Mumbai");
            var notMumbai = from e in employees where e.City != "Mumbai" select e ;
            foreach (var emp in notMumbai)
                emp.Display();
        }

        public void Asst_Manager()
        {
            Console.WriteLine("\nEmployee whose title is Assistant Manager");
            var asstManager = from e in employees where e.Title == "AsstManager" select e;
            foreach (var emp in asstManager)
                emp.Display();
        }

        public void Last_Name()
        {
            Console.WriteLine("\nEmployees whose last name starts with \'S\' ");
            var lastName = from e in employees where e.LastName.StartsWith("S") select e;
            foreach (var emp in lastName)
                emp.Display();
        }
    }

    class Execute
    {
        static void Main()
        {
            List_of_Employees ListofEmp = new List_of_Employees();
            ListofEmp.Add_Employees();
            ListofEmp.Display_AllEmployees();
            ListofEmp.Not_Mumbai();
            ListofEmp.Asst_Manager();
            ListofEmp.Last_Name();
        }
    }
}
