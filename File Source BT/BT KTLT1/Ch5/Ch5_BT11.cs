/*Chuong5_BT11
 * Name: TranAnhTuan
 * Date:
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chuong5_BT11
{
    class Program
    {
        static void Main(string[] args)
        {
            //Khai bao bien
            int n = 0;
            int x = 0;

            //Input
            Console.WriteLine("Nhap so nguyen: ");
            int.TryParse(Console.ReadLine(), out n);
            Console.WriteLine("Nhap so bat ky: ");
            int.TryParse(Console.ReadLine(), out x);
            //Menu
            char Menu = '\0';
            Console.WriteLine("a. S= 1 + x +x2 + x3 + ... + xn ");
            Console.WriteLine("b. S= 1 - x +x2 - x3 + ... (-1)nxn");
            char.TryParse(Console.ReadLine(), out Menu);

            switch (Menu)
            {
                //Tinh tong S(a)
                case 'A':
                case 'a':
                    double TongS1 = 0;
                    for (int i = 1; i <=n; i++)
                    {
                        TongS1 = 1+ n ^ i;
                    }
                    Console.WriteLine($"tong S la {TongS1}");
                    break;
                case 'B':
                case 'b':
                    double TongS2 = 0;
                    for (int i = 1; i <= n; i++)
                    {

                    }
                    break;
            }
        }
    }
}
