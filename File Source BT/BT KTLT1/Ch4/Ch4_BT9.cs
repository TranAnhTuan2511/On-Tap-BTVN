/*chuong4_BT9
 * Name TranAnhTuan
 * Date 9/10/2022
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chuong4_BT9
{
    class Program
    {
        static void Main(string[] args)
        {
            //khai bao bien
            int x = 0;
            int y = 0;
            char toantu = '0';
            //Input nhap so nguyen vaao x,y de tinh
            Nhap: Console.WriteLine("nhap mot trong bon toan tu");
            char.TryParse(Console.ReadLine(), out toantu);
            Console.WriteLine("nhap vao x");
            int.TryParse(Console.ReadLine(), out x);
            Console.WriteLine("nhap vao y");
            int.TryParse(Console.ReadLine(), out y);

            switch(toantu)
            {
                case '+':
                Console.WriteLine($"ket qua la {x + y}");
                break;
                case '-':
                    Console.WriteLine($"ket qua la {x - y}");
                    break;
                case '*':
                    Console.WriteLine($"ket qua la {x * y}");
                    break;
                case '/':
                    if (y == 0)
                    {
                        Console.WriteLine("khong chia duoc");
                    }
                    else
                    {
                        Console.WriteLine($"chia duoc ket qua la {x/y}");
                    }
                    break;
                default:
                    Console.WriteLine("nhap sai yeu cau nhap lai");
                    goto Nhap;
                    break;
            }
        }
    }
}
