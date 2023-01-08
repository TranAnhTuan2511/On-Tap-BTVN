/* 
 * Name: Tran Anh Tuan
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;

namespace Ch3_BT1
{
    class Program
    {
        //Khai bao struct
        public struct GoiCuoc
        {
            string tenGoi;
            int chuKyGoi;
            long giaGoi;
            bool vuotGoi;

            public GoiCuoc(string tenGoi, long giaGoi, bool vuotGoi) : this()
            {
                this.tenGoi = tenGoi;
                this.giaGoi = giaGoi;
                this.vuotGoi = vuotGoi;
            }

            public GoiCuoc(string tenGoi, int chuKyGoi, long giaGoi, bool vuotGoi)
            {
                this.tenGoi = tenGoi.Trim();
                this.chuKyGoi = (this.tenGoi[this.tenGoi.Length - 1] - 48)*30;
                this.giaGoi = giaGoi;
                this.vuotGoi= vuotGoi;
            }
            public string XuatThongTin()
            {
                return $"{tenGoi} - {chuKyGoi} - {giaGoi} - {vuotGoi} ";
            }
        }
        static void Main(string[] args)
        {
            //Nhap 1 goi cuoc
            //GoiCuoc gC1 = NhapGoiCuoc();
            //Console.WriteLine(gC1.XuatThongTin());
            //Nhap mang cuoc goi
            int SoPT = 0;
            do
            {
                Console.WriteLine("Nhap so phan tu: ");
            }while(int.TryParse(Console.ReadLine(), out SoPT)==false);
            GoiCuoc[] arrGC = NhapMangGoiCuoc(SoPT);
            //In Mang
            Console.ForegroundColor = ConsoleColor.Blue;
            InMangGoiCuoc(arrGC);
        }
        //Ham nhap 1 cuoc goi
        static GoiCuoc NhapGoiCuoc()
        {
            string tenGoi = "";
            long giaGoi = 0;
            bool vuotGoi = false;
            //Nhap ten: toi da 10 ky tu, ky tu cuoi la so
            do
            {
                Console.Write("Nhap ten goi: ");
                tenGoi = Console.ReadLine();
            } while (tenGoi.Length > 10 || tenGoi[tenGoi.Length - 1] < '0' || tenGoi[tenGoi.Length - 1] > '9'==false);
            Console.Write("Nhap gia goi: ");
            giaGoi=long.Parse(Console.ReadLine());
            Console.Write("Nhap vuot goi: ");
            vuotGoi=bool.Parse(Console.ReadLine());
            return new GoiCuoc(tenGoi, giaGoi, vuotGoi);
        }
        //Nhap mang cuoc goi
        static GoiCuoc[] NhapMangGoiCuoc(int SoPT)
        {
            GoiCuoc[] arr = new GoiCuoc[SoPT];
            for (int i = 0; i < SoPT; i++)
            {
                arr[i] = NhapGoiCuoc();
            }
            return arr;
        }
        //In mang goi cuoc
        static void InMangGoiCuoc(GoiCuoc[] arr)
        {
            foreach (var item in arr)
            {
                Console.WriteLine(item.XuatThongTin());
            }
        }
    }
}
