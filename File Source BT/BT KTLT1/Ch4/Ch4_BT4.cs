/*chuong4_BT4
 * Name TranAnhTuan
 * Date 9/10/2022
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chuong4_BT4
{
    class Program
    {
        static void Main(string[] args)
        {
            //khai bao bien
            int num1 = 0;

            //Input: nhap so tu 1 den 100
            Nhap:  Console.WriteLine("nhap mot so: ");
            int.TryParse(Console.ReadLine(), out num1);

            //kiem tra xem co tu 1 den 100 khong
            if (num1<1 || num1>100)
            {
                Console.WriteLine("Vui long nhap lai: ");
                goto Nhap;
            }
            //Processing: tim so chan chia het cho 3            
            if ( num1 % 2 == 0 && num1 % 3 == 0)
            {
                Console.WriteLine("La so chan chia het cho ba");
            }

            else
            {
                Console.WriteLine("Khong thoa dieu kien");
            }

            Console.ReadKey();
        }
    }
}
