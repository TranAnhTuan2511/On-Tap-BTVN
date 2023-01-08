/*Chuong5_BT7
 * Name: TranAnhTuan
 * Date:
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chuong5_BT7
{
    class Program
    {
        static void Main(string[] args)
        {
            //Khai bao bien
            int Numa = 0;
            int Numb = 0;

            //Nhap so nguyen vao va lap lai den khi nao a hoac b bang 0
            do
            {
                Console.WriteLine("nhap so nguyen a la ");
                int.TryParse(Console.ReadLine(), out Numa);
            } while (Numa <= 0);
            do
            {
                Console.WriteLine("nhap so nguyen b la ");
                int.TryParse(Console.ReadLine(), out Numb);
            } while (Numb <= 0);

            //tinh USCLN va BSCNN
            int USCLN = 0;
            int BSCNN = 0;
            int a = Numa;
            int b = Numb;
            while (a == 0 || b == 0)
            {
                if (a >= b)
                {
                    a = a / b;
                }
                else
                {
                    b = b / a;
                }
            }
                USCLN = a + b;
                BSCNN = (a * b) / USCLN;
            //ket qua la
            Console.WriteLine($"USCLN co ket qua {USCLN}");
            Console.WriteLine($"BSCNN co ket qua {BSCNN}");
        }
    }
}
