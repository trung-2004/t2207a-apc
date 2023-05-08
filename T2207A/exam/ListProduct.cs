using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using T2207A.assignment3;
using T2207A.assignment4;
using T2207A.assignment6;

namespace T2207A.exam
{
    public class ListProduct
    {
        public List<Product> list = new List<Product>();
        public void AddProduct()
        {
            Product product = new Product();
            Console.Write("Product ID: ");
            product.Id = Convert.ToInt32(Console.ReadLine());
            Console.Write("Product Name: ");
            product.Name = Console.ReadLine();
            Console.Write("Product Price: ");
            product.Price = Convert.ToDouble(Console.ReadLine());
            list.Add(product);
            Console.WriteLine("Product added successfully.");
        }
        public void DisplayProducts()
        {
            Console.WriteLine("ID\tName\tPrice");

            foreach (Product product in list)
            {
                Console.WriteLine($"{product.Id}\t{product.Name}\t{product.Price}");
            }
        }
        public void DeleteProduct()
        {
            Console.Write("Enter product ID to delete: ");
            int id = int.Parse(Console.ReadLine());

            for (int i = 0; i < list.Count; i++)
            {
                if (list[i].Id == id)
                {
                    list.RemoveAt(i);
                    Console.WriteLine("Product deleted successfully.");
                    return;
                }
            }

            Console.WriteLine("Product not found.");
        }
        }
}
