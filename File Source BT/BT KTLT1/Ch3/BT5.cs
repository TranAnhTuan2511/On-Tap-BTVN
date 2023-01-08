/* BaiTap_Chuong3
 * Name TranAnhTuan
 * Date 7/10/2022
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chuong3_BT5
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 0;
            int b = 0;

            Console.WriteLine("nhap so thu 1 = ");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("nhap so thu 2 = ");
            b = int.Parse(Console.ReadLine());

            Console.WriteLine(a > b ? $"so lon nhat la {a}" : $"so lon nhat la: {b}");
        }
    }
}
