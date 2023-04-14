using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace T2207A.assignment3
{
    public class Customer
    {
        private string code;
        private string name;
        private string date;
        private int quantity;

        public Customer() 
        {

        }
        public Customer(string code, string name, string date, int quantity)
        {
            this.code = code;
            this.name = name;
            this.date = date;
            this.quantity = quantity;
        }
        public string Code
        {
            get { return code; }
            set { code = value; }
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string Date
        {
            get { return date; }
            set { date = value; }
        }
        public int Quantity
        {
            get { return quantity; }
            set { quantity = value; }
        }
        public virtual void Enter() 
        {
            Console.WriteLine("Nhap vao ma code :");
            string code = Console.ReadLine();
            Console.WriteLine("Nhap ho ten :");
            string n = Console.ReadLine();
            Console.WriteLine("Nhap ngay ra hoa đon :");
            string d = Console.ReadLine();
            Console.WriteLine("Nhap vao so luong :");
            string cmd = Console.ReadLine();
            int q = Convert.ToInt32(cmd);

            this.code = code;
            this.name = n;
            this.date = d;
            this.quantity = q;

        }
        public virtual void InfoCustomer()
        {
            Console.WriteLine("Ho Ten Khach Hang: " + this.name);
            Console.WriteLine("Ma Khach Hang: " + this.code);
            Console.WriteLine("Ngay ra hoa đon: " + this.date);
            Console.WriteLine("So KW tieu thu: " + this.quantity);
        }
        public virtual double Payment()
        {
            return quantity * 1000;
        }
    }
}
