using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T2207A
{
    internal class Fraction
    {
        public int tuSo;
        public int mauSo;
        public Fraction() 
        { 
        
        }

        public void Enter()
        {
            Console.WriteLine("Nhap tu so ");
            string nTuSo = Console.ReadLine();
            int ts = Convert.ToInt32(nTuSo);

            Console.WriteLine("Nhap mau so ");
            string nMauSo = Console.ReadLine();
            int ms = Convert.ToInt32(nMauSo);

            this.tuSo = ts;
            this.mauSo = ms;
        }

        public void Print()
        {
            Console.WriteLine(this.tuSo+" / "+this.mauSo);
        }

        public void Reduce()
        {
            int ucln = 1;
            int min = Math.Min(Math.Abs(this.tuSo), Math.Abs(this.mauSo));
            for (int i = min; i > 1; i--)
            {
                if (this.tuSo % i == 0 && this.mauSo % i == 0)
                {
                    ucln = i;
                    break;
                }
            }
            this.tuSo /= ucln;
            this.mauSo /= ucln;
        }

        public void Inverse()
        {
            if (tuSo != 0)
            {
                int tmp = tuSo;
                tuSo = mauSo;
                mauSo = tmp;
            }
        }

        public Fraction Add(Fraction sp2)
        {
            int ts = this.tuSo * sp2.mauSo + sp2.tuSo * this.mauSo;
            int ms = this.mauSo * sp2.mauSo;
            Fraction tong = new Fraction();
            tong.tuSo = ts;
            tong.mauSo = ms;
            return tong;
        }

        public Fraction Sub(Fraction sp2)
        {
            int ts = this.tuSo * sp2.mauSo - sp2.tuSo * this.mauSo;
            int ms = this.mauSo * sp2.mauSo;
            Fraction h = new Fraction();
            h.tuSo = ts;
            h.mauSo = ms;
            return h;
        }

        public Fraction Mul(Fraction sp2)
        {
            int ts = this.tuSo * sp2.tuSo;
            int ms = this.mauSo * sp2.mauSo;
            Fraction n = new Fraction();
            n.tuSo = ts;
            n.mauSo = ms;
            return n;
        }
       
        public Fraction Div(Fraction sp2)
        {
            if (sp2.tuSo != 0)
            {
                int tg = sp2.tuSo;
                sp2.tuSo = sp2.mauSo;
                sp2.mauSo = tg;

                int ts = this.tuSo * sp2.tuSo;
                int ms = this.mauSo * sp2.mauSo;
                Fraction c = new Fraction();
                c.tuSo = ts;
                c.mauSo = ms;
                return c;
            }

            return null;
        }

    }
}
