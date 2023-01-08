/*Chuong5_BT4
 * Name: TranAnhTuan
 * Date:
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chuong5_BT4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Khai bao bien
            int n = 0;

            //Nhap so nguyen
            do
            {
                Console.WriteLine("Nhap so nguyen ");
                int.TryParse(Console.ReadLine(), out n);
            } while (n <= 0);
            //kiem tra so chinh phuong
            bool Ketqua = false;
            for (int i = (int)Math.Sqrt(n); i <= Math.Sqrt(n); i++)
            {
                Console.WriteLine(i);
                if (i * i == n)
                {
                    Ketqua = true;
                    break;
                }
            }
            if (Ketqua=true)
            {
                Console.WriteLine($"{n} la so chinh phuong");
            }
            else
            {
                Console.WriteLine($"{n} khong la so chinh phuong");
            }
        }
    }
}
