using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai3
{
    class Program
    {
        static void Main(string[] args)
        {
            double x1, x2,x3, y1, y2,y3,P,S,Canh1,Canh2,Canh3;
            Console.Write("Nhap vao toa do Diem A:");
            x1 = double.Parse(Console.ReadLine());
            y1 = double.Parse(Console.ReadLine());
            Console.Write("Nhap vao toa do Diem B:");
            x2 = double.Parse(Console.ReadLine());
            y2 = double.Parse(Console.ReadLine());
            Console.Write("Nhap vao toa do Diem C:");
            x3 = double.Parse(Console.ReadLine());
            y3 = double.Parse(Console.ReadLine());

            Canh1 = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
            Canh2 = Math.Sqrt(Math.Pow(x3 - x2, 2) + Math.Pow(y3 - y2, 2));
            Canh3 = Math.Sqrt(Math.Pow(x3 - x1, 2) + Math.Pow(y3 - y1, 2));

            P = (Canh1 + Canh2 + Canh3) / 2;
            S = Math.Sqrt(P*(P - Canh1)*(P - Canh2)*(P - Canh3));

            Console.Write("Dien Tich Tam Giac:" + S);

            Console.ReadLine();
        }
    }
}
