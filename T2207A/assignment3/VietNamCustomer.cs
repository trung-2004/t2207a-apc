using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T2207A.assignment3
{
    public class VietNamCustomer : Customer
    {
        protected string customers; 
        public VietNamCustomer()
        {

        }
        public VietNamCustomer(string code, string name, string date, int quantity, string customers) : base(code, name, date, quantity)
        {
            this.customers = customers;
        }
        public override void Enter()
        {
            Console.WriteLine("Nhap vao ma code :");
            string code = Console.ReadLine();
            Console.WriteLine("Nhap ho ten :");
            string n = Console.ReadLine();
            Console.WriteLine("Nhap ngay ra hoa đon :");
            string d = Console.ReadLine();
            Console.WriteLine("Nhap đoi tuong khach hang(sinh hoat/ kinh doanh/ san suat) :");
            string c = Console.ReadLine();
            Console.WriteLine("Nhap vao so luong :");
            string cmd = Console.ReadLine();
            int q = Convert.ToInt32(cmd);

            this.Code = code;
            this.Name = n;
            this.Date = d;
            this.Quantity = q;
            this.customers = c;
        }
        public override void InfoCustomer()
        {
            Console.WriteLine("Ho Ten Khach Hang: " + this.Name);
            Console.WriteLine("Ma Khach Hang: " + this.Code);
            Console.WriteLine("Ngay ra hoa đon: " + this.Date);
            Console.WriteLine("Đoi tuong khach hang: " + this.customers);
            Console.WriteLine("So KW tieu thu: " + this.Quantity);
        }
        public override double Payment()
        {
            if (this.Quantity <= 50)
            {
                return this.Quantity * 1000;
            }
            else if (this.Quantity <= 100)
            {
                return (this.Quantity - 50) * 1200 + 50 * 1000;
            }
            else if (this.Quantity <= 200)
            {
                return (this.Quantity - 100) * 1500 + (50 * 1000) + (50 * 1200);
            }
            else
            {
                return (this.Quantity - 200) * 2000 + (50 * 1000) + (50 * 1200) + (100 * 1500);
            }
        }
    }
}
