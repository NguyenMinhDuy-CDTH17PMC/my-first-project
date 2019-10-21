using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace baitap
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c, tong;
            Console.Write("Nhap vao ba so can tinh:");
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            c = int.Parse(Console.ReadLine());
            tong = a + b + c;
            Console.Write("Tong cua ba so:" + tong);

            Console.ReadLine();
        }
    }
}
