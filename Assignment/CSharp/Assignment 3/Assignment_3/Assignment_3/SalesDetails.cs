using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_3
{
    class SaleBase
    {
        public int SalesNo;
        public int ProductNo;
        public double Price;
        public DateTime DateOfSale;

        public SaleBase(int salesNo, int productNo, double price, DateTime dateOfSale)
        {
            SalesNo = salesNo;
            ProductNo = productNo;
            Price = price;
            DateOfSale = dateOfSale;
        }

        public virtual void ShowData()
        {
            Console.WriteLine("Sales No: " + SalesNo);
            Console.WriteLine("Product No: " + ProductNo);
            Console.WriteLine("Price: " + Price);
            Console.WriteLine("Date of Sale: " + DateOfSale);
        }
    }
    internal class SalesDetails : SaleBase
    {
        public int Qty;
        public double TotalAmount;
        public SalesDetails(int qty, int salesNo, int productNo, double price, DateTime dateOfSale)
            : base(salesNo, productNo, price, dateOfSale)
        {
            Qty = qty;
            SalesTotal();
        }

        public void SalesTotal()
        {
            TotalAmount = Qty * Price;
            Console.WriteLine(TotalAmount);
            //ShowData();
        }
        public override void ShowData()
        {
            base.ShowData();
            //SalesTotal();
            Console.WriteLine("Quantity: ", Qty);
            Console.WriteLine("Total Amount: ", TotalAmount);
        }

        public static void Object()
        {
            Console.WriteLine("Enter the Quantity: ");
            int qty = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Sales no: ");
            int salesNo = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Product no: ");
            int productNo = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Price: ");
            Double price = Convert.ToDouble(Console.ReadLine());

            SalesDetails sales = new SalesDetails(qty, salesNo, productNo, price, DateTime.Now);
            sales.ShowData();  
        }

        static void Main()
        {
            SalesDetails.Object();
        }
    }
}
