/*Chuong5_BT3
 * Name: TranAnhTuan
 * Date:
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chuong5_BT3
{
    class Program
    {
        static void Main(string[] args)
        {
            //khai bao bien
            int n = 0;

            //nhap so duong
            do
            {
                Console.WriteLine("Nhap so nguyen");
                int.TryParse(Console.ReadLine(), out n);
            } while (n <= 0);

            //tinh
            int dem = 0;
            for (int i = 1; i <= n; i++)
            {
                if (n % i==0)
                {
                    dem++;
                }
            }
            if (dem==2)
            {
                Console.WriteLine($"la so nguyen to");
            }
            else
            {
                Console.WriteLine("khong la so nguyen to");
            }
        }
    }
}
