/*chuong4_BT1
 * Name TranAnhTuan
 * Date 9/10/2022
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chuong4_BT10
{
    class Program
    {
        static void Main(string[] args)
        {
            //Khai bao bien
            double a = 0;
            double b = 0;
            double c = 0;
            double x = 0;
            double delta = 0;

            //Input nhap vao de tinh pt bac 2
            Console.WriteLine("tinh ax^2+bx+c=0");
            Console.WriteLine("nhap so a: ");
            double.TryParse(Console.ReadLine(), out a);
            Console.WriteLine("nhap so b: ");
            double.TryParse(Console.ReadLine(), out b);
            Console.WriteLine("nhap so c: ");
            double.TryParse(Console.ReadLine(), out c);

            delta = (b*b) - (4 * a * c);
            if (delta < 0)
            {
                Console.WriteLine("PT vo nghiem");
            }
            else if (delta == 0)
            {
                Console.WriteLine("PT vo so nghiem ");
            }
            else if (delta>=0)
            {
                Console.WriteLine($"PT co nghiem kep la {-b / (2 * a)}");
            }
            else  
                Console.WriteLine($"PT co hai nghiem phan biet x1={-b / (2 * a)} , x2={-b / (2 * a)}");
            
        }
    }
}
