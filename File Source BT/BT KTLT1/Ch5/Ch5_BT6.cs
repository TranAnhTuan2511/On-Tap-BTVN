/*Chuong5_BT6
 * Name: TranAnhTuan
 * Date:
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chuong5_BT6
{
    class Program
    {
        static void Main(string[] args)
        {
            //Khai bao bien
            int n = 0;

            //Qua trinh tinh day fibonaci
            do
            {
                Console.WriteLine("Nhap n ");
                int.TryParse(Console.ReadLine(), out n);
            } while (n < 0);
            //tinh day fibonaci thu n
            int ft = 1;
            int fs = 1;
            int fn = 1;
            //tinh fn
            for (int i = 1; i < n; i++)
            {
                //tinh fn
                fn = fs + ft;
                //du lieu cho vong lap moi
                ft = fs;
                fs = fn;
            }
            Console.WriteLine($"so thu {n} trong day fibonaci la {fn}");
        }
    }
}
