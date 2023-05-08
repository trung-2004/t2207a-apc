using System.Collections.Generic;
using T2207A;
using T2207A.assignment3;
using T2207A.assignment4;
using T2207A.assignment5;
using T2207A.assignment6;
using T2207A.exam;

public class Program
{
    public static void Main(string[] args)
    {
        ListProduct list = new ListProduct();
        int option;

        do
        {
            Console.WriteLine("Please select an option:");
            Console.WriteLine("1. Add product records");
            Console.WriteLine("2. Display product records");
            Console.WriteLine("3. Delete product by Id");
            Console.WriteLine("4. Exit");

            if (int.TryParse(Console.ReadLine(), out option))
            {
                switch (option)
                {
                    case 1:
                        list.AddProduct();
                        break;
                    case 2:
                        list.DisplayProducts();
                        break;
                    case 3:
                        list.DeleteProduct();
                        break;
                    case 4:
                        Console.WriteLine("Exiting...");
                        break;
                    default:
                        Console.WriteLine("Invalid option");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Invalid option");
            }

            Console.WriteLine();
        } while (option != 4);
    }
}
