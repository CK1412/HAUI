using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KiemTra1
{
    class SinhVien : Person
    {
        private string maSV;
        private double diem;
        private string xepLoai;
        public string MaSV
        {
            get => MaSV;
            set => maSV = value;
        }
        public double Diem
        {
            get => diem;
            set => diem = value;
        }
        public string XepLoai
        {
            get
            {
                if (diem >= 8)
                    return "gioi";
                else if (diem < 8 && diem >= 6.5)
                    return "Kha";
                else if (diem < 6.5 && diem >= 5)
                    return "trung binh";
                else
                    return "kem";
            }
        }
        public override void nhap()
        {
            base.nhap();
            Console.Write(" ma sv: ");
            maSV = Console.ReadLine();
            Console.Write(" diem: ");
            diem = Convert.ToDouble(Console.ReadLine());
        }
        public SinhVien() : base() { }
        public SinhVien(string maSV)
        {
            this.maSV = maSV;
        }
        public override bool Equals(object obj)
        {
            SinhVien x = (SinhVien)obj;
            return this.maSV.Equals(x.maSV);
        }
        public override int GetHashCode()
        {
            return 0;
        }
        public override string ToString()
        {
            return $"{maSV,-10}{Hoten,-20}{DienThoai,-20}{diem,-15}{XepLoai}";
        }
    }
}
