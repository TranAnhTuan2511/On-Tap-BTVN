/*
Ch1_BT1-2
Date:
Name: Tran Anh Tuan
*/
using System;

namespace Chuong1_BT1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Bai 1:
            int[,] array = TaoMang();

            //Goi ham in mang   
            InMang(array);

            //Goi ham chon co ngoi
            ChonMaChoNgoi(array);

            //Bai 2:
            //a) Tổng số chỗ ngồi còn trống trong rạp.
            Console.WriteLine($"Rap con trong {DemSoChoTrong(array)} cho");

            //b) Số lượng ghế trống từng hàng.
            int[] arrKQ = DemSoGheTrongTungHang(array);
            for (int i = 0; i < arrKQ.Length; i++)
            {
                Console.WriteLine($"Hang {i} co {arrKQ[i]} ghe trong");
            }

            //c) Số lượng ghế trống từng dãy.
            int[] arrkQ = DemSoChoTrongTungDay(array);
            for (int i = 0; i < arrkQ.Length; i++)
            {
                Console.WriteLine($"Day {i} co {arrkQ[i]} ghe trong");
            }

            //d) Số cặp ghế trống theo hàng
            int[] soCapGheTrong = DemSoCapGheTrongTungHang(array);
            for (int i = 0; i < soCapGheTrong.Length; i++)
            {
                Console.WriteLine($"Hang {i} co {soCapGheTrong[i]} cap ghe trong");
            }

            //e) Tìm hàng có nhiều ghế trống nhất
            Console.WriteLine($"Hang {TimHangCoNhieuGheTrongNhat(array)} co nhieu ghe trong nhat");

            //f) Tìm hàng đã hết chỗ trống
            int[] hangDaHetChoTrong = TimHangDaHetChoTrong(array);
            for (int i = 0; i < hangDaHetChoTrong.Length; i++)
            {
                if (hangDaHetChoTrong[i] != 0)
                {
                    Console.WriteLine($"Hang {i} da het ghe trong");
                }
            }

            //g) Kiểm tra tất cả các ghế ở ngoài biên được đặt hết hay chưa.
        }

        //Bai 2:
        //a) Tổng số chỗ ngồi còn trống trong rạp.
        static int DemSoChoTrong(int[,] arr)
        {
            int dem = 0;
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    if (arr[i, j] == 0)
                    {
                        dem++;
                    }
                }
            }
            return dem;
        }

        //b) Số lượng ghế trống từng hàng.
        static int[] DemSoGheTrongTungHang(int[,] arr)
        {
            int[] kQ = new int[arr.GetLength(0)];
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                int dem = 0;
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    if (arr[i, j] == 0)
                    {
                        dem++;
                    }
                }
                kQ[i] = dem;
            }
            return kQ;
        }

        //c) Số lượng ghế trống từng dãy.
        static int[] DemSoChoTrongTungDay(int[,] arr)
        {
            int[] kQ = new int[arr.GetLength(1)];
            for (int i = 0; i < arr.GetLength(1); i++)
            {
                int dem = 0;
                for (int j = 0; j < arr.GetLength(0); j++)
                {
                    if (arr[j, i] == 0)
                    {
                        dem++;
                    }
                }
                kQ[i] = dem;
            }
            return kQ;
        }

        //d) Số cặp ghế trống theo hàng
        static int[] DemSoCapGheTrongTungHang(int[,] arr)
        {
            int[] soCapGheTrong = new int[arr.GetLength(0)];
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                int dem = 0;
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    if (arr[i,j] == 0)
                    {
                        dem++;
                    }
                }
                soCapGheTrong[i] = dem / 2;
            }
            return soCapGheTrong;
        }

        //e) Tìm hàng có nhiều ghế trống nhất
        static int TimHangCoNhieuGheTrongNhat(int[,] arr)
        {
            int[] soGheTrong = DemSoGheTrongTungHang(arr);
            int max = 0;
            for (int i = 0; i < soGheTrong.Length; i++) 
            {
                if (soGheTrong[i] > max)
                {
                    max = i;
                }
            }
            return max;
        }
        //f) Tìm hàng đã hết chỗ trống
        static int[] TimHangDaHetChoTrong(int[,] arr)
        {
            int[] soGheTrong = DemSoGheTrongTungHang(arr);
            int[] hangHetChoTrong = new int[soGheTrong.Length];
            for (int i = 0; i < soGheTrong.Length; i++)
            {
                if (soGheTrong[i] == 0)
                {
                    hangHetChoTrong[i] = i;
                }
            }
            return hangHetChoTrong;
        }

        //g) Kiểm tra tất cả các ghế ở ngoài biên được đặt hết hay chưa.


        //Bai 1:
        //In mang
        static void InMang(int[,] arr)
        {
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    Console.Write(arr[i, j] + " ");
                }
                Console.WriteLine();
            }
        }

        //Tao mang
        static int[,] TaoMang()
        {
            //Nhap so hang ghe
            int n = 0;
            do
            {
                Console.Write("Nhap so hang ghe: ");
                int.TryParse(Console.ReadLine(), out n);
            } while (n <= 0);

            //Nhap so cho ngoi
            int m = 0;
            do
            {
                Console.Write("Nhap so cho ngoi: ");
                int.TryParse(Console.ReadLine(), out m);
            } while (m <= 0);

            //Tao mang
            int[,] arr = new int[n, m];
            Random rand = new Random();
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    arr[i, j] = rand.Next(0, 2);
                }
            }
            return arr;
        }

        //Kiem tra cho ngoi
        static bool KiemTraChoNgoi(int[,] arr)
        {
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    if (arr[i, j] == 0)
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        //Chon ma cho ngoi
        static bool ChonMaChoNgoi(int[,] arr)
        {
            if (KiemTraChoNgoi(arr) == false)
            {
                return false;
            }
            int soHang = 0;
            int soGhe = 0;
            do
            {
                //Nhap so hang muon chon   
                Console.Write("Nhap so hang muon chon: ");
                int.TryParse(Console.ReadLine(), out soHang);

                //Nhap so ghe muon chon
                Console.Write("Nhap so ghe: ");
                int.TryParse(Console.ReadLine(), out soGhe);

                if (arr[soHang, soGhe] != 0)
                {
                    Console.WriteLine("Vui long cho cho ngoi khac");
                }
            } while (arr[soHang, soGhe] != 0);
            arr[soHang, soGhe] = 1;
            Console.WriteLine("Da dat cho thanh cong");
            Console.WriteLine($"Cho ngoi cua ban: Hang {soHang}, Ghe{soGhe}");
            InMang(arr);
            return true;
        }
    }
}
