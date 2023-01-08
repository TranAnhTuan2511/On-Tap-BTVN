/* CH6_BT2
 * Name Tran Anh Tuan
 * Date
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch6_BT2
{
    class Program
    {
        static void Main(string[] args)
        {
            //khai bao bien
            int n = 0;
            n = NhapSoNguyenDuong(n);
            Console.WriteLine(n);
            //Menu Tinh Toan
            char Menu = '\0';
            Console.WriteLine("A. Tinh tong cac so le");
            Console.WriteLine("B. tinh tich cac boi so cua 3");
            Console.WriteLine("C. 1+1/2+1/3+.....+1/n-1");
            Console.WriteLine("D. 2*4*6*....2n");
            Console.WriteLine("E. N!=1*2*....*n");
        nhap: Console.WriteLine("lua chon cach tinh");
            char.TryParse(Console.ReadLine(), out Menu);

            //Tao lua chon
            switch (Menu)
            {
                //Tinh tong cac so le
                case 'A':
                case 'a':
                    long TongA = TongSoLe(n);
                    Console.WriteLine(TongA);
                    break;
                //Tich boi so cua 3 nho hon n
                case 'B':
                case 'b':
                    long TichB = TichBoiSo(n);
                    Console.WriteLine(TichB);
                    break;
                //1 + 1/2 + 1/3 + . . . + 1/n-1.
                case 'C':
                case 'c':
                    double TongC = TongCuaC(n);
                    Console.WriteLine(TongC);
                    break;
                //2 * 4 * 6 * … 2n
                case 'd':
                case 'D':
                    int TichD = TichCuaD(n);
                    Console.WriteLine(TichD);
                    break;
                //N! = 1 * 2 * . .  * n.
                case 'e':
                case 'E':
                    int GiaiThuaE = GiaiThuaCuaE(n);
                    Console.WriteLine(GiaiThuaE);
                    break;
                default:
                    Console.WriteLine("vui long nhap lai");
                    goto nhap;
                    break;
            }
        }
        //Ham A
               static long TongSoLe(int n)
        {
            long TongA = 0;
            for (int i = 1; i <= n; i+=2)
            {
                    TongA += i;
            }
            Console.WriteLine($"Tong A la:");
            return TongA;
        }
        //Ham B
        static long TichBoiSo(int n)
        {
            long TichB = 1;
            if (n<3)
            {
                TichB = 0;
            }
            for (int i = 3; i <= n; i+=3)
            {
                TichB *= i;
            }
            Console.WriteLine($"Tich B la:");
            return TichB;
        }
        //Ham C
        static double TongCuaC(int n)
        {
            double TongC = 0;
            for (int i = 1; i < n; i++)
            {
                TongC += 1.0 / i;
                Console.WriteLine($"{TongC}");
            }
            Console.WriteLine($"TongC la:");
            return TongC;
        }
        //Ham D
        static int TichCuaD(int n)
        {
            int TichD = 1;
            for (int i = 2; i <= 2 * n; i += 2)
            {
                TichD *= i;
            }
            Console.WriteLine("Tich Cua D la: ");
            return TichD;
        }
        //Ham E
        static int GiaiThuaCuaE(int n)
        {
            int GiaiThuaE = 1;
            for (int i = 1; i <= n; i++)
            {
                GiaiThuaE *= i;
            }
            Console.WriteLine("Giai thua cua E la: ");
            return GiaiThuaE;
        }
        //Nhap so nguyen duong
        static int NhapSoNguyenDuong(int n)
        {
            do
            {
                Console.Write("Nhap so nguyen la: ");
                int.TryParse(Console.ReadLine(), out n);
            } while (n <= 0);
            Console.WriteLine("In ra so nguyen la: ");
            return n;
        }
            
    }
}
