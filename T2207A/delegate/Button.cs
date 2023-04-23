using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T2207A.Delegate
{
    public class Button
{
        public event ShowString onAction;
        public Button() 
        {
            onAction += DemoDelegate.Message;// ham nay tu cho vao khi khai bao
        }
}
}
