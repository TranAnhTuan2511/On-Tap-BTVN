/* BaiTap_Chuong2
 * Name TranAnhTuan
 * Date 7/10/2022
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chuong2_BT2
{
    class Program
    {
        static void Main(string[] args)
        {
            double sale1 = 0;
            double sale2 = 0;
            double totalsale = 0;
            double commission = 0;
            double commissionrate = 0;

            Console.WriteLine("nhap gia mon 1= ");
            sale1 = double.Parse(Console.ReadLine());
            Console.WriteLine("nhap gia mon 2= ");
            sale2 = double.Parse(Console.ReadLine());
            Console.WriteLine("nhap ti le hoa hong= ");
            commissionrate = double.Parse(Console.ReadLine());

            totalsale = sale1 + sale2;
            commission = totalsale * commissionrate;

            Console.WriteLine($"tien bo la {commission}");
        }
    }
}
