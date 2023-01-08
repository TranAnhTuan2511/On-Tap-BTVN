/* BaiTap_Chuong3
 * Name TranAnhTuan
 * Date 7/10/2022
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chuong3_BT7
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 0;
            int gio = 0;
            int phut = 0;
            int giay = 0;

            Console.WriteLine("nhap giay can doi = ");
            a = int.Parse(Console.ReadLine());

            gio = a / 3600;
            phut = a % 3600 / 60;
            giay = a % 3600 % 60;

            Console.WriteLine($"doi ra = {gio:00} : {phut:00} : {giay:00}");
        }
    }
}
