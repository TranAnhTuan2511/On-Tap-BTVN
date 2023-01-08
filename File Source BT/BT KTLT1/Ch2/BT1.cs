/* BaiTap_Chuong2
 * Name TranAnhTuan
 * Date 7/10/2022
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chuong2_BT1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Khai bao bien
            const double Pi = 3.141;
            double radius = 0;
            double perimeter = 0;
            double area = 0;

            Console.WriteLine("nhap ban kinh= ");
            radius = double.Parse(Console.ReadLine());

            perimeter = 2 * radius * Pi;
            area = Pi * radius * radius;

            Console.WriteLine($"chu vi la {perimeter}");
            Console.WriteLine($"dien tich la {area}");

        }
    }
}
