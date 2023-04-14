using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T2207A.assignment3
{
    public class ForeignCustomer : Customer
    {
        protected string country;
        public ForeignCustomer() { }
        public ForeignCustomer(string code, string name, string date, int quantity, string country) : base(code, name, date, quantity)
        {
            this.country = country;
        }
        public override void Enter()
        {
            Console.WriteLine("Nhap vao ma code :");
            string code = Console.ReadLine();
            Console.WriteLine("Nhap ho ten :");
            string n = Console.ReadLine();
            Console.WriteLine("Nhap ngay ra hoa đon :");
            string d = Console.ReadLine();
            Console.WriteLine("Nhap quoc tich :");
            string c = Console.ReadLine();
            Console.WriteLine("Nhap vao so luong :");
            string cmd = Console.ReadLine();
            int q = Convert.ToInt32(cmd);

            this.Code = code;
            this.Name = n;
            this.Date = d;
            this.Quantity = q;
            this.country = c;
        }
        public override void InfoCustomer()
        {
            Console.WriteLine("Ho Ten Khach Hang: " + this.Name);
            Console.WriteLine("Ma Khach Hang: " + this.Code);
            Console.WriteLine("Ngay ra hoa đon: " + this.Date);
            Console.WriteLine("Quoc tich: " + this.country);
            Console.WriteLine("So KW tieu thu: " + this.Quantity);
        }
        public override double Payment()
        {
            return this.Quantity * 2000;
        }
    }
}
