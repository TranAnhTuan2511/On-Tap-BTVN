/* Ch7_BT1
 * Name Tran Anh Tuan
 * Date Tuan 7
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Ch7_BT1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Nhap so phan tu mang
            int n = 0;
            int SoPT = 0;
            Console.WriteLine("nhap so phan tu mang: ");
            int.TryParse(Console.ReadLine(), out SoPT);
            //a. Ham nhap mang
            int[] mangM = NhapMang(SoPT);
            Console.WriteLine(mangM);
            //b. Ham in ra man hinh
            InMang(mangM);
            //c. Xuat cac phan tu mang
            XuatSoChan(mangM);
            //D. Xuat cac so nguyen 
            InSNT(mangM);
            //e. Tinh trung binh cong
            TrungBinhCong(mangM);
            TinhTBCsochan(mangM);
            //f. dem so hoan thien
            DemSoHoanHao(mangM);
        }
        //Cau a: Ham nhap mang
        static int[] NhapMang(int SoPT)
        {
            //Khai bao mang co n phan tu
            int[] arr = new int[SoPT];

            //Nhap tung phan tu
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write($"Nhap phan tu mang thu {i}: ");
                int.TryParse(Console.ReadLine(), out arr[i]);
            }
            return arr;
        }
        //cau b: in ra mam hinh
        static void InMang(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();
        }
        //cau C xuat so chan trong mang
        static void XuatSoChan(int[] arrM)
        {
            Console.WriteLine("Cac phan tu la so chan: ");
            foreach (var item in arrM)
            {
                if (item % 2 ==0)
                {
                    Console.Write(item + " ");
                }
            }
            Console.WriteLine();
        }
        //Cau D xuat cac so la so nguyen to
        static bool KiemtraSNT(int n)
        {
            //bool laSNT=true; //n la so nguyen to
            if (n <= 1)
            {
                return false;
            }
            for (int i = 2; i < n; i++)
            {
                if (n % i == 0) 
                {
                    //LaSNT = false;
                    //break;
                    return false;
                }
            }
            return true;
        }
            //In so nguyen to trong mang
        static void InSNT(int[] arrM)
        {
            Console.WriteLine("So nguyen to trong mang la: ");
            foreach (var item in arrM)
            {
                if (KiemtraSNT(item) == true)
                {
                    Console.Write(item + " ");
                }
            }
            Console.WriteLine();
        }
        // cau E Tinh trung binh cong cac so trong mang
        static double TrungBinhCong(int[] arrM)
        {          
            double Tong = 0;
            //Tong cua mang
            foreach (var item in arrM)
            {
                Tong += item;
            }
            Console.WriteLine($"tinh TBC la: {Tong} ");
            return Tong / arrM.Length;
        }
        static double TinhTBCsochan(int[] arr)
        {
            double Tong = 0;
            int dem = 0;
            foreach (var item in arr)
            {
                if (item % 2 == 0)
                {
                    Tong += item;
                    dem++;
                }
            }
            Console.WriteLine($"Tinh TBC So chan: {Tong} ");
            return Tong / dem;
        }
        //Cau f dem so luong so hoan thien
        static bool kiemtrasohoanhao(int n) 
        {
            //dieu kien cho so hoan hao
            bool dem = true
            for (int i = 1; i <= n / 2; i++)
            {
                if (n % i == 0)
                {
                    dem += i;
                }
            }
        }
        static void DemSoHoanHao(int[] arr)
        {
            //in so hoan hao
            Console.WriteLine($"Dem so hoan hao co trong mang: ");
            foreach (var item in arr)
            {
                if (kiemtrasohoanhao(item)==true)
                {
                    Console.WriteLine(item + " ");
                }
            }
            Console.WriteLine();
        }
    }
}
