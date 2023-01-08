/* BaiTap_Chuong3
 * Name TranAnhTuan
 * Date 7/10/2022
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chuong3_BT9
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 0;
            int b = 0;
            int c = 0;
            int SoDaoNguoc = 0;

            Console.WriteLine("nhap so nguyen duong = ");
            a = int.Parse(Console.ReadLine());

            b = a / 100;
            c = a % 100;
            SoDaoNguoc = c * 10 + b;

            Console.WriteLine($"so dao nguoc cua {a} la {SoDaoNguoc}");
        }
    }
}
