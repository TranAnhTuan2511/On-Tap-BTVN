using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cau1
{
    class Program
    {
        static void Main(string[] args)
        {
            int soDong = 0;
            //nhap so dong
            Console.WriteLine("nhap so dong: ");
            int.TryParse(Console.ReadLine(), out soDong);
            //1.ham tao mang zz ngau nhien
            int[][] mangZ = taoMangNgauNhien(soDong);
            //In mang zig zag
            InMangZigZag(mangZ);
            TimPhanTuNhoNhatTrenDong(mangZ);
                 
        }
        //1.tao mang zig zag ngau nhien
        static int[][] taoMangNgauNhien(int soDong)
        {
            int[][] arr = new int[soDong][];
            //tao ngau nhien
            Random r = new Random();
            //Tao gia tri cho tung dong
            for (int i = 0; i < arr.Length; i++)
            {
                //Cap phat bo nho, soPT = soDong + 1
                arr[i] = new int[i + 1];
                for (int j = 0; j <= i; j++)
                {
                    arr[i][j] = r.Next(0, 100);
                }
            }
            return arr;
        }
        //2.Ham in mang zig zag
        static void InMangZigZag(int[][] arr )
        {
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr[i].Length; j++)
                {
                    Console.Write(arr[i][j]+ " ");
                }
                Console.WriteLine();
            }
        }
        //3.Tim phan tu nho nhat tren moi dong
        static void TimPhanTuNhoNhatTrenDong(int[][] arr)
        {
            int min = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                min = arr[i][0];
                for (int j = 0; j < arr[i].Length; j++)
                {
                    if (min > arr[i][j])
                    {
                        min = arr[i][j];
                    }
                }
                Console.WriteLine($"Min dong thu {i} la: {min}");
            }
        }
    }
}
