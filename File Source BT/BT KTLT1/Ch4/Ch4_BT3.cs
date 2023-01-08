/*chuong4_BT3
 * Name TranAnhTuan
 * Date 9/10/2022
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chuong4_BT3
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = 0;
            double b = 0;
            double x = 0;

            Console.WriteLine("tinh ax+b=0");
            Console.WriteLine("nhap so a: ");
            a = double.Parse(Console.ReadLine());
            Console.WriteLine("nhap so b: ");
            b = double.Parse(Console.ReadLine());

            if (a == 0)
            {
                if (b==0)
                {
                    Console.WriteLine("pt vo so nghiem");
                }
                else if (b>0)
                {
                    Console.WriteLine("pt vo nghiem");
                }
            }
            else 
            Console.WriteLine($"phuong trinh cua nghiem la {-b / a}");        
        }
    }
}
