/* LAm bai CHuong 2
 * name: Tran Anh Tuan
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch2_BT
{
    class Program
    {
        static void Main(string[] args)
        {
            //Nhap chuoi
            Console.Write("Nhap chuoi: ");
            string str = Console.ReadLine();

            //Cau 1: Ham dem so thu tu trong chuoi
            Console.WriteLine($"Dem so ky tu trong chuoi: {DemSoKyTu(str)} ");
            //Cau 2: HAm dem so ky tu hoa trong chuoi
            Console.WriteLine($"Dem so ky tu in hoa trong chuoi: {DemKyTuHoa(str)}");
            //cau 3: Viet ham dem so ky tu la chu so co trong chuoi
            Console.WriteLine($"Dem so ky tu So: {DemKyTuSo(str)}");
            //Cau 4: Ham ktra ky tu char
            char Ch = '0';
            Console.Write($"Nhap ky tu muon dem: ");
            Ch = Char.Parse(Console.ReadLine());
            Console.WriteLine($"Dem ky tu {Ch} trong chuoi: {DemKyTuChar(str, Ch)}");
            //Cau 5: Viet Ham dao nguoc chuoi
            Console.WriteLine($"Ham dao nguoc chuoi:{DaoNguocChuoi(str)} ");
            //Cau 6a Ham dem so tu trong mot chuoi
            //Console.Write("Nhap chuoi: ");  Du can thi sua()
            //String s = Console.ReadLine();  Du can thi sua()
            Console.WriteLine($"Dem so tu: {DemSoTu(str)}");
            //Cau 6b Ham dem so tu trong mot chuoi
            Console.Write("Nhap tu muon dem: ");
            string w = Console.ReadLine();

            Console.WriteLine($"So tu \"{w}\" trong chuoi la: {DemSoTuXuatHien(str, w)}");

            //Cau 7:Ham so sanh hai chuoi khong phan biet chu hoa, chu thuong
            Console.Write("Nhap chuoi 1: ");
            string str1 = Console.ReadLine();
            Console.Write("Nhap chuoi 2: ");
            string str2 = Console.ReadLine();
            Console.WriteLine($"So sanh {str1} va {str2}: {SoSanhChuoi(str1, str2)}");
            //Cau 8 Ham tao email
            string HoTen = "";
            Console.Write("Nhap ho ten: ");
            HoTen = Console.ReadLine();
            string domain = "@gmail.com";
            Console.WriteLine(TaoEmail(HoTen, domain));
            //Cau 9 ham kiem tra chuoi email do ng dung nhap vao co hop le hay khong
            string Email = TaoEmail(HoTen, domain);
            if (KiemTraCHuoiEmail(Email)==true)
            {
                Console.WriteLine("Email hop le");
            }
            else
            {
                Console.WriteLine("Error");
            }
        }
        //cau 1: ham dem so thu tu co trong chuoi
        static int DemSoKyTu(string str)
        {
            int dem = 0;
            foreach (var item in str)
            {
                dem++;
            }
            return dem;
        }
        //Cau 2: Ham dem so ky tu in hoa trong chuoi
        static int DemKyTuHoa(string str)
        {
            int dem = 0;
            foreach (var item in str)
            {
                if (item >= 'A' && item <= 'Z')
                {
                    dem++;
                }
            }
            return dem;
        }
        //cau 3: ham dem so ky tu la chu so co trong chuoi
        static int DemKyTuSo(string str)
        {
            int dem = 0;
            foreach (var item in str)
            {
                if (item >= '0' && item <= '9')
                {
                    dem++;
                }
            }
            return dem;
        }
        //Cau 4: ham ktra chuoi co ton tai ky tu "char" hay khong
        static int DemKyTuChar(String str, char Ch)
        {
            int dem = 0;
            foreach (var item in str)
            {
                if (item == Ch)
                {
                    dem++;
                }
            }
            return dem;
        }
        //Cau 5: Ham dao nguoc chuoi
        static string DaoNguocChuoi(string str)
        {
            string cD = " ";
            for (int i = str.Length - 1; i >= 0; i--)
            {
                cD += str[i];
            }
            return cD;
        }

        //Cau 6a Ham dem so tu trong mot chuoi
        static int DemSoTu(string str)
        {
            int dem = 0;
            str = str.Trim();
            for (int i = 0; i < str.Length - 1; i++)
            {
                if (str[i] == ' ' && str[i + 1] != ' ')
                {
                    dem++;
                }
            }

            return dem + 1;
        }
        //cau 6b: Ham dem so tu trong mot chuoi nhung duoc chon
        static int DemSoTuXuatHien(string str, string w)
        {
            int dem = 0;
            //Tach chuoi thanh mang string
            string[] arrW = str.Split(' ');
            Console.WriteLine("L = " + arrW.Length);
            if (w != "" || w != " ")
            {
                foreach (var item in arrW)
                {
                    if (item == w) 
                    {
                        dem++;
                    }
                }
            }
            return dem;
        }
        //Cau 7:Ham so sanh hai chuoi khong phan biet chu hoa, chu thuong
        static bool SoSanhChuoi (string str1, string str2)
        {
            int KQ = string.Compare(str1.ToLower(), str2.ToLower());
            if (KQ==0)
            {
                return true;
            }
            return string.Equals(str1.ToLower(), str2.ToLower());
        }
        //Cau 8 Viet Ham Tao EMail
        static string TaoEmail(string HoTen, string domain)
        {
            HoTen = HoTen.Replace(" ", "");
            string Email = string.Concat(HoTen, domain);

            return Email;
        }
        //Cau 9 Viet ham kiem tra chuoi email do ng dung nhap vao co hop le hay khong
        static bool KiemTraCHuoiEmail (string Email)
        {
            char[] kytu = { '#', '%', '$', '&', '^', ',' };
            int vT = Email.IndexOfAny(kytu);
            if (vT >= 0 && vT < Email.Length)
            {
                return false;
            }
            //Kiem tra co @
            if (Email.Contains("@") == false || DemSoKyTu("@") > 1)
            {
                return false;
            }
            return true;
        }
    }
}
