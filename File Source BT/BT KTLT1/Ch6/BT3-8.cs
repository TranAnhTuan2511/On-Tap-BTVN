/* CH6_BT3-8
 * Name Tran Anh Tuan
 * Date
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch6_BT3
{
    class Program
    {
        static void Main(string[] args)
        {
            //khai bao bien
            int num = 0;            

            //Input
            do
            {
                Console.Write("Nhap so nguyen duong: ");
                int.TryParse(Console.ReadLine(), out num);
            } while (num <= 0);
            //Processing
            //Tinh cac uoc so
            int Tongcacuocso = TinhTongCacUocSo(num);
            Console.WriteLine(Tongcacuocso);
            //Kiem tra SNT
            long SoNguyenTo = Kiemtrasonguyento(num);
            Console.WriteLine(SoNguyenTo);
            if (SoNguyenTo==2)
            {
                Console.WriteLine("SNT");
            }
            else
            {
                Console.WriteLine("Khong la SNT");
            }
            //Kiem tra SCP
            bool SoChinhPhuong = Kiemtrasochinhphuong(num);
            Console.WriteLine(SoNguyenTo);
            if (SoChinhPhuong = true)
            {
                Console.WriteLine("SCP");
            }
            else
            {
                Console.WriteLine("Khong la SCP");
            }


            //Output

        }//Ket Thuc Ham
        //Hàm Tính tổng các ước số
        static int TinhTongCacUocSo(int n)
        {
            int Tongcacuocso = 0;
            for (int i = 1; i <= n; i++)
            {
                if (n%i==0)
                {
                    Tongcacuocso += i;
                }
            }
            Console.WriteLine($"Tong cac uoc so la:");
            return Tongcacuocso;
        }
        //Ham kiem tra so nguyen to
        static long Kiemtrasonguyento(int num)
        {
            long SoNguyenTo = 0;
            for (int i = 1; i <= num; i++)
            {
                if (num % i == 0)
                {
                    SoNguyenTo++;
                }
            }
            Console.WriteLine("Kiem tra so nguyen to: ");
            if (SoNguyenTo==2)
            {
                Console.WriteLine("1");
            }
            else
            {
                Console.WriteLine("0");
            }
            return SoNguyenTo;
        }
        //Ham kiem tra so chinh phuong
        static bool Kiemtrasochinhphuong(int num)
        {
            bool SoChinhPhuong = false;
            for (int i = (int)Math.Sqrt(num); i <= Math.Sqrt(num); i++)
            {
                Console.WriteLine(i);
                if (i * i == num)
                {
                    SoChinhPhuong = true;
                    break;
                }
            }
            return SoChinhPhuong;
        }
    }
}
