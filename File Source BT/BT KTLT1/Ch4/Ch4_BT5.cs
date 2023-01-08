/*chuong4_BT5
 * Name TranAnhTuan
 * Date 9/10/2022
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chuong4_BT5
{
    class Program
    {
        static void Main(string[] args)
        {
            //Khai bao bien

            uint H = 0;
            uint M = 0;
            uint S = 0;
            uint Splus = 0; //So giay cong them
            uint Tong = 0;
            uint H2 = 0;
            uint M2 = 0;
            uint S2 = 0;
            //Input / Processing

            Console.Write("Hay nhap so gio: ");
            H = uint.Parse(Console.ReadLine());
            Console.Write("Hay nhap so phut: ");
            M = uint.Parse(Console.ReadLine());
            Console.Write("Hay nhap so giay: ");
            S = uint.Parse(Console.ReadLine());
            Console.Write("Hay nhap so giay them vao: ");
            Splus = uint.Parse(Console.ReadLine());

            Console.WriteLine($"So gio phut giay ban dau cua ban: {H:00}:{M:00}:{S:00}");

            Tong = (H * 3600) + (M * 60) + S + Splus;

            H2 = Tong / 3600;
            M2 = Tong % 3600 / 60;
            S2 = Tong % 3600 % 60;


            Console.WriteLine($"So gio phut giay sau khi cong them giay la: {H2:00}:{M2:00}:{S2:00}");
        }
    }
}
