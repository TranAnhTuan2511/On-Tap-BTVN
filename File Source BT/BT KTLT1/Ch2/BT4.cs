/* BaiTap_Chuong2
 * Name TranAnhTuan
 * Date 7/10/2022
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chuong2_BT4
{
    class Program
    {
        static void Main(string[] args)
        {
            double num1 = 0;
            double num2 = 0;
            double tam = 0;

            Console.WriteLine("nhap gia tri num1= ");
            num1 = double.Parse(Console.ReadLine());
            Console.WriteLine("nhap gia tri num2= ");
            num2 = double.Parse(Console.ReadLine());

            tam = num1;
            num1 = num2;
            num2 = tam;

            Console.WriteLine($"gia tri 1 la {num1}");
            Console.WriteLine($"gia tri 2 la {num2}");
        }
    }
}
