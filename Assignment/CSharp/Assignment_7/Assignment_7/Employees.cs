using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_7
{
    class Employees
    {
        public int EmpId { get; set; }
        public string EmpName { get; set; }
        public string EmpCity { get; set; }
        public double EmpSalary { get; set; }
    }

    internal class Final
    {
        public void DisplayEmployees(IEnumerable<Employees> employees)
        {
            Console.WriteLine("\nDisplaying all the details : ");
            foreach (var emp in employees)
            {
                Console.WriteLine($"ID: {emp.EmpId}, Name: {emp.EmpName}, City: {emp.EmpCity}, Salary: {emp.EmpSalary}");
            }
        }

        public void SalaryDisplay(IEnumerable<Employees> employees)
        {
            Console.WriteLine("\nDisplaying the employee whose salary greater than 45000 : ");
            var salaryHigh = employees.Where(e => e.EmpSalary > 45000);
            DisplayEmployees(salaryHigh);
        }

        public void RegionDisplay(IEnumerable<Employees> employees)
        {
            Console.WriteLine("\nDisplaying the employee details whose city is bangalore : ");
            var bloreRegiion = employees.Where(e => e.EmpCity == "Bangalore" || e.EmpCity == "bangalore");
            DisplayEmployees(bloreRegiion);
        }

        public void NameDisplay(IEnumerable<Employees> employees)
        {
            Console.WriteLine("\nDisplaying the employee details ascending with the name : ");
            var sortName = employees.OrderBy(e => e.EmpName);
            DisplayEmployees(sortName);
        }

        static void Main()
        {
            Final f1 = new Final();
            Console.WriteLine("Enter the number of employee details to add");
            int n = Convert.ToInt32(Console.ReadLine());
            List<Employees> employees = new List<Employees> ();
            for(int i = 0; i < n; i++)
            {
                Console.WriteLine("Enter the id : ");
                int empid = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter the name : ");
                string empname = Console.ReadLine();
                Console.WriteLine("Enter the city : ");
                string empcity = Console.ReadLine();
                Console.WriteLine("Enter the salary : ");
                double empsalary = Convert.ToDouble(Console.ReadLine());
                employees.Add(new Employees {EmpId = empid, EmpName = empname, EmpCity = empcity, EmpSalary = empsalary});
               
            }
            f1.DisplayEmployees(employees);
            f1.SalaryDisplay(employees);
            f1.RegionDisplay(employees);
            f1.NameDisplay(employees);
        }

        
    }
}
