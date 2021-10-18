using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai3_bai_tap_ve_nha
{
    class Program
    {
        static void Main(string[] args)
        {
            List<SinhVien> sinhViens = new List<SinhVien>();

            Console.WriteLine("\t\t-----MENU------\n");
            Console.WriteLine("\t1. Them sinh vien.");
            Console.WriteLine("\t2. Cap nhat thong tin sinh vien boi ID.");
            Console.WriteLine("\t3. Xoa sinh vien boi ID.");
            Console.WriteLine("\t4. Tim kiem sinh vien theo ten.");
            Console.WriteLine("\t5. Sap xep sinh vien theo diem trung binh.");
            Console.WriteLine("\t6. Sap xep sinh vien theo ten.");
            Console.WriteLine("\t7. Hien thi danh sach sinh vien.");
            Console.WriteLine("\t8. Ghi danh sach sinh vien vao file \"student.txt\"");
            Console.WriteLine("\n\t***Chon cac lua chon khac se dong chuong trinh.***");
            char luaChon;
            bool isDone = true;
            while (isDone)
            {
                try
                {
                    Console.WriteLine("----------------------------------");
                    Console.Write("\nNhap lua chon cua ban: ");
                    luaChon = Convert.ToChar(Console.ReadLine());
                    switch (luaChon)
                    {
                        case '1':
                            themSV(sinhViens);
                            break;
                        case '2':
                            capNhatTheoId(sinhViens);
                            break;
                        case '3':
                            xoaTheoId(sinhViens);
                            break;
                        case '4':
                            timKiemTheoTen(sinhViens);
                            break;
                        case '5':
                            sapXepTheoDiemTB(sinhViens);
                            break;
                        case '6':
                            sapXepTheoTen(sinhViens);
                            break;
                        case '7':
                            xuatDanhSachSV(sinhViens);
                            break;
                        case '8':
                            ghiFile(sinhViens, "student.txt");
                            break;
                        default:
                            isDone = false;
                            Console.WriteLine("Ban da dong chuong trinh.");
                            break;
                    }
                }

                catch (Exception e)
                {
                    isDone = true;
                    Console.WriteLine(e.Message);
                    Console.WriteLine("Vui long thao tac lai");
                }
            }



        }
        
        public struct SinhVien
        {
            public int id;
            public string ten;
            public string gioiTinh;
            public int tuoi;
            public double diemToan;
            public double diemLy;
            public double diemHoa;
            public double diemTB;
            public string hocLuc;
        }

        static double diemTB(double a, double b, double c)
        {
            return (a + b + c) / 3;
        }
        static string hocLuc(double a)
        {
            if (a >= 8)
            {
                return "Gioi";
            }
            else if (a >= 6.5 && a < 8)
            {
                return "Kha";
            }
            else if (a >= 5 && a < 6.5)
            {
                return "Trung binh";
            }
            else
            {
                return "Yeu";
            }
        }
        static SinhVien nhapSV(List<SinhVien> sinhViens, int id = -1)
        {
            SinhVien x = new SinhVien();
            x.id = (id == -1) ? sinhViens.Count : id;
            Console.Write(" ho ten: ");
            x.ten = Console.ReadLine();
            Console.Write(" gioi tinh: ");
            x.gioiTinh = Console.ReadLine();
            Console.Write(" tuoi: ");
            x.tuoi = Convert.ToInt32(Console.ReadLine());
            Console.Write(" diem toan: ");
            x.diemToan = Convert.ToDouble(Console.ReadLine());
            Console.Write(" diem ly: ");
            x.diemLy = Convert.ToDouble(Console.ReadLine());
            Console.Write(" diem hoa: ");
            x.diemHoa = Convert.ToDouble(Console.ReadLine());
            x.diemTB = diemTB(x.diemToan, x.diemLy, x.diemHoa);
            x.hocLuc = hocLuc(x.diemTB);

            return x;
        }

        static void xuatSV(SinhVien sv)
        {
            Console.Write(sv.id.ToString().PadRight(8));
            Console.Write(sv.ten.PadRight(20));
            Console.Write(sv.gioiTinh.PadRight(12));
            Console.Write(sv.tuoi.ToString().PadRight(10));
            Console.Write(sv.diemToan.ToString("N2").PadRight(12));
            Console.Write(sv.diemLy.ToString("N2").PadRight(12));
            Console.Write(sv.diemHoa.ToString("N2").PadRight(12));
            Console.Write(sv.diemTB.ToString("N2").PadRight(12));
            Console.Write(sv.hocLuc.PadRight(12));
            Console.WriteLine();
        }

        static void themSV(List<SinhVien> sinhViens)
        {
            SinhVien x;
            Console.WriteLine("Nhap thong tin sv can them:");
            x = nhapSV(sinhViens);
            sinhViens.Add(x);
            Console.WriteLine("Da them sv.");
        }

        static void capNhatTheoId(List<SinhVien> sinhViens)
        {
            if (sinhViens.Count == 0)
            {
                Console.WriteLine("Danh sach hien khong co sinh vien.");
                return;
            }
            int id;
            Console.Write("Nhap id sinh vien can cap nhat: ");
            id = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < sinhViens.Count; i++)
            {
                if (sinhViens[i].id == id)
                {
                    Console.WriteLine("Nhap thong tin sinh can cap nhat:");
                    sinhViens[i] = nhapSV(sinhViens, id);
                    return;
                }
            }
            Console.WriteLine($"Khong tim thay sinh vien co id {id}");
        }

        static void xoaTheoId(List<SinhVien> sinhViens)
        {
            if (sinhViens.Count == 0)
            {
                Console.WriteLine("Danh sach hien khong co sinh vien.");
                return;
            }
            int id;
            Console.Write("Nhap id sinh vien can xoa: ");
            id = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < sinhViens.Count; i++)
            {
                if (sinhViens[i].id == id)
                {
                    sinhViens.Remove(sinhViens[i]);
                    Console.WriteLine($"Da xoa sinh co id {id}.");
                    return;
                }
            }
            Console.WriteLine($"Khong tim thay sinh vien co id {id}");
        }

        static void timKiemTheoTen(List<SinhVien> sinhViens)
        {
            if (sinhViens.Count == 0)
            {
                Console.WriteLine("Danh sach hien khong co sinh vien.");
                return;
            }
            string ten;
            Console.Write("Nhap ten sinh vien can tim: ");
            ten = Console.ReadLine();
            for (int i = 0; i < sinhViens.Count; i++)
            {
                if (sinhViens[i].ten.Equals(ten))
                {
                    Console.WriteLine($"Da tim thay sinh vien {ten}:");
                    Console.WriteLine(" ho ten: " + sinhViens[i].ten);
                    Console.WriteLine(" gioi tinh: " + sinhViens[i].gioiTinh);
                    Console.WriteLine(" tuoi: " + sinhViens[i].tuoi);
                    Console.WriteLine(" diem toan: " + sinhViens[i].diemToan);
                    Console.WriteLine(" diem ly: " + sinhViens[i].diemLy);
                    Console.WriteLine(" diem hoa: " + sinhViens[i].diemHoa);
                    Console.WriteLine(" diem trung binh: " + sinhViens[i].diemTB);
                    Console.WriteLine(" hoc luc: " + sinhViens[i].hocLuc);
                    Console.WriteLine();
                    return;
                }
            }
            Console.WriteLine("Khong tim thay sinh vien ten " + ten);
        }

        static void sapXepTheoDiemTB(List<SinhVien> sinhViens)
        {
            if (sinhViens.Count == 0)
            {
                Console.WriteLine("Danh sach hien khong co sinh vien.");
                return;
            }
            int n = sinhViens.Count;
            for (int i = 0; i < n; i++)
            {
                for (int j = n - 1; j > i; j--)
                {
                    if (sinhViens[j].diemTB < sinhViens[j - 1].diemTB)
                    {
                        SinhVien temp = sinhViens[j];
                        sinhViens[j] = sinhViens[j - 1];
                        sinhViens[j - 1] = temp;
                    }
                }
            }
            Console.WriteLine("Da sap xep sinh tang dan theo diem tb.");
        }

        static void sapXepTheoTen(List<SinhVien> sinhViens)
        {
            if (sinhViens.Count == 0)
            {
                Console.WriteLine("Danh sach hien khong co sinh vien.");
                return;
            }
            int n = sinhViens.Count;
            for (int i = 0; i < n; i++)
            {
                for (int j = n - 1; j > i; j--)
                {
                    if (sinhViens[j].ten.CompareTo(sinhViens[j - 1].ten) < 0)
                    {
                        SinhVien temp = sinhViens[j];
                        sinhViens[j] = sinhViens[j - 1];
                        sinhViens[j - 1] = temp;
                    }
                }
            }
            Console.WriteLine("Da sap xep sinh tang dan theo ten.");
        }

        static void xuatDanhSachSV(List<SinhVien> sinhViens)
        {
            if (sinhViens.Count == 0)
            {
                Console.WriteLine("Danh sach hien khong co sinh vien.");
                return;
            }

            Console.WriteLine("Danh sach sinh vien:\n");
            Console.WriteLine("ID".PadRight(8) + "HO TEN".PadRight(20)
                + "GIOI TINH".PadRight(12) + "TUOI".PadRight(10) + "DIEM TOAN".PadRight(12)
                + "DIEM LY".PadRight(12) + "DIEM HOA".PadRight(12) + "DIEM TB".PadRight(12)
                + "HOC LUC".PadRight(12));
            foreach (SinhVien sv in sinhViens)
            {
                xuatSV(sv);
            }
        }

        static void ghiFile(List<SinhVien> sinhViens, string tenFile)
        {
            if (sinhViens.Count == 0)
            {
                Console.WriteLine("Danh sach hien khong co sinh vien.");
                return;
            }
            StreamWriter streamWriter = new StreamWriter(tenFile);
            streamWriter.WriteLine("ID".PadRight(8) + "HO TEN".PadRight(20)
                + "GIOI TINH".PadRight(12) + "TUOI".PadRight(10) + "DIEM TOAN".PadRight(12)
                + "DIEM LY".PadRight(12) + "DIEM HOA".PadRight(12) + "DIEM TB".PadRight(12)
                + "HOC LUC".PadRight(12));
            foreach (SinhVien sv in sinhViens)
            {
                streamWriter.Write(sv.id.ToString().PadRight(8));
                streamWriter.Write(sv.ten.PadRight(20));
                streamWriter.Write(sv.gioiTinh.PadRight(12));
                streamWriter.Write(sv.tuoi.ToString().PadRight(10));
                streamWriter.Write(sv.diemToan.ToString().PadRight(12));
                streamWriter.Write(sv.diemLy.ToString().PadRight(12));
                streamWriter.Write(sv.diemHoa.ToString().PadRight(12));
                streamWriter.Write(sv.diemTB.ToString().PadRight(12));
                streamWriter.Write(sv.hocLuc.PadRight(12));
                streamWriter.WriteLine();
            }
            streamWriter.Close();
            Console.WriteLine("Da ghi thanh cong danh sach sv vao file");
        }
    }
}
