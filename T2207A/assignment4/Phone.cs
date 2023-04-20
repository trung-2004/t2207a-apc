using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T2207A.assignment4
{
    public abstract class Phone
    {
        public abstract void InsertPhone(String name, String phone);
        public abstract void RemovePhone(String name);
        public abstract void UpdatePhone(String name, String oldPhone, String newPhone);
        public abstract PhoneNumber SearchPhone(String name);
        public abstract void SortPhone();
    }
}
