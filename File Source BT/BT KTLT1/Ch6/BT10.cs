/* CH6_BT10: Viet chuong trinh kiem tra so hoan hao nho hon hoac bang N
 * Name Tran Anh Tuan
 * Date
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CH6_BT10
{
    class Program
    {
        static void Main(string[] args)
        {
            //kiem tra lon hon be hon
            //Khai bao bien
            int N = 0;
            //input nhap so nguyen duong
            N = NhapSoNguyenDuong();
            //Goi ham so sanh so hoan hao vs N
            Console.WriteLine($"Co {DemSoHoanHao(N)} so lon hon hoac bang {N}");
        }
        //Ham nhap so nguyen duong
        static int NhapSoNguyenDuong()
        {
            int num = 0;
            do
            {
                Console.Write("Nhap so nguyen duong: ");
                int.TryParse(Console.ReadLine(), out num);
            }while(num <= 1);
            return num;
        }
        //Hàm đếm số hoàn hảo nhỏ hơn N
        static int DemSoHoanHao(int N)
        {
            //tinh so hoan hao
            int demSoHoanHao = 0;
            for (int i = 1; i <= N; i++)
            {
                int Tong = 0;
                for (int j = 1; j <= i; j++)
                {
                    if (i%j==0)
                    {
                        Tong+=j;
                    }
                }
                if (Tong == i) 
                {
                    demSoHoanHao++;
                }
            }
            return demSoHoanHao;
        }

    }
}
