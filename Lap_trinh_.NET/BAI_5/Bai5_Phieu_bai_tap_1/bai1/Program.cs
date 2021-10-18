using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\t-----MENU------");
            Console.WriteLine("\t1. Nhap thong tin 1 thi sinh.");
            Console.WriteLine("\t2. Hien thi danh sach cac thi sinh.");
            Console.WriteLine("\t3. Hien thi cac sinh vien theo tong diem.");
            Console.WriteLine("\t4. Hien thi cac sinh vien theo dia chi.");
            Console.WriteLine("\t5. Tim kiem theo so bao danh.");
            Console.WriteLine("\t6. Ket thuc chuong trinh.");

            List<ThiSinhA> danhSachTS = new List<ThiSinhA>();
            int luaChon;
            bool isDone = true;

            while (isDone)
            {
                try
                {
                    Console.WriteLine("------------------------------");
                    Console.Write("Nhap lua chon cua ban: ");
                    luaChon = Convert.ToInt32(Console.ReadLine());

                    switch (luaChon)
                    {
                        case 1:
                            nhapThiSinh(danhSachTS);
                            break;
                        case 2:
                            hienThiDanhSachTS(danhSachTS);
                            break;
                        case 3:
                            hienThiDanhSachTheoTongDiem(danhSachTS);
                            break;
                        case 4:
                            hienThiDanhSachTheoDiaChi(danhSachTS);
                            break;
                        case 5:
                            TimTheoSBD(danhSachTS);
                            break;
                        case 6:
                            isDone = false;
                            Console.WriteLine("Dong chuong trinh thanh cong");
                            break;
                        default:
                            break;
                    }
                }
                catch(Exception e)
                {
                    Console.WriteLine(e.Message);
                }              
            }

        }

        public class ThiSinhA
        {
            public string sbd;
            public string hoTen;
            public string diaChi;
            public double toan;
            public double ly;
            public double hoa;
            public double diemUuTien;
            public double tongDiem;

            public void nhap()
            {
                Console.Write(" so bao danh: ");
                sbd = Console.ReadLine();
                Console.Write(" ho ten: ");
                hoTen = Console.ReadLine();
                Console.Write(" dia chi: ");
                diaChi = Console.ReadLine();
                Console.Write(" diem toan: ");
                toan = Convert.ToDouble(Console.ReadLine());
                Console.Write(" diem ly: ");
                ly = Convert.ToDouble(Console.ReadLine());
                Console.Write(" diem hoa: ");
                hoa = Convert.ToDouble(Console.ReadLine());
                Console.Write(" diem uu tien: ");
                diemUuTien = Convert.ToDouble(Console.ReadLine());
                tongDiem = toan + ly + hoa + diemUuTien;
            }

            public void xuat()
            {
                Console.Write(sbd.PadRight(10));
                Console.Write(hoTen.PadRight(20));
                Console.Write(diaChi.PadRight(25));
                Console.Write(toan.ToString().PadRight(12));
                Console.Write(ly.ToString().PadRight(12));
                Console.Write(hoa.ToString().PadRight(12));
                Console.Write(diemUuTien.ToString().PadRight(15));
                Console.Write(tongDiem.ToString().PadRight(12));
                Console.WriteLine();
            }

            public override string ToString()
            {
                return $"SBD: {sbd}, ho ten: {hoTen}, diem toan: {toan}, diem ly: {ly}, " +
                    $"diem hoa: {hoa}, diem uu tien: {diemUuTien}, tong diem: {tongDiem}\n";
            }
        }

        public static void tieuDe()
        {
            Console.WriteLine("SBD".PadRight(10) + "HO TEN".PadRight(20) + "DIA CHI".PadRight(25)
                + "DIEM TOAN".PadRight(12) + "DIEM LY".PadRight(12) + "DIEM HOA".PadRight(12)
                + "DIEM UU TIEN".PadRight(15) + "TONG DIEM".PadRight(12));
        }

        public static void nhapThiSinh(List<ThiSinhA> danhSachTS)
        {
            ThiSinhA x = new ThiSinhA();
            x.nhap();
            danhSachTS.Add(x);
        }

        public static void hienThiDanhSachTS(List<ThiSinhA> danhSachTS)
        {
            if (danhSachTS.Count == 0)
            {
                Console.WriteLine("Danh sach dang rong.");
                return;
            }
            tieuDe();
            foreach (ThiSinhA x in danhSachTS)
            {
                x.xuat();
            }
        }

        public static void hienThiDanhSachTheoTongDiem(List<ThiSinhA> danhSachTS)
        {
            if (danhSachTS.Count == 0)
            {
                Console.WriteLine("Danh sach dang rong.");
                return;
            }
            Console.Write("Nhap tong diem: ");
            double diem = Convert.ToDouble(Console.ReadLine());
            int count = 0;
            foreach(ThiSinhA x in danhSachTS)
            {
                if(x.tongDiem >= diem)
                {
                    count ++;
                }
            }
            if (count > 0)
            {
                tieuDe();
                foreach (ThiSinhA x in danhSachTS)
                {
                    if (x.tongDiem >= diem)
                    {
                        x.xuat();
                    }
                }
            }
            else
            {
                Console.WriteLine($"Khong co thi sinh co tong diem >= {diem}");
            }       
        }

        public static void hienThiDanhSachTheoDiaChi(List<ThiSinhA> danhSachTS)
        {
            if (danhSachTS.Count == 0)
            {
                Console.WriteLine("Danh sach dang rong.");
                return;
            }
            Console.Write("Nhap 1 dia chi: ");
            string dc = Console.ReadLine();
            int count = 0;
            foreach(ThiSinhA x in danhSachTS)
            {
                if (x.diaChi.Contains(dc))
                {
                    count++;
                }
            }
            if (count > 0)
            {
                tieuDe();
                foreach (ThiSinhA x in danhSachTS)
                {
                    if (x.diaChi.Contains(dc))
                    {
                        x.xuat();
                    }
                }
            }
            else
            {
                Console.WriteLine($"Khong co thi sinh co dia chi {dc}");
            }
        }

        public static void TimTheoSBD(List<ThiSinhA> danhSachTS)
        {
            if (danhSachTS.Count == 0)
            {
                Console.WriteLine("Danh sach dang rong.");
                return;
            }
            Console.Write("Nhap so bao danh: ");
            string sbd = Console.ReadLine();
            foreach(ThiSinhA x in danhSachTS)
            {
                if(x.sbd.Equals(sbd))
                {
                    Console.WriteLine(x);
                    return;
                }
            }
            Console.WriteLine($"Khong tim thay thi sinh co SBD {sbd}");
        }
    }
}
