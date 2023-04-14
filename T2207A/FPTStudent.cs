using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T2207A
{
    public class FPTStudent : Student // kế thừa là " : ", seale : không cho kế thừa nữa, cuối cùng
    {
        private string className;
        public FPTStudent() 
        {
            this.Name = "Quoc";
        }

        public FPTStudent(string name, string email, int age, string telephone, string className) : base(name, email, age, telephone)// hàm khởi tạo override lại hàm cha
        {
            this.className = className;
        }

        public override void Run()
        {
            base.Run();// lay ham lop cha 
        }

        public new void Learn() // khi ko co virtual ma van phai override thi dung new de thay the vi tri ham cu
        {

        }

    }
}
