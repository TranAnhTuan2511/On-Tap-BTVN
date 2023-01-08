/*chuong4_BT1
 * Name TranAnhTuan
 * Date 9/10/2022
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chuong4_BT1
{
    class Program
    {
        static void Main(string[] args)
        {
            int soNguyen1 = 0;
            int soNguyen2 = 0;
            int soNguyen3 = 0;
            int soNguyen4 = 0;
            int Max = 0;

            Console.WriteLine("nhap so nguyen 1 la: ");
            soNguyen1 = int.Parse(Console.ReadLine());
            Console.WriteLine("nhap so nguyen 2 la: ");
            soNguyen2 = int.Parse(Console.ReadLine());
            Console.WriteLine("nhap so nguyen 3 la: ");
            soNguyen3 = int.Parse(Console.ReadLine());
            Console.WriteLine("nhap so nguyen 4 la: ");
            soNguyen4 = int.Parse(Console.ReadLine());

            Max = soNguyen1;
            if (Max < soNguyen2) 
            { Max = soNguyen2; }
            if (Max < soNguyen3) 
            { Max = soNguyen3; }
            if (Max < soNguyen4) 
            { Max = soNguyen4; }
            Console.WriteLine($"so nguyen lon nhat la: {Max}");
        }
    }
}
