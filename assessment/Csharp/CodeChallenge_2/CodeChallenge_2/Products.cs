using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeChallenge_2
{
    internal class Products
    {
        int Product_id { get; set; }
        string ProductName { get; set; }
        double Price { get; set; }

        public Products(int id, string productName, double price)
        {
            Product_id = id;
            ProductName = productName;
            Price = price;
        }

        public override string ToString()
        {
            return $"ID: {Product_id}, Name: {ProductName}, Price: {Price}";
        }

        //public void Sorting_Prod(){



        //}

        //public void Display(string productName, double price)
        //{

        //}


        static void Main()
        {
            List<Products> products = new List<Products>();

            for (int i = 0; i < 5; i++)
            {                
                Console.WriteLine("Enter the Product_id : ");
                int id = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter the Product Name : ");
                string name = Console.ReadLine();
                Console.WriteLine("Enter the Price");
                double price = Convert.ToDouble(Console.ReadLine());
                products.Add(new Products(id, name, price));
            }

            var sortedProducts = products.OrderBy(p => p.Price).ToList();
            foreach (Products p in sortedProducts)
            {
                Console.WriteLine(p);
            }
        }
    }
}
