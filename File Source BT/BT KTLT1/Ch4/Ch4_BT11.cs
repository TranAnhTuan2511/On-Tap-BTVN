/*chuong4_BT11
 * Name TranAnhTuan
 * Date 9/10/2022
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chuong4_BT11
{
    class program
    {
        static void Main(string[] args)
        {
            //Khai bao bien
            int Phanvuotdinhmuc = 0;
            int Mucdientieuthu = 0;
            int Chisomoi = 0;
            int Chisocu = 0;
            const int dinhmuc = 50;
            //Input
            Console.WriteLine("nhap chi so moi: ");
            int.TryParse(Console.ReadLine(), out Chisomoi);
            Console.WriteLine("nhap chi so cu: ");
            int.TryParse(Console.ReadLine(), out Chisocu);

            //Processing tinh tien dien
            Mucdientieuthu = Chisomoi - Chisocu;
            Phanvuotdinhmuc = Mucdientieuthu - 50;

            //Output
            Console.WriteLine($"Muc dien tieu thu la {Mucdientieuthu}");
            if (Phanvuotdinhmuc <= 0)
            {
                Console.WriteLine($"tien tra dinh muc la {Mucdientieuthu*1000}");
                Console.WriteLine($"tien tra vuot dinh muc la 0");
                Console.WriteLine($"tong tien la {Mucdientieuthu * 1000 + 0}");
            }
            else if (Phanvuotdinhmuc <= 50)
            {
                Console.WriteLine($"tien tra dinh muc la {50 * 1000}");
                Console.WriteLine($"tien tra vuot dinh muc la {Phanvuotdinhmuc*1500}");
                Console.WriteLine($"tong tien la {(50*1000)+(Phanvuotdinhmuc*1500)}");
            }
            else if (Phanvuotdinhmuc <= 100)
            {
                Console.WriteLine($"tien tra dinh muc la {50*1000}");
                Console.WriteLine($"tien tra vuot dinh muc la {(50*1500)+(Phanvuotdinhmuc-dinhmuc)*1800}");
                Console.WriteLine($"tong tien la {(50*1000)+(50*1500)+(Phanvuotdinhmuc-dinhmuc)}");
            }
            else
            {
                Console.WriteLine($"tien tra dinh muc la {Mucdientieuthu * 1000}");
                Console.WriteLine($"tien tra vuot dinh muc la {(50 * 1500) + (50*1800) + (Phanvuotdinhmuc - dinhmuc*2)}");
                Console.WriteLine($"tong tien la {(50 * 1000) + (50 * 1500) + (50*1800) + (Phanvuotdinhmuc - dinhmuc*2)}");
            }
        }
    }
}