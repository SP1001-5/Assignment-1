using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeChallenge__1
{
    class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Department { get; set; }
        public double Salary { get; set; }
        ArrayList arraylist = new ArrayList();
        public void AddEmp(int userId, string userName, string userDepartment, double userSalary)
        {
            arraylist.Add(new Employee { Id = userId, Name = userName, Department = userDepartment, Salary = userSalary });
        }

        public void EmpDisplay()
        {
            int i = 1;
            foreach (Employee emp in arraylist)
            {
                Console.WriteLine("The details of the Employee {0} : ", i++);
                Console.WriteLine("Employee Id : " + emp.Id);
                Console.WriteLine("Employee Name : " + emp.Name);
                Console.WriteLine("Department : " + emp.Department);
                Console.WriteLine("Salary : " + emp.Salary);
            }
        }

        public void IdDisplay(int id)
        {
            foreach (Employee emp in arraylist){
                if(emp.Id == id)
                {
                    Console.WriteLine("The details of the Employee with {0} : ", id);
                    Console.WriteLine("Employee Id : " + emp.Id);
                    Console.WriteLine("Employee Name : " + emp.Name);
                    Console.WriteLine("Department : " + emp.Department);
                    Console.WriteLine("Salary : " + emp.Salary);
                }
            }
        }

        public void EmpUpdate(int id)
        {
            foreach(Employee emp in arraylist)
            {
                if (emp.Id == id)
                {
                    Console.WriteLine("Enter the User ID : ");
                    emp.Id = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter the User Name : ");
                    emp.Name = Console.ReadLine();
                    Console.WriteLine("Enter the Department : ");
                    emp.Department = Console.ReadLine();
                    Console.WriteLine("Enter the Salary : ");
                    emp.Salary = Convert.ToDouble(Console.ReadLine());
                }
            }
                
        }
        
        public void EmpDelete(int id)
        {
            //Console.WriteLine("Deleted");
            foreach(Employee emp in arraylist)
            {
                if (emp.Id == id)
                {
                    //Console.WriteLine("Deleted");
                    arraylist.Remove(emp);
                    break;
                }
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee();
            //Console.WriteLine("Enter the choice you want to do : ");
            int n;
            do
            {
                Console.WriteLine("\nEnter the choice you want to do : ");
                n = Convert.ToInt32(Console.ReadLine());
                switch (n)
                {
                    case 1:
                        Console.WriteLine("Enter the User ID : ");
                        int Id = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter the User Name : ");
                        string Name = Console.ReadLine();
                        Console.WriteLine("Enter the Department : ");
                        string Department = Console.ReadLine();
                        Console.WriteLine("Enter the Salary : ");
                        double salary = Convert.ToDouble(Console.ReadLine());
                        employee.AddEmp(Id, Name, Department, salary);
                        break;
                    case 2:
                        employee.EmpDisplay();
                        break;
                    case 3:
                        Console.WriteLine("Enter the Id to display : ");
                        int id = Convert.ToInt32(Console.ReadLine());
                        employee.IdDisplay(id);
                        break;
                    case 4:
                        Console.WriteLine("Enter the Id to be updated : ");
                        int UserId = Convert.ToInt32(Console.ReadLine());
                        employee.EmpUpdate(UserId);
                        break;
                    case 5:
                        Console.WriteLine("Enter the Id to be deleted : ");
                        int UId = Convert.ToInt32(Console.ReadLine());
                        employee.EmpDelete(UId);
                        break;
                    case 6:
                        Console.WriteLine("Thank you for visiting");
                        n = 7;
                        break;
                    default:
                        break;
                }
            } while (n > 0 && n < 7);
        }
    }
}
