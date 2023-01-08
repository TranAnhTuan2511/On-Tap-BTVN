/*Chuong6_BT12: Dung ham de quy
* Name:Tran Anh Tuan
* Date:
*/
using System;
namespace Ch6_BT12
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 0;
            do
            {
                Console.Write("Nhap n: ");
                int.TryParse(Console.ReadLine(), out n);
            } while (n < 0);
            Console.WriteLine($"So Fbonacci thu {n} la: {TinhSoFibonacci(n)}");
            Console.WriteLine($"Day {n} so Fibonacci dau tien la:");
            In_N_SoFibonacciDauTien(n);
        }
        //Tinh so Fibinacci thu n dung de quy
        static int TinhSoFibonacci(int n)
        {
            if (n <= 1)
                return 1;
            return TinhSoFibonacci(n - 2) + TinhSoFibonacci(n - 1);
        }
        //In n so Fibonacci dau tien
        static void In_N_SoFibonacciDauTien(int n)
        {
            for (int i = 0; i < n; i++)
            {
                Console.Write(TinhSoFibonacci(i) + " ");
            }
        }
    }
}