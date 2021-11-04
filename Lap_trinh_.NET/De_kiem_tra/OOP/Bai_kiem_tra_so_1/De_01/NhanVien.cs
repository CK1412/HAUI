using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace De_01
{
    class NhanVien : Nguoi
    {
        private string maNV;
        private string chucVu;
        private double luongCoBan;
        public string MaNV
        {
            get => maNV;
            set => maNV = value;
        }
        public string ChucVu
        {
            get => chucVu;
            set => chucVu = value;
        }
        public double LuongCoBan
        {
            get => luongCoBan;
            set => luongCoBan = value;
        }

        public override void nhap()
        {
            base.nhap();
            Console.Write(" ma nhan vien: ");
            maNV = Console.ReadLine();
            Console.Write(" chuc vu: ");
            chucVu = Console.ReadLine();
            Console.Write(" luong co ban: ");
            luongCoBan = Convert.ToDouble(Console.ReadLine());
        }
        public int heSoChucVu()
        {
            int x;
            switch (chucVu.ToLower())
            {
                case "giam doc":
                    x = 10;
                    break;
                case "truong phong":
                case "pho giam doc":
                    x = 6;
                    break;
                case "pho phong":
                    x = 4;
                    break;
                default:
                    x = 2;
                    break;
            }
            return x;
        }
    }
}
