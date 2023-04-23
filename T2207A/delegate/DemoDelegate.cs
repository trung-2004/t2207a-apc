using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T2207A.Delegate
{
    // khai bao 1 delegate ShowString return void va tham so la 1 string
    public delegate void ShowString(string msg);
    public class DemoDelegate
{
        public DemoDelegate() 
        {
            ShowString ss = new ShowString(Message);
            //Message("Hello");
            //ss("Hello");

            ss += Talk;// static method
            ss += new DemoDelegate().WakeUp;// method 

            ss("Hello");// Message("Hello") + Talk("Hello")

            // anonymous function
            ShowString anonymousFunc = delegate (string msg)
            {

            };
            anonymousFunc("Xin Chao");
        }
        public static void Message(string s)
        {
            Console.WriteLine(s);
        }
        public static void Talk(string t)
        {
            Console.WriteLine(t);
        }
        public void WakeUp(string w)
        {
            Console.WriteLine(w);
        }
    }
}
