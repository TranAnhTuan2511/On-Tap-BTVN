/*Chuong5_BT10
 * Name: TranAnhTuan
 * Date:
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chuong5_BT10
{
    class Program
    {
        static void Main(string[] args)
        {
            // khai bao bien
            int num = 0;

            //Input tao tam giac
            do
            {
                Console.Write("Nhap so dong ");
                int.TryParse(Console.ReadLine(), out num);
            }while(num <= 0);

            //Tao tam giac
            for (int i = 1; i <= num; i++)
            {
                //Tao khoang trang (n-1)
                for (int j = 1; j <= num - i; j++)
                {
                    Console.Write(" ");
                }
                //Tao khoang trang
                for (int k = 1; k <= i; k++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }
        }
    }
}
