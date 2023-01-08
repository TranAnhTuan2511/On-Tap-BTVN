using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Ch3_BT2
{
    class Program
    {
        public struct Viettel3G
        {
            public string tenGoi;
            public int chuKyGoi;
            public long giaGoi;
            public bool vuotGoi;

            public Viettel3G(string tenGoi, long giaGoi, bool vuotGoi) : this()
            {
                this.tenGoi = tenGoi;
                this.giaGoi = giaGoi;
                this.vuotGoi = vuotGoi;
            }
            public Viettel3G(string tenGoi, int chuKyGoi, long giaGoi, bool vuotGoi)
            {
                this.tenGoi = tenGoi.Trim();
                this.chuKyGoi = (this.tenGoi[this.tenGoi.Length - 1] - 48)*30;
                this.giaGoi = giaGoi;
                this.vuotGoi = vuotGoi;
            }
            public string XuatThongTin()
            {
                return $"{tenGoi} - {chuKyGoi} - {giaGoi} - {vuotGoi} ";
            }
        }
        public struct ThueBao
        {
            public string hoTen;
            public string soCMND;
            public Viettel3G viettel3G;

            public ThueBao(string hoTen, string soCMND) : this()
            {
                this.hoTen = hoTen;
                this.soCMND = soCMND;
            }

            public ThueBao(string hoTen, string soCMND, Viettel3G viettel3G)
            {
                this.hoTen = hoTen;
                this.soCMND = soCMND;
                this.viettel3G = viettel3G;
            }
            public string XuatThongTin()
            {
                return $"{hoTen} - {soCMND} - {viettel3G.XuatThongTin()} ";
            }
        }
        static void Main(string[] args, Viettel3G[] arrVt)
        {
            int soPT = 0;
            //Nhap 1 goi cuoc
            Viettel3G myVt;
            //Tim goi cuoc trong mang
            char chon = '\0';
            ThueBao[] arrTB = new ThueBao[0];
            do
            {
                //Chon goi cuo muon dang ky ten
                Console.WriteLine("Nhap ten goi cuo muon dang ky; ");
                string ten=Console.ReadLine();
                //Tim ten goi uoc trong mang goi cuoc
                Viettel3G goiDK = TimGoiCuocTheoTen(arrVt, ten);
                //Nhap thong tin thue bao
                ThueBao gC1 = NhapThongTinThueBao(goiDK);
                //Them thue bao vao mang thue bao
                ThemThueBao(ref arrTB, gC1);
                //Hoi co tiep tuc nhap thue bao moi khong
                Console.WriteLine("An t/T de tiep tuc nhap thue bao moi");
                char.TryParse(Console.ReadLine(), out chon);
            } while (chon=='T' || chon =='t');
            //In danh sach thue bao
            foreach (var item in arrTB)
            {
                Console.WriteLine(item.XuatThongTin());
            }
        }
        //Tim goi cuo theo ten
        static Viettel3G TimGoiCuocTheoTen(Viettel3G[] arrVt, String tenGoi)//Tim khong thay thi tra ve 0
        {
            for (int i = 0; i < arrVt.Length; i++)
            {
                if (arrVt[i].tenGoi.ToLower() == tenGoi.ToLower())
                {
                    return arrVt[i];
                }
            }
            return arrVt[0]; //Neu ten goi cuoc khong ton tai thi thue bao dang dang ky goi thu 0
        }
        //Nhap 1 goi cuoc
        static Viettel3G NhapThongTinGoiCuoc()
        {
            string tenGoi = "";
            long giaGoi = 0;
            bool vuotGoi = false;
            //Nhap ten
            do
            {
                Console.WriteLine("*****Nhap thong tin cuoc goi*****");
                Console.Write("Nhap ten  goi: ");
                tenGoi=Console.ReadLine();
            } while (tenGoi.Length > 10 || tenGoi[tenGoi.Length - 1] < '0' || tenGoi[tenGoi.Length-1]>'9');
            //Nhap gia
            do
            {
                Console.Write("Nhap gia goi: ");
                giaGoi=int.Parse(Console.ReadLine());
            } while (giaGoi<0||giaGoi>999999);
            //Tinh chu ky tu dong khi goi ham tao
            //Vuot goi
            do
            {
                Console.Write("Nhap vuot goi: ");
            } while (bool.TryParse(Console.ReadLine(),out vuotGoi)==false);
            return new Viettel3G(tenGoi,giaGoi,vuotGoi);
        }
        //Nhap mang goi cuoc
        static Viettel3G[] NhapMangGoiCuoc(int soPT)
        {
            Viettel3G[] arr=new Viettel3G[soPT];
            for (int i = 0; i < soPT; i++)
            {
                arr[i] = NhapThongTinGoiCuoc();
            }
            return arr;
        }
        //Nhap 1 thue bao
        //Nhap thong tin thue bao
        //Xu ly chuoi ho ten
        static string XoaKhoangTrangThua(string str)
        {
            //Xoa khoang trang dau va cuoi chuoi
            str=str.Trim();
            //xoa khoang trang thua giua chuoi
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == ' ' && str[i+1]==' ')
                {
                    str = str.Remove(i, 1);
                    i--;
                }
            }
            return str;
        }
        //Nhap hoa dau tu
        static string HoaDauTu(string s)
        {
            //Xoa khoang trang thua
            s = XoaKhoangTrangThua(s);
            //CHuyen sang char[]
            char[] arrC = s.ToCharArray();
            //chuyen hoa ky tu dau
            arrC[0] = char.ToUpper(arrC[0]);
            for (int i = 0; i < s.Length; i++)
            {
                if (arrC[i]==' ')
                {
                    arrC[i + 1] = char.ToUpper(arrC[i + 1]);
                }
            }
            return new string(arrC);
        }
        //Nhap thue bao
        static ThueBao NhapThongTinThueBao(Viettel3G Vt)
        {
            string hoTen = "";
            string soCMND = "";
            Viettel3G viettel3;
            Console.WriteLine("*****Nhap thong tin thue bao*****");
            do
            {
                Console.Write("Nhap ho ten: ");
                hoTen = HoaDauTu(Console.ReadLine());
            } while (hoTen.Length > 30);
            do
            {
                Console.Write("Nhap so CNMD: ");
                soCMND = Console.ReadLine();
            } while (soCMND.Length > 10);
            viettel3 = Vt;
            return new ThueBao(hoTen, soCMND);
        }
        //Them thue bao vao mang
        static void ThemThueBao(ref ThueBao[] arr, ThueBao TBmoi)
        {
            Array.Resize(ref arr, arr.Length + 1);
            arr[arr.Length - 1] = TBmoi;
        }
        //Nhap mang thue bao
        //Them goi cuoc vao mang
        static void ThemGoiCuoc(ref Viettel3G[] arr, Viettel3G Vtmoi)
        {
            Array.Resize(ref arr, arr.Length + 1);
            arr[arr.Length - 1] = Vtmoi;
        }
    }
}
