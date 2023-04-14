using System.Collections.Generic;
using T2207A;
using T2207A.assignment3;

public class Program
{
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

        VietNamCustomer customerVN = new VietNamCustomer();
        customerVN.Enter();
        ForeignCustomer foreignCustomer = new ForeignCustomer();
        foreignCustomer.Enter();
        customerVN.InfoCustomer();
        foreignCustomer.InfoCustomer();
        Console.WriteLine(customerVN.Payment());
        Console.WriteLine(foreignCustomer.Payment());


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
