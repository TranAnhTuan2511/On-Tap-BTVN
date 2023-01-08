/* BaiTap_Chuong3
 * Name TranAnhTuan
 * Date 7/10/2022
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chuong3_BT10
{
    class Program
    {
        static void Main(string[] args)
        {
            //Khai bao bien
            int x1 = 0;
            int y1 = 0;
            int x2 = 0;
            int y2 = 0;
            int KhoangCach = 0;

            Console.WriteLine("nhap toa do x1= ");
            x1 = int.Parse(Console.ReadLine());
            Console.WriteLine("nhap toa do y1= ");
            y1 = int.Parse(Console.ReadLine());
            Console.WriteLine("nhap toa do x2= ");
            x2 = int.Parse(Console.ReadLine());
            Console.WriteLine("nhap toa do y2= ");
            y2 = int.Parse(Console.ReadLine());

            Console.WriteLine($"khoang cach giua hai diem la {Math.Sqrt((y2-y1)^2 +(x2-x1)^2)}");
        }
    }
}
