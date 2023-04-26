using System.Collections.Generic;
using T2207A;
using T2207A.assignment3;
using T2207A.assignment4;
using T2207A.assignment5;
using T2207A.assignment6;

public class Program
{
    public static void Main2(string[] args)
    {
        Thread t = new Thread(DemoRun);// tham so la 1 function
        t.IsBackground = true;
        t.Start("Heloo");// truyen tham so thi truyen vao ham Start()
        for (int i = 0; i < 20; i++)
        {
            Console.WriteLine("Main i = " + i);
            try
            {
                Thread.Sleep(1000);
            }
            catch (Exception e)
            {

            }
        }
    }
    static void DemoRun(object o)// chi nhan parameter la obj
    {
        string s = (string)o;// ep kieu
        for (int i = 0; i < 40; i++)
        {
            lock (s)
            {
                Console.WriteLine(s + " i = "+i);
            }
            //Console.WriteLine(o+" i = "+i);
            try
            {
                Thread.Sleep(1000);
            } catch (Exception e)
            {

            }
        }
    }
    public static void Main(string[] args)
    {
        /*Console.WriteLine("Hello World");// print
        int x = 10;
        string s = "T2207A";
        double pi = 3.14159;

        if (x > 10)
        {
            x--;
        }
        else
        {
            x++;
        }

        int[] arr = new int[5];// array
        arr[0] = 1;
        arr[1] = 22;
        arr[2] = 13;
        arr[3] = 64;
        arr[4] = -5;

        foreach (int i in arr)
        {
            Console.WriteLine(i);
        }

        string cdm = Console.ReadLine();// nhap gia tri tu ban phim
        Console.WriteLine("Chuoi vua nhap " + cdm);

        string cmd2 = Console.ReadLine();
        int n = Convert.ToInt32(cmd2);
        Console.WriteLine("So vua nhap la: " + cmd2);

        // nhap 1 số và kiểm tra số đó có phải số nguyên tố hay không

        Console.WriteLine("Hay nhap so tu ban phim ");
        Console.WriteLine("n = ");
        string cmd3 = Console.ReadLine();
        int m = Convert.ToInt32(cmd3);
        if (isPrimed(m))
        {
            Console.WriteLine("So " + m + " la so nguyen to!");
        }
        else
        {
            Console.WriteLine("\nSo " + m + " khong la so nguyen to");
        }

        // List 

        List<int> list = new List<int>();
        list.Add(1);
        list.Add(7);
        list.Add(-6);
        list.Add(24);
        list.ForEach(i => Console.WriteLine(i));

        Student st = new Student();
        st.Run();
        st.Lean();*/

        /*Fraction x1 = new Fraction();
        Fraction x2 = new Fraction();
        Fraction x3 = new Fraction();

        x1.Enter();
        x2.Enter();
        x1.Print();
        x2.Print();

        x3 = x1.Add(x2);
        x3.Reduce();
        x3.Print();*/

        /*Student st = new Student();
        st.Lean();
        st.Name = "Nguyen Van An";
        st.Age = 18;
        st.Email = "annv@gmail.com";
        Console.WriteLine(st.Name);
        Console.WriteLine(st.Age);
        Console.WriteLine(st.Email);*/

        /*VietNamCustomer customerVN = new VietNamCustomer();
        customerVN.Enter();
        ForeignCustomer foreignCustomer = new ForeignCustomer();
        foreignCustomer.Enter();
        customerVN.InfoCustomer();
        foreignCustomer.InfoCustomer();
        Console.WriteLine(customerVN.Payment());
        Console.WriteLine(foreignCustomer.Payment());*/

        /*Human h = new Human();
        Human h2 = new Human() { Telephone = "0987654"};

        h.family[0] = "Nguyen Duc Anh";
        Console.WriteLine(h.family[0]);

        h2[0] = "Dao Nhat Tan";

        List<string> list = new List<string>();*/

        // Car car = new Car();// trong C# ko co anonymous class

        /*PhoneBook list = new PhoneBook();
        list.InsertPhone("Trung", "0359080256");
        list.InsertPhone("Hieu", "0456837352");
        list.InsertPhone("Hiep", "039474633");
        list.InsertPhone("Duc", "0337645332");
        list.InsertPhone("Trung", "037462854");
        
        for (int i = 0; i< list.phoneList.Count; i++)
        {
            Console.WriteLine(list.phoneList[i].ToString());
        }

        list.SortPhone();


        for (int i = 0; i < list.phoneList.Count; i++)
        {
            Console.WriteLine(list.phoneList[i].ToString());
        }*/
        /*News n = new News();
        Console.WriteLine("Nhap id: ");
        string cmd1 = Console.ReadLine();
        n.Id = Convert.ToInt32(cmd1);
        Console.WriteLine("Nhap ten: ");
        n.Title = Console.ReadLine();
        Console.WriteLine("Nhap ngay xuat ban: ");
        n.PublishDate = Console.ReadLine();
        Console.WriteLine("Nhap ten tac gia: ");
        n.Author = Console.ReadLine();
        Console.WriteLine("Nhap noi dung: ");
        n.Content = Console.ReadLine();

        for (int i = 0; i < n.RateList.Length; i++)
        {
            Console.WriteLine("Nhap vao gia tri cho phan tu thu " + (i + 1) + ": ");
            n.RateList[i] = Convert.ToInt32(Console.ReadLine());
        }
        n.Calculate();
        n.Display();*/
        ManagerStudent quanLySinhVien = new ManagerStudent();

        while (true)
        {
            Console.WriteLine("\nCHUONG TRINH QUAN LY SINH VIEN C#");
            Console.WriteLine("*************************MENU**************************");
            Console.WriteLine("**  1. Them sinh vien.                               **");
            Console.WriteLine("**  2. Cap nhat thong tin sinh vien boi ID.          **");
            Console.WriteLine("**  3. Xoa sinh vien boi ID.                         **");
            Console.WriteLine("**  4. Tim kiem sinh vien theo ten.                  **");
            Console.WriteLine("**  5. Sap xep sinh vien theo diem trung binh (GPA). **");
            Console.WriteLine("**  6. Sap xep sinh vien theo ten.                   **");
            Console.WriteLine("**  7. Sap xep sinh vien theo ID.                    **");
            Console.WriteLine("**  8. Hien thi danh sach sinh vien.                 **");
            Console.WriteLine("**  0. Thoat                                         **");
            Console.WriteLine("*******************************************************");
            Console.Write("Nhap tuy chon: ");
            int key = Convert.ToInt32(Console.ReadLine());
            switch (key)
            {
                case 1:
                    Console.WriteLine("\n1. Them sinh vien.");
                    quanLySinhVien.AddStudent();
                    Console.WriteLine("\nThem sinh vien thanh cong!");
                    break;
                case 2:
                    if (quanLySinhVien.CountStudent() > 0)
                    {
                        int id;
                        Console.WriteLine("\n2. Cap nhat thong tin sinh vien. ");
                        Console.Write("\nNhap ID: ");
                        id = Convert.ToInt32(Console.ReadLine());
                        quanLySinhVien.UpdateStudent(id);
                    }
                    else
                    {
                        Console.WriteLine("\nSanh sach sinh vien trong!");
                    }
                    break;
                case 3:
                    if (quanLySinhVien.CountStudent() > 0)
                    {
                        int id;
                        Console.WriteLine("\n3. Xoa sinh vien.");
                        Console.Write("\nNhap ID: ");
                        id = Convert.ToInt32(Console.ReadLine());
                        quanLySinhVien.DeleteStudent(id);
                    }
                    else
                    {
                        Console.WriteLine("\nSanh sach sinh vien trong!");
                    }
                    break;
                case 4:
                    if (quanLySinhVien.CountStudent() > 0)
                    {
                        Console.WriteLine("\n4. Tim kiem sinh vien theo ten.");
                        Console.Write("\nNhap ten de tim kiem: ");
                        string name = Convert.ToString(Console.ReadLine());
                        List<Student> searchResult = quanLySinhVien.FindStudentByName(name);
                        quanLySinhVien.ShowStudent(searchResult);
                    }
                    else
                    {
                        Console.WriteLine("\nSanh sach sinh vien trong!");
                    }
                    break;
                case 5:
                    if (quanLySinhVien.CountStudent() > 0)
                    {
                        Console.WriteLine("\n5. Sap xep sinh vien theo diem trung binh (GPA).");
                        quanLySinhVien.SortStudentByMediumScore();
                        quanLySinhVien.ShowStudent(quanLySinhVien.getListSinhVien());
                    }
                    else
                    {
                        Console.WriteLine("\nSanh sach sinh vien trong!");
                    }
                    break;
                case 6:
                    if (quanLySinhVien.CountStudent() > 0)
                    {
                        Console.WriteLine("\n6. Sap xep sinh vien theo ten.");
                        quanLySinhVien.SortStudentByName();
                        quanLySinhVien.ShowStudent(quanLySinhVien.getListSinhVien());
                    }
                    else
                    {
                        Console.WriteLine("\nSanh sach sinh vien trong!");
                    }
                    break;
                case 7:
                    if (quanLySinhVien.CountStudent() > 0)
                    {
                        Console.WriteLine("\n6. Sap xep sinh vien theo ID.");
                        quanLySinhVien.SortStudentByID();
                        quanLySinhVien.ShowStudent(quanLySinhVien.getListSinhVien());
                    }
                    else
                    {
                        Console.WriteLine("\nSanh sach sinh vien trong!");
                    }
                    break;
                case 8:
                    if (quanLySinhVien.CountStudent() > 0)
                    {
                        Console.WriteLine("\n7. Hien thi danh sach sinh vien.");
                        quanLySinhVien.ShowStudent(quanLySinhVien.getListSinhVien());
                    }
                    else
                    {
                        Console.WriteLine("\nSanh sach sinh vien trong!");
                    }
                    break;
                case 0:
                    Console.WriteLine("\nBan da chon thoat chuong trinh!");
                    return;
                default: 
                    Console.WriteLine("\nHay chon chuc nang trong hop menu.");
                    break;
            }

        }
    }
    public static Boolean isPrimed(int m)
    {
        int dem = 0;
        if (m < 2)
        {
            return false;
        }
        else
        {
            for (int i = 1; i <= m; i++)
            {
                if (m % i == 0)//kiem tra uoc cua N 
                {
                    dem += 1;//dem so luong uoc cua N
                }
            }
            if (dem == 2)//neu N có 2 uoc thì N la so nguyen to
            {
                return true;
            }
            else
            {//nguoc lai N khong phai so nguyen to
                return false;
            }
        }
    }
}
