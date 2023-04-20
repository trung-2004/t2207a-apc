using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T2207A.assignment4
{
    public class PhoneNumber
    {
        private string name;
        private List<String> phones = new List<string>();

        public PhoneNumber()
        {

        }
        public PhoneNumber(string name)
        {
            this.name = name;
        }

        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }
        public List<string> Phones
        {
            get { return phones; }
            set { this.phones = value; }
        }
        public override string ToString()
        {
            return this.Name + " " + phones.Count;
        }
       
    }
}
