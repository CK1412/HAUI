using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace De_03
{
    class NhanVienBanHang:NhanVien
    {
        private double soTienBanHang;
        public double SoTienBanHang
        {
            get => soTienBanHang;
            set => soTienBanHang = value;
        }
        public NhanVienBanHang() : base() { }
        public NhanVienBanHang(string maNV, string hoTen, bool gioiTinh, double soTienBanHang) : base(maNV, hoTen, gioiTinh)
        {
            this.soTienBanHang = soTienBanHang;
        }
        public double tinhTienHoaHong()
        {
            if (soTienBanHang < 1000)
                return 0;
            else if (soTienBanHang > 5000)
                return soTienBanHang * 20 / 100;
            else
                return soTienBanHang * 10 / 100;
        }
        public override string ToString()
        {
            return base.ToString()+ $"{soTienBanHang,-20}{tinhTienHoaHong()}";
        }
    }
}
