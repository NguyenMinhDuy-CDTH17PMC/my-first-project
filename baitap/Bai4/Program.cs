using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai4
{
    class Program
    {
        static void Main(string[] args)
        {
            int So;
            int chonn = 0;
            Console.Write("Nhap so ban can choi:");
            So = int.Parse(Console.ReadLine());
            if(So>=0&&So<=9)
            {
                switch(chonn)
                {
                    case 0: Console.Write("Khong");
                        break;
                    case 1: Console.Write("Mot");
                        break;
                    case 2: Console.Write("Hai");
                        break;
                    case 3: Console.Write("Ba");
                        break;
                    case 4: Console.Write("Bon");
                        break;
                    case 5: Console.Write("Nam");
                        break;
                    case 6: Console.Write("Sau");
                        break;
                    case 7: Console.Write("Bay");
                        break;
                    case 8: Console.Write("Tam");
                        break;
                    case 9: Console.Write("Chin");
                        break;
                }
            }
            else
            {
                Console.Write("Nhap so khong hop le!");
            }

            Console.ReadLine();
        }
    }
}
