/*Chuong5_BT8
 * Name: TranAnhTuan
 * Date:
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chuong5_BT8
{
    class Program
    {
        static void Main(string[] args)
        {
            //khai bao bien
            int num = 0;

            //Input nhap so bang cuu chuong
            Console.Write("nhap so bang cuu chuong muon hien ");
            int.TryParse(Console.ReadLine(), out num);

            //Processing output nhap vao bang cuu chuong i = num
            for (int j = 1; j <= num; j++)
            {
                for (int i = 1; i <= num; i++)
                {
                    Console.WriteLine($"{j} * {i}= {i * j}");
                }
            }
        }
    }
}
