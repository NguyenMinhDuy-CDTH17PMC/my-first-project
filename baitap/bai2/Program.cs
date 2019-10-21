using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai2
{
    class Program
    {
        static void Main(string[] args)
        {
            double x1, x2, y1, y2, KhoangCach;
            Console.Write("Nhap vao toa do Diem A:");
            x1 = double.Parse(Console.ReadLine());
            y1 = double.Parse(Console.ReadLine());
            Console.Write("Nhap vao toa do Diem B:");
            x2 = double.Parse(Console.ReadLine());
            y2 = int.Parse(Console.ReadLine());

            KhoangCach =Math.Sqrt(Math.Pow(x2 - x1,2) + Math.Pow(y2 - y1,2));

            Console.Write("Khoang Cach giua hai diem:" + KhoangCach);

            Console.ReadLine();
        }
    }
}
