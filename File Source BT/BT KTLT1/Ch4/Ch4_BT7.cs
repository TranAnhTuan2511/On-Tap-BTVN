/*chuong4_BT7
 * Name TranAnhTuan
 * Date 9/10/2022
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chuong4_BT7
{
    class program
    {
        static void Main(string[] args)
        {
            //Khai bao bien Month can ktra quy
            int Month = 1;

            //Input nhap thang tu 1 den 12
            Console.WriteLine("nhap thang ");
            Month = int.Parse(Console.ReadLine());

            switch (Month)
            {
                case 1:
                case 2:
                case 3:
                    Console.WriteLine("Thang nay la quy 1");
                    break;
                case 4:
                case 5:
                case 6:
                    Console.WriteLine("Thang nay la quy 2");
                    break;
                //nếu người dùng nhập vào 7, 8, 9 thì thông báo thuộc quý 3
                case 7:
                case 8:
                case 9:
                    Console.WriteLine("Thang nay la quy 3");
                    break;
                //nếu người dùng nhập vào 10, 11, 12 thì thông báo thuộc quý 4
                case 10:
                case 11:
                case 12:
                    Console.WriteLine("Thang nay la quy 4");
                    break;
                //các trường hợp còn lại 
                default:
                    Console.WriteLine("nhap thang sai");
                    break;
            }
        }
    }
}
