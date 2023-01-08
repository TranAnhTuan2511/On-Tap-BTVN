/*chuong4_BT8
 * Name TranAnhTuan
 * Date 9/10/2022
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chuong4_BT8
{
    class Program
    {
        static void Main(string[] args)
        {
            Char color= '0';

            //Input nhap mau de nhan biet
            Console.WriteLine("nhap mau ");
            color = char.Parse(Console.ReadLine());

            switch(color)
            {
                case 'R':
                case 'r':
                    Console.WriteLine("la mau do(red)");
                    break;
                case 'G':
                case 'g':
                    Console.WriteLine("la mau xanh(green)");
                    break;
                case 'B':
                case 'b':
                    Console.WriteLine("la mau xanh(blue)");
                    break;
                default:
                    Console.WriteLine("la mau den(black)");
                    break;
            }
        }
    }
}
