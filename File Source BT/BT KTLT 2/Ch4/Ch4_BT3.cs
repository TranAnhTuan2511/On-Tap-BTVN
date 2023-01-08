using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch4_BT3
{
    class Program
    {
        public struct HangHoa
        {
            public String maHang;
            public String tenHang;
            public int soLuongBan;
            public long donGia;

            public HangHoa (string maHang, string tenHang, int soLuongBan, long donGia)
            {
                this.maHang = maHang.Trim();
                this.tenHang = tenHang.Trim();
                this.soLuongBan = soLuongBan;
                this.donGia = donGia;
            }
            public string  XuatThongTin()
            {
                return $"{maHang}-{tenHang}-{soLuongBan}-{donGia}";
            }
        }
        static void Main(string[] args)
        {
            HangHoa[] arrH = DocFileVaoMangStruct(@"D:\HangHoa.txt");
            foreach (var item in arrH)
            {
                Console.WriteLine(item.XuatThongTin());
            }
        }
        //Doc file vao struct
        static HangHoa[] DocFileVaoMangStruct(string path)
        {
            //Doc so phan tu 
            int soPT = 0;
            HangHoa[] arrH = new HangHoa[0];
            try
            {
                StreamReader tR = new StreamReader(path);
                using (tR)
                {
                    //Doc so phan tu tu dong dau tien
                    soPT = int.Parse(tR.ReadLine());
                    //Doc so phan tu tung dong vao mang string
                    string[] arrStr=new string[soPT];
                    arrH=new HangHoa[soPT];
                    int i = 0;
                    while (!tR.EndOfStream)
                    {
                        arrStr[i++]=tR.ReadLine();
                        i++;
                    }
                    //Doc vao struct
                    for (i = 0; i < arrStr.Length; i++)
                    {
                        //Chuyen mang phan tu cua str thanh mang arrT
                        string[] arrT = arrStr[i].Split('#');
                        //Luu tung phan tu cua arrT vao struct arrH
                        arrH[i].maHang = arrT[0];
                        arrH[i].tenHang= arrT[1];
                        arrH[i].soLuongBan = int.Parse(arrT[2]);
                        arrH[i].donGia = int.Parse(arrT[3]);
                    }
                }
            }
            catch (Exception)
            {
                Console.WriteLine("khong tim thay file");
            }
            return arrH;
        }

    }
}
