/* BaiTap_Chuong3
 * Name TranAnhTuan
 * Date 7/10/2022
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chuong3_BT4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Khai bao bien
            int a = 0;
            //Input
            Console.WriteLine("nhap so mot so nguyen duong = ");
            a = int.Parse(Console.ReadLine());

            Console.WriteLine((a % 2 == 0) ? "la so chan" : "la so le");
        }
    }
}
