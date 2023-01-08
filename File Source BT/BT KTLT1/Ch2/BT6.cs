/* BaiTap_Chuong2
 * Name TranAnhTuan
 * Date 7/10/2022
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chuong2_BT6
{
    class Program
    {
        static void Main(string[] args)
        {
            double dola = 0;
            const double banganh = 0.8144;
            const double yen = 105.406;
            const double vietnamdong = 23160;
            double tientebanganh = 0;
            double tientenhat = 0;
            double tienteVN = 0;

            Console.WriteLine("nhap tien do la= ");
            dola = double.Parse(Console.ReadLine());

            tientebanganh = dola * banganh;
            tientenhat = dola * yen;
            tienteVN = dola * vietnamdong;
            Console.WriteLine($"tien te Anh doi ra la: {tientebanganh}");
            Console.WriteLine($"tien te Nhat doi ra la:{tientenhat}");
            Console.WriteLine($"tien te VN doi ra la:{tienteVN}");
        }
    }
}
