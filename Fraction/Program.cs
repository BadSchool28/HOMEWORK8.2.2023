using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fraction
{
    class Phanso
    {
        public int tuso { set; get; }
        public int mauso { set; get; }

        public void NhapPhanso()
        {
            Console.Write("Tu so = ");
            this.tuso = int.Parse(Console.ReadLine());
            Console.Write("mau so = ");
            do
                this.mauso = int.Parse(Console.ReadLine());
            while (this.mauso == 0);
        }
        public void InPhanso()
        {
            Console.Write("Phan so = " + tuso + "/" + mauso);
        }
        public Phanso congphanso(Phanso ph1, Phanso ph2)
        {
            Phanso ph3 = new Phanso();
            ph3.tuso = ph1.tuso * ph2.mauso + ph2.tuso * ph1.mauso;
            ph3.mauso = ph1.mauso * ph2.mauso;

            int uc = ucln(ph3.tuso, ph3.mauso);
            ph3.tuso = ph3.tuso / uc;
            ph3.mauso = ph3.mauso / uc;

            return ph3;

        }
        public Phanso truphanso(Phanso ph1, Phanso ph2)
        {
            Phanso ph3 = new Phanso();
            ph3.tuso = ph1.tuso * ph2.mauso - ph2.tuso * ph1.mauso;
            ph3.mauso = ph1.mauso * ph2.mauso;

            int uc = ucln(ph3.tuso, ph3.mauso);
            ph3.tuso = ph3.tuso / uc;
            ph3.mauso = ph3.mauso / uc;

            return ph3;

        }
        public Phanso nhanphanso(Phanso ph1, Phanso ph2)
        {
            Phanso ph3 = new Phanso();
            ph3.tuso = ph1.tuso * ph2.tuso;
            ph3.mauso = ph1.mauso * ph2.mauso;

            int uc = ucln(ph3.tuso, ph3.mauso);
            ph3.tuso = ph3.tuso / uc;
            ph3.mauso = ph3.mauso / uc;

            return ph3;

        }
        public Phanso chiaphanso(Phanso ph1, Phanso ph2)
        {
            Phanso ph3 = new Phanso();
            ph3.tuso = ph1.tuso * ph2.mauso;
            ph3.mauso = ph1.mauso * ph2.tuso;

            int uc = ucln(ph3.tuso, ph3.mauso);
            ph3.tuso = ph3.tuso / uc;
            ph3.mauso = ph3.mauso / uc;

            return ph3;

        }
        public int ucln(int a, int b)
        {
            int r = 1;
            while (r != 0)
            {
                r = a % b;
                a = b;
                b = r;
            }
            return a;
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Phanso p1 = new Phanso();
            Phanso p2 = new Phanso();
            Phanso p3 = new Phanso();

            Console.WriteLine("Nhap phan so 1");
            p1.NhapPhanso();

            Console.WriteLine("Nhap phan so 2");
            p2.NhapPhanso();

            p3 = p3.congphanso(p1, p2);
            Console.WriteLine("tong 2 phan so la");
            p3.InPhanso();

            p3 = p3.truphanso(p1, p2);
            Console.WriteLine("\nhieu 2 phan so la");
            p3.InPhanso();

            p3 = p3.nhanphanso(p1, p2);
            Console.WriteLine("\nnhan 2 phan so la");
            p3.InPhanso();

            p3 = p3.chiaphanso(p1, p2);
            Console.WriteLine("\nchia 2 phan so la");
            p3.InPhanso();



            Console.ReadKey();
        }
    }
}
