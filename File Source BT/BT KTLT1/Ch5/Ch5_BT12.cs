using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Chuong5_BT12
{
    class Program
    {
        static void Main(string[] args)
        {
            //khai bao bien
            int num = 0;

            //Nhap so nguyen to
            do
            {
                Console.Write("nhap so:");
                int.TryParse(Console.ReadLine(), out num);
            } while (num <= 0);

            //in các số nguyên tố từ 2 đến N
            int SoNguyenTo = 0;
            for (int i = 1; i <= num; i++)
            {
                if (num % i == 0)
                {
                    SoNguyenTo++;
                }
            }
            if (SoNguyenTo == 2)
            {
                Console.WriteLine($"{SoNguyenTo}");
            }
            else
            {
                Console.WriteLine("khong la so nguyen to"); 
            }
        }
    }
}
