/* BaiTap_Chuong3
 * Name TranAnhTuan
 * Date 7/10/2022
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chuong3_BT1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Khai bao bien
            int a = 0;
            int b = 0;
            //Input
            Console.WriteLine("Nhap so nguyen a: ");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhap so nguyen b: ");
            b = int.Parse(Console.ReadLine());
            //Processing
            //Output
            Console.WriteLine($"a+b= {a + b}");
            Console.WriteLine($"a-b= {a - b}");
            Console.WriteLine($"a*b= {a * b}");
            Console.WriteLine($"a/b= {a / b}");
        }
    }
}
