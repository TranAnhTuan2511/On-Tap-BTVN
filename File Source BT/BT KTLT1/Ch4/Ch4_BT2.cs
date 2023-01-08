/*chuong4_BT2
 * Name TranAnhTuan
 * Date 9/10/2022
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chuong4_BT2
{
    class Program
    {
        static void Main(string[] args)
        {
            
            double DTB = 0;

            Console.WriteLine("diem trung binh cua ban la: ");
            DTB = double.Parse(Console.ReadLine());
       
            if (DTB<0 || DTB>10)
            {
                Console.WriteLine("diem khong hop le");
            }
            else if ( DTB < 3)
            {
                Console.WriteLine("hoc luc cua ban la kem ");
            }
            else if ( DTB < 5)
            {
                Console.WriteLine("hoc luc cua ban la yeu ");
            }
            else if (DTB < 6.5)
            {
                Console.WriteLine("hoc luc cua ban la TBkha");
            }
            else if (DTB < 8)
            {
                Console.WriteLine("hoc luc cua ban la Kha ");
            }
            else if (DTB < 9)
            {
                Console.WriteLine("hoc luc cua ban la Gioi");
            }
            else {Console.WriteLine("hoc luc cua ban la XuatSac");}

        }
    }
}
