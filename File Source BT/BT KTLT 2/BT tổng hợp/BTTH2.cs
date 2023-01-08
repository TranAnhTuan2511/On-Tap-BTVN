using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT_tong_hop_1
{
    class Program
    {
        public struct sinhVien
        {
            public string maSV;
            public string hoTen;
            public DateTime ngaySinh;
            public double diemTBTN;
            public double[,] bangDiemTB;
            public string xepLoai;
            public sinhVien (string maSV, string hoTen, DateTime ngaySinh)
            {
                this.maSV = maSV;
                this.hoTen = hoTen;
                this.ngaySinh = ngaySinh;
                this.diemTBTN = 0;
                this.bangDiemTB = new double[3, 2];
                this.xepLoai = "unknown";
            }
            public string XuatThongTin()
            {
                return $"{maSV}-{hoTen}-{ngaySinh}-{diemTBTN}-{bangDiemTB}-{xepLoai}";
            }
        }
        static void Main(string[] args)
        {
            //Nhap 1 SV
            sinhVien sV1 = NhapThongTin();
            Console.WriteLine(sV1.XuatThongTin());
            //Nhap bang diem
            NhapDTB(sV1);
            //In bang diem Sv
            InBangDiemSV(sV1);
            //Tinh DTB nam
            Console.WriteLine("Diem trung binh tung nam: ");
            for (int i = 0; i < sV1.bangDiemTB.GetLength(0); i++)
            {
                Console.WriteLine($"\tDiem trung binh nam {i + 1} la:{TinhDiemTrungBinhTungNamHoc(sV1, i)}");
            }
            //TinhDiemTrungBinhNamHoc diem trung binh tot nghiep
            Console.WriteLine("Diem trung binh tot nghiep la: ");
            TinhDiemTrungBinhTotNghiep(ref sV1);
            Console.WriteLine(sV1.XuatThongTin());
            //Tinh DTB tung nam


        }
        //Kiem tra ma sinh vien ky tu va so
        static bool KiemTraKyTuVaSo(string s)
        {
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] < '0' || (s[i] > '9' && s[i] < 'A') || (s[i] < 'Z' && s[i] > 'a') || s[i] < 'z')
                {
                    return false;
                }
            }
            return true;
        }
        //Xu ly chuoi ho ten
        static string DinhDangHoTen(string s)
        {
            //Xoa khoang trang dau chuoi
            s = s.Trim().ToLower();
            //Xoa khoang trang thua giua va cuoi chuoi
            for (int i = 0; i < s.Length - 1; i++)
            {
                if (s[i] == ' ' && s[i + 1] == ' ')
                {
                    s = s.Remove(i + 1, 1);
                    i--;
                }
            }
            //Viet hoa dau tu
            //Chuyen chuoi thanh chu thuong
            s = s.ToLower();
            //Chuyen chuoi ve mang char
            char[] arrC = s.ToCharArray();
            //Chuyen ky tu dau thanh chu hoa
            arrC[0] = char.ToUpper(arrC[0]);
            //Chuyen cac ky tu dau tu
            for (int i = 0; i < arrC.Length - 1; i++)
            {
                if (arrC[i] == ' ')
                {
                    arrC[i + 1] = Char.ToUpper(arrC[i + 1]);
                }
            }
            //Chuyen mang char sau xu ly thanh chuoi
            s = new string(arrC);
            return s;
        }
        //Khai bao va khoi tao du lieu cho SV trong he thong
        static sinhVien NhapThongTin()
        {
            string maSV = "";
            string hoTen = "";
            DateTime ngaySinh = new DateTime();
            //Nhap Ma sinh vien
            do
            {
                Console.Write("Nhap ma sinh vien: ");
                maSV = Console.ReadLine();
            } while (maSV.Length != 11 && KiemTraKyTuVaSo(maSV)==false);
            //Nhap ho ten sinh vien
            do
            {
                Console.Write("Nhap ho ten sinh vien: ");
                hoTen = Console.ReadLine();
            } while (hoTen.Length>30);
            hoTen = DinhDangHoTen(hoTen);
            //Nhap ngay sinh
            do
            {
                Console.Write("Nhap ngay sinh: ");
            } while (DateTime.TryParse(Console.ReadLine(), out ngaySinh) == false|| ngaySinh.Year < 2004);
            return new sinhVien(maSV, hoTen, ngaySinh);
        }
        //Nhap diem TB cho SV
        static bool NhapDTB(sinhVien sv, int namThu, int hocKy)
        {
            double dtb = 0;
            if (namThu-1<sv.bangDiemTB.GetLength(0) && hocKy-1<sv.bangDiemTB.GetLength(1))
            {
                do
                {
                    Console.Write($"Nhap diem trung binh cho nam {namThu}, hoc ky {hocKy}");
                    double.TryParse(Console.ReadLine(), out dtb);
                } while (dtb < 0 || dtb >10);
                sv.bangDiemTB[namThu - 1, hocKy - 1] = dtb;
            }
            Console.WriteLine("Nam / Hoc ky khong hop le");
            return false;
        }
        //Nhap ca bang diem
        static void NhapBangDiemTB(sinhVien sV)
        {
            for (int i = 0; i < sV.bangDiemTB.GetLength(0); i++)
            {
                for (int j = 0; j < sV.bangDiemTB.GetLength(1); j++)
                {
                    NhapDTB(sV, i + 1, j + 1);
                }
            }
        }
        //In bang diem
        static void InBangDiemSV(sinhVien sV)
        {
            Console.WriteLine("Bang diem SV: " + sV.hoTen);
            for (int i = 0; i < sV.bangDiemTB.GetLength(0); i++)
            {
                Console.WriteLine($"Bang diem trung binh cho nam thu {i+1}: ");
                for (int j = 0; j < sV.bangDiemTB.GetLength(1); j++)
                {
                    Console.Write($"\tBang diem hoc ky {j+1}: {sV.bangDiemTB[i, j]} ");
                    Console.WriteLine();
                }
                Console.WriteLine();
            }
        }
        //Tinh diem trung binh tung nam hoc
        static double TinhDiemTrungBinhTungNamHoc(sinhVien sV, int nam)
        {
            double tong = 0;
            double KQ = 0;
            for (int i = 0; i < sV.bangDiemTB.GetLength(1); i++)
            {
                tong += sV.bangDiemTB[nam, i];
            }
            KQ = tong / sV.bangDiemTB.GetLength(1);
            return KQ;
        }
        static void TinhDiemTrungBinhTotNghiep(ref sinhVien sV)
        {
            double tong = 0;
            for (int i = 0; i < sV.bangDiemTB.GetLength(0); i++)
            {
                tong += TinhDiemTrungBinhTungNamHoc(sV, i);
            }
            sV.diemTBTN = tong / sV.bangDiemTB.GetLength(0);
        }
        static void XepLoaiHocLuc(ref sinhVien sV)
        {

            
        }
    }
}
