using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T2207A
{
    public class Student
    {
        public string name;
        public int age;
        public string email;
        public string telephone;

        public Student() 
        {
            
        }
        public void Run()
        {
            Console.WriteLine(this.name + "Running...");
        }
        public void Lean()
        {
            Console.WriteLine("Leanning...");
        }
    }
}
