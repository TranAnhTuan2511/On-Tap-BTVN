/*
 * Name: Tran Anh Tuan
 */
using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace Ch4_BT2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] mangKQ = DocMangTuFile(@"C:\HangHoa.txt");
            Console.WriteLine("Doc mang tu file: ");
            //In mang ra man hinh
            foreach (var item in mangKQ)
            {
                Console.Write(item + " ");
            }
            //in tong so chan co trong mang
            int tong = 0;
            for (int i = 0; i < mangKQ.Length; i++)
            {
                if (i%2==0)
                {
                    tong += mangKQ[i];
                }
            }
            Console.WriteLine($"tong so chan la:{tong}");
            //in tong so nguyen to co trong mang
            //Kiem tra so nguyen to
            int soNT = 0;
            if (KiemTraSNT(soNT) == true)
            {
                Console.WriteLine("Day la so nguyen to");
            }
            else
            {
                Console.WriteLine("Day khong la so nguyen to");
            }
            //Tong so nguyen to 
            int[] arr = new int[soNT];
            Console.WriteLine($"tong so nguyen to co trong mang:{tongSNT(arr)}");
        }
        //Doc mang tu file
        static int[] DocMangTuFile(string path)
        {
            int[] arr = new int[0];
            try
            {
                StreamReader tR = new StreamReader(path);
                using (tR)
                {
                    while (!tR.EndOfStream)
                    {
                        //Them vao mang 1 phan tu
                        Array.Resize(ref arr, arr.Length + 1);
                        //Doc 1 dong tu fileva ghi vao cuoi mang
                        int.TryParse(tR.ReadLine(), out arr[arr.Length - 1]);
                    }
                    Console.WriteLine("Doc file thanh cong");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return arr;
        }
        //Kiem tra so nguyen to
        static bool KiemTraSNT(int soNT)
        {
            if (soNT<=1)
            {
                return false;
            }
            for (int i = 2; i < soNT; i++)
            {
                if (soNT%i==0)
                {
                    return false;
                }
            }
            return true;
        }
        //Tinh tong so nguyen to trong mang
        static int tongSNT(int[] arr)
        {
            int Tong = 0;
            foreach (var item in arr)
            {
                Tong += item;
            }
            return Tong;
        }

    }
}
