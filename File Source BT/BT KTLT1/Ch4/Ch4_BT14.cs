/*chuong4_BT14: keo,bua,bao
 * Name TranAnhTuan
 * Date 9/10/2022
 */
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chuong4_BT14
{
    class program
    {
        static void Main(string[] args)
        {
            //khai bao bien
            char n1 = '\0';
            char n2 = '\0';

            //Nhap tro choi keo bua bao
            Console.WriteLine("Nguoi choi 1: One-Two-Three ra cai gi ra cai ");
            char.TryParse(Console.ReadLine(), out n1);
            Console.WriteLine("Nguoi choi 2: One-Two-Three ra cai gi ra cai ");
            char.TryParse(Console.ReadLine(), out n2);

            //output
            switch(n1)
            {
                //keo
                case 'K':
                case 'k':
                    switch(n2)
                    {
                        case 'b':
                        case 'B':
                            Console.WriteLine("nguoi choi 2 thang");
                            break;
                        case 'k':
                        case 'K':
                            Console.WriteLine("ca hai Hoa");
                            break;
                        case 'g':
                        case 'G':
                            Console.WriteLine("nguoi choi 2 thua");
                            break ;
                    }
                    break;
                    //bua
                case 'b':
                case 'B':
                    switch(n2)
                    {
                        case 'k':
                        case 'K':
                            Console.WriteLine("nguoi choi 2 Thua");
                            break;
                        case 'b':
                        case 'B':
                            Console.WriteLine("ca hai hoa");
                            break;
                        case 'g':
                        case 'G':
                            Console.WriteLine("nguoi choi 2 Thang");
                            break;
                    }
                    break ;
                    //bao
                case 'g':
                case 'G':
                    switch(n2)
                    {
                        case 'k':
                        case 'K':
                            Console.WriteLine("nguoi choi 2 Thua");
                            break;
                        case 'b':
                        case 'B':
                            Console.WriteLine("nguoi choi 2 thang");
                            break;
                        case 'g':
                        case 'G':
                            Console.WriteLine("ca hai hoa");
                            break;
                    }
                    break ;
                default:
                    Console.WriteLine("Nhap sai roi");
                    break;
            }
        }
    }
}