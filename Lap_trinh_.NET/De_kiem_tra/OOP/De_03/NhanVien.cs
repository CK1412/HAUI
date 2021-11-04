using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace De_03
{
    class NhanVien
    {
        private string maNV;
        private string hoTen;
        private bool gioiTinh;
        public string MaNV
        {
            get => maNV;
            set => maNV = value;
        }
        public string HoTen
        {
            get => hoTen;
            set => hoTen = value;
        }
        public bool GioiTinh
        {
            get => gioiTinh;
            set => gioiTinh = value;
        }
        public NhanVien() { }
        public NhanVien(string maNV)
        {
            this.maNV = maNV;
        }
        public NhanVien(string maNV, string hoTen, bool gioiTinh)
        {
            this.maNV = maNV;
            this.hoTen = hoTen;
            this.gioiTinh = gioiTinh;
        }
        public override string ToString()
        {
            string gt = this.gioiTinh ? "nam" : "nu";
            return $"{maNV,-10}{hoTen,-20}{gt,-15}";
        }

        public override bool Equals(object obj)
        {
            NhanVien x = (NhanVien)obj;
            return this.maNV.Equals(x.maNV);
        }
    }
}
