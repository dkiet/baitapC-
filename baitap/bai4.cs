using System;

namespace BaiTap3
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.Write("Nhap vao so A: ");
            float soA = Convert.ToSingle(Console.ReadLine());
            Console.Write("Nhap vao so B: ");
            float soB = Convert.ToSingle(Console.ReadLine());
            float soC = 0;
            soC = soA + soB;
            Console.Write("Tong cua " + soA + " va " + soB + " la " + soC);
            Console.ReadLine();
        }
    }
}

namespace Baitap4
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Cach giai pt bac nhat co dang: ax + b = 0");
            Console.Write("Nhap vao so a: ");
            float soa = Convert.ToSingle(Console.ReadLine());
            Console.Write("Nhap vao so b: ");
            float sob = Convert.ToSingle(Console.ReadLine());
            if (soa == 0 && sob == 0)
            {
                Console.WriteLine("Pt co vo so nghiem.");
            }
            if (soa == 0 && sob != 0)
            {
                Console.WriteLine("Pt vo nghiem.");
            }
            if (soa != 0)
            {
                Console.WriteLine("Pt co 1 nghiem duy nhat: x = " + ((-sob) / soa));
            }
        }
    }    }