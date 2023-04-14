using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T2207A
{
    public class Student
    {
        private string name;
        private int age;
        private string email;
        private string telephone;

        public Student() 
        {
            
        }
        public Student(string name, string email, int age, string telephone)
        {
            this.name = name;
            this.email = email;
            this.age = age;
            this.telephone = telephone;

        }
        public string Name
        {
            get { return this.name; }
            set { this.name = value; }   
        }
        public int Age
        {
            get { return this.age; }
            set { this.age = value; }
        }
        public string Email
        {
            get { return this.email; }
            set { this.email = value; }
        }
        public string Telephone
        {
            get { return this.telephone; }
            set { this.telephone = value; }
        }
        public virtual void Run()// virtual cho phép các hàm con kế thừa nó được override lại
        {
            Console.WriteLine(this.name + "Running...");
        }
        public void Lean()
        {
            Console.WriteLine("Leanning...");
        }
        public void Lean(string s)// overloading
        {
            Console.WriteLine("Leanning...");
        }
    }
}
