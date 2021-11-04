using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace de_01
{
    class KhachHang
    {
        private string hoTen;
        private bool gioiTinh;
        private int soLuongMua;
        private double donGia;

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
        public int SoLuongMua
        {
            get => soLuongMua;
            set => soLuongMua = value;
        }
        public double DonGia
        {
            get => donGia;
            set => donGia = value;
        }
        public KhachHang() { }
        public KhachHang(string hoTen, bool gioiTinh, int soLuongMua, double donGia)
        {
            this.hoTen = hoTen;
            this.gioiTinh = gioiTinh;
            this.soLuongMua = soLuongMua;
            this.donGia = donGia;
        }
        public double tongTien()
        {
            if (soLuongMua < 100)
                return soLuongMua * donGia;
            else
                return 0.9 * soLuongMua * donGia;
        }
        public override string ToString()
        {
            return $"{hoTen,-20}{(gioiTinh ? "nam" : "nu"),-15}{soLuongMua,-20}{donGia,-15}{tongTien(),-15}";
        }
        public override bool Equals(object obj)
        {
            KhachHang x = (KhachHang)obj;
            return String.Compare(this.hoTen, x.hoTen, true) == 0;
        }

        public override int GetHashCode()
        {
            return 0;
        }
    }
}
