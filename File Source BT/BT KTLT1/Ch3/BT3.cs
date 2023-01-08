/* BaiTap_Chuong3
 * Name TranAnhTuan
 * Date 7/10/2022
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chuong3_BT3
{
    class Program
    {
        static void Main(string[] args)
        {
            //khai bao bien
            int Math = 0;
            int Physical = 0;
            int Chemistry = 0;
            double DiemTrungBinhCong = 0;
            //Input
            Console.WriteLine("Nhap diem toan= ");
            Math = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhap diem ly= ");
            Physical = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhap diem hoa= ");
            Chemistry = int.Parse(Console.ReadLine());
            //Processing
            DiemTrungBinhCong = (Math + Physical + Chemistry) / 3.0;
            //OutPut
            Console.WriteLine($"diem trung binh la {DiemTrungBinhCong: 0.00}");
        }
    }
}
