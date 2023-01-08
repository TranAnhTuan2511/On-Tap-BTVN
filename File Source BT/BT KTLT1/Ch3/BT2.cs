/* BaiTap_Chuong3
 * Name TranAnhTuan
 * Date 7/10/2022
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chuong3_BT2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Khai bao bien
            int doF = 0;
            int doC = 0;
            //Input
            Console.WriteLine("nhap do F: ");
            doF = int.Parse(Console.ReadLine());
            //Processing
            doC = ((doF - 32) * 5 / 9);
            //Output
            Console.WriteLine($"do C la {doC}");
        }
    }
}
