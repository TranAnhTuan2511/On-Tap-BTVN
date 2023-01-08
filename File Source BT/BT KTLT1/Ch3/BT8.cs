/* BaiTap_Chuong3
 * Name TranAnhTuan
 * Date 7/10/2022
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chuong3_BT8
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 0;

            Console.WriteLine("nhap gia tri num = ");
            num = int.Parse(Console.ReadLine());
 
            Console.WriteLine((num % 2 == 0) ? $"la so chan{++num} " : $"la so le {--num}");
        }
    }
}
