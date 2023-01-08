/*chuong4_BT13
 * Name TranAnhTuan
 * Date 9/10/2022
 */
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chuong4_BT13
{
    class program
    {
        static void Main(string[] args)
        {
            int Month = 0;
            int Day = 0;

            //input nhap nam vs thang
            Console.WriteLine("nhap thang la");
            int.TryParse(Console.ReadLine(), out Month);
           
            //Processing Output
            switch (Month)
            {
                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                case 12:
                    Console.WriteLine("thang co 31 ngay");
                    break;
                case 2:
                    Console.WriteLine("thang nay co bao nhieu ngay");
                    Nhap:  int.TryParse(Console.ReadLine(), out Day);
                    if (Day == 29)
                    {
                        Console.WriteLine("thang nay la nam nhuan");
                    }
                    else if (Day == 28)
                    {
                        Console.WriteLine("thang nay la nam khong nhuan");
                    }
                    else
                    {
                        Console.WriteLine("nhap sai ngay");
                        goto case 2;
                    }
                    break;
                case 4:
                case 6:
                case 9:
                case 11:
                    Console.WriteLine("thang co 30 ngay");
                    break;
            }

        }
    }
}