/*Chuong5_BT5
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
    class program
    {
        static void Main(string[] args)
        {
            //khai bao bien
            int n = 0;

            //nhap so nguyen
            do
            {
                Console.WriteLine("nhap so nguyen");
                int.TryParse(Console.ReadLine(), out n);
            } while (n <= 0);
            //tinh so hoan hao
            int Ketqua = 0;
            for (int i = 1; i <= n; i++)
            {
                if (n % i == 0)
                {
                    Ketqua+=i;
                }
            }
            if (Ketqua-n==n)
            {
                Console.WriteLine($"{n} la so hoan hao");
            }
            else
            {
                Console.WriteLine($"{n} khong la so hoan hao");
            }
        }
    }
}