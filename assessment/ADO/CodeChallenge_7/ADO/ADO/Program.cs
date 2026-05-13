using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADO
{
    internal class Program
    {

        static SqlConnection conn = null;
        static SqlDataReader dr = null;
        static SqlCommand cmd = null;
        static SqlConnection getconn()
        {
            conn = new SqlConnection("Data Source = (localdb)\\MSSQLLocalDB; Database = Employeemanagement; trusted_connection = true");
            conn.Open();
            return conn;
        }

        static void Insert(string ename, decimal esal, char etype)
        {
            try
            {
                conn = getconn();
                cmd = new SqlCommand("AddEmployee", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@EmpName", ename);
                cmd.Parameters.AddWithValue("@Empsal", esal);
                cmd.Parameters.AddWithValue("@Emptype", etype);
                int result = cmd.ExecuteNonQuery();
                if (result > 0)
                {
                    Console.WriteLine("Record inserted successfully...");
                }
                else
                    Console.WriteLine("Could not insert record..");
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        static void Display()
        {
            try
            {

                conn = getconn();
                cmd = new SqlCommand("select Empno, EmpName, Empsal, Emptype from Employee_Details", conn);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    Console.WriteLine($"Empno: {dr["Empno"]}, Name: {dr["EmpName"]}, Salary: {dr["Empsal"]}, Type: {dr["Emptype"]}");
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        static void Update(int empno)
        {
            try
            {
                conn = getconn();
                cmd = new SqlCommand("UpdateSal", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Empno", empno);
                SqlParameter outputParam = new SqlParameter("@Updatedsalary", SqlDbType.Decimal);
                outputParam.Precision = 10;
                outputParam.Scale = 2;
                outputParam.Direction = ParameterDirection.Output;
                cmd.Parameters.Add(outputParam);
                cmd.ExecuteNonQuery();
                decimal updatedSalary = (decimal)outputParam.Value;
                Console.WriteLine("Updated Salary: " + updatedSalary);
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the name : ");
            string ename = Console.ReadLine();
            Console.WriteLine("Enter the Salary : ");
            decimal esal = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Enter the Employee Type (Fulltime F Parttime P) : ");
            char etype = Convert.ToChar(Console.ReadLine());
            Insert(ename, esal, etype);
            Display();
            Console.WriteLine("Enter the employee number : ");
            int eno = Convert.ToInt32(Console.ReadLine());
            Update(eno);
            Display();
        }
    }
}
