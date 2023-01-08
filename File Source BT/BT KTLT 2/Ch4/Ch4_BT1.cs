/* BT ch4
 * nam: Tran Anh Tuan
 */
using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch4_BT1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { 5, 6, 14, 56, 57 };
            string filePart = @"D:\TAT.txt";
            //Goi ham ghi file
            GhiMangVaoFile(arr, filePart);
        }
        //Ham nhap mang/tao random
        //Ham ghi mang xuong file
        static void GhiMangVaoFile(int[] arr, string filePart)
        {
            try
            {
                StreamWriter Tw = new StreamWriter(filePart);
                using (Tw)
                {
                    //Ghi so phan tu cua mang
                    Tw.Write("Co so phan tu: ",arr.Length);
                    foreach (var item in arr)
                    {
                        Tw.WriteLine(item);
                    }
                }
                Console.WriteLine("Ghi file thanh cong");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
