using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T2207A.assignment4
{
    public class PhoneBook : Phone
    {
        public List<PhoneNumber> phoneList = new List<PhoneNumber>();
        public override void InsertPhone(String name, String phone)
        {
            PhoneNumber pn1 = new PhoneNumber(name);
            if ((phoneList != null) && (!phoneList.Any()))
            {
                phoneList.Add(pn1);
                pn1.Phones.Add(phone);
            }
            else
            {
                PhoneNumber pn = SearchPhone(name);
                if (pn != null)
                {
                    if (!pn.Phones.Contains(phone))
                    {
                        phoneList[phoneList.IndexOf(pn)].Phones.Add(phone);
                    }
                }
                else
                {
                    phoneList.Add(pn1);
                    pn1.Phones.Add(phone);
                }
            }
        }
        public override void RemovePhone(String name) 
        {
            if ((phoneList != null) && (!phoneList.Any()))
            {
                Console.WriteLine("Danh bạ trống !");
            }
            else
            {
                PhoneNumber pn = SearchPhone(name);
                if (pn != null)
                {
                    phoneList.Remove(pn);
                    Console.WriteLine("Đã xóa người dùng tên " + name);
                }
                else
                {
                    Console.WriteLine("Không tìm thấy người dùng tên " + name);
                }
            }
        }
        public override void UpdatePhone(String name, String oldPhone, String newPhone)
        {
            if ((phoneList != null) && (!phoneList.Any()))
            {
                Console.WriteLine("Danh bạ trống !");
            }
            else
            {
                PhoneNumber pn = SearchPhone(name);
                if (pn != null)
                {
                    if (pn.Phones.Contains(oldPhone))
                    {
                        int i = phoneList[phoneList.IndexOf(pn)].Phones.IndexOf(oldPhone);
                        phoneList[phoneList.IndexOf(pn)].Phones.Insert(i, newPhone);
                        Console.WriteLine("Đã thay số điện thoại thành công!");
                    }
                    else
                    {
                        Console.WriteLine("Không tìm thấy số điện thoại!");
                    }
                }
                else
                {
                    Console.WriteLine("Không tìm thấy người dùng tên " + name);
                }
            }
        }
        public override PhoneNumber SearchPhone(String name)
        {
            foreach (PhoneNumber pn in phoneList)
            {
                if (pn.Name.Contains(name)) return pn;
            }
            return null;
        }
        public override void SortPhone()
        {
            if ((phoneList != null) && (!phoneList.Any()))
            {
                Console.WriteLine("Danh bạ trống !");
            }
            else
            {
                phoneList.Sort(new PersonNameComparer());
            }
        }
    }
    class PersonNameComparer : IComparer<PhoneNumber>
    {
        public int Compare(PhoneNumber x, PhoneNumber y)
        {
            return x.Name.CompareTo(y.Name);
        }
    }
}
