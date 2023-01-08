using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch1_BT7
{
    class Program
    {
        static void Main(string[] args)
        {
            //khai bao bien
            int soC = 0;
            int soD = 0;
            //Nhap phan tu ma tran hinh chu nhat
            Console.Write("nhap so dong: ");
            int.TryParse(Console.ReadLine(), out soD);
            Console.Write("nhap so dong: ");
            int.TryParse(Console.ReadLine(), out soC);
            //Tao mang chu nhat
            int[,] mang2D = TaoMangNgauNhien(soD, soC);
            //in mang
            InMang(mang2D);
            //Tao mang vuong
            int[,] mangV = TaoMangVuong(mang2D);
            InMang(mangV);

            //a)Tinh tich cot
            TinhTichCot(mangV);
            //b)tinh tich ham tinh cac phan tu nam tren duong cheo chinh, cheo phu cua ma tran vuong
                //b1)Tinh cheo chinh
                Console.WriteLine($"Tinh cheo chinh:{TinhCheoChinh(mangV)}");
                //b2)Tinh cheo phu
                Console.WriteLine($"Tinh cheo phu:{TinhCheoPhu(mangV)}");
            //c)Tinh tong so nguyen to co trong ma 
            Console.WriteLine($"Tong so nguyen to trong ma tran:{TongSoNguyenTo(mangV)}");
            //d)Tinh gia tri trung binh cua cac phan tu la so chan trong ma tran
            //e)Tim phan tu le lon nhat trong ma tran
            Console.WriteLine($"Vi tri le dau tien la: {TimViTriPhanTuLe(mangV)} ");
            int minLe;
            int vT = TimSoLeNhoNhat(mangV, out minLe);
            if (vT == -1)
            {
                Console.WriteLine("Khong co phan tu le nao trong mang");
            }
            else
            {
                Console.WriteLine($"Gia tri le nho nhat la [{vT / mangV.GetLength(1)}, {vT / mangV.GetLength(1)}]: {minLe}");
            }
        }
        //Tao mang 2D ngau nhien
        static int[,] TaoMangNgauNhien(int row, int col)
        {
            int[,] arr = new int[row, col];
            Random r = new Random();
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    arr[i, j] = r.Next(0, 10);
                }
            }
            return arr;
        }
        //In mang
        static void InMang (int[,] arr)
        {
            Console.WriteLine("**********");
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    Console.Write(arr[i,j]+" ");
                }
                Console.WriteLine();
            }
        }
        //Ham tao mang vuong
        static int[,] TaoMangVuong(int[,] arr)
        {
            //Lay kich thuoc
            int r = arr.GetLength(0);
            int c = arr.GetLength(1);
            int n = r < c ? r : c;
            //Khai bao mang
            int[,] mangV = new int[n, n];
            //Chep mang
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    mangV[i, j] = arr[i, j];
                }
            }
            return mangV;
        }
        //a) Tao mang tinh tich cot
        static void TinhTichCot (int[,] arr)
        {
            long tich = 1;
            for (int i = 0; i < arr.GetLength(1); i++)
            {
                tich = 1;
                for (int j = 0; j < arr.GetLength(0); j++)
                {
                    tich *= arr[j, i];
                }
                Console.WriteLine($"tinh cot {i} la: {tich} ");
            }
        }
        //b1)tao ham tinh tich ham tinh cac phan tu nam tren duong cheo chinh cua ma tran vuong
        static long TinhCheoChinh(int[,] arr)
        {
            long tich = 0;
            if (arr.GetLength(0)==arr.GetLength(1))
            {
                tich = 1;
                for (int i = 0; i < arr.GetLength(0); i++)
                {
                    for (int j = 0; j < arr.GetLength(1); j++)
                    {
                        if (i==j)
                        {
                            tich *= arr[i, j];
                        }
                    }
                }
            }
            return tich;
        }
        //b2)tao ham tinh tich ham tinh cac phan tu nam tren duong cheo phu cua ma tran vuong
        static long TinhCheoPhu(int[,] arr)
        {
            long tich = 0;
            if (arr.GetLength(0)==arr.GetLength(1))
            {
                tich = 1;
                for (int i = 0; i < arr.GetLength(0); i++)
                {
                    for (int j = 0; j < arr.GetLength(1); j++)
                    {
                        if (i+j==arr.GetLength(0)-1)
                        {
                            tich *= arr[i, j];
                        }
                    }
                }
            }
            return tich;
        }
        //c)Tinh tong so nguyen to co trong ma tran
            //Kiem tra so nguyen to
            static bool KiemTraSoNguyenTo(int n)
            {
                if (n <= 1)
                {
                    return false;
                }
                for (int i = 2; i < n; i++)
                {
                    if (n%i==0)
                    {
                        return false;
                    }
                }
                return true;
            }
            //Tinh tong so nguyen to
            static long TongSoNguyenTo(int[,] arr)
            {
                long tong = 0;
                foreach (var item in arr)
                {
                    if (KiemTraSoNguyenTo(item)==true)
                    {
                        tong += item;
                    }
                }
                return tong;
            }
        //d)Viet ham tinh gia tri trung binh cac phan tu cho chan trong ma tran

        //e)Viet ham tim phan tu le lon nhat trong ma tran
            static int TimViTriPhanTuLe(int[,] arr2D)
            {
                int vT = -1; //Khong co pt le trong mang
                int i = 0;
                foreach (var item in arr2D)
                {
                    if (item % 2 != 0)
                    {
                        vT = i;
                        return vT;
                    }
                    i++;
                }
                return vT;
            }
            //Tim phan tu le nho nhat
            static int TimSoLeNhoNhat(int[,] arr2D, out int minLe)
            {
                minLe = 0;
                int vTLe = -1;
                int soCot = arr2D.GetLength(1);
                int soDong = arr2D.GetLength(0);
                vTLe = TimViTriPhanTuLe(arr2D);
                if (vTLe >= 0)
                {
                    minLe = arr2D[vTLe / soCot, vTLe % soCot];
                    Console.WriteLine("So le dau tien" + minLe);
                    int i = 0;
                    foreach (var item in arr2D)
                    {
                        if (item % 2 != 0 && item < minLe)
                        {
                            minLe = item;
                            vTLe = i;
                        }
                        i++;
                    }
                }
                return vTLe; //Vi tri phan tu le nho nhat
             }
    }
}
