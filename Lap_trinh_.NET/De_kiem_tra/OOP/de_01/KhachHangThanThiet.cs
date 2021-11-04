using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace de_01
{
    class KhachHangThanThiet : KhachHang
    {
        public KhachHangThanThiet() : base() { }
        public KhachHangThanThiet(string hoTen, bool gioiTinh, int soLuongMua, double donGia) : base(hoTen, gioiTinh, soLuongMua, donGia) { }
        public string quaTang()
        {
            if (tongTien() <= 1000)
                return "Coupon 200";
            else
                return "Coupon 500";
        }
        public override string ToString()
        {
            return base.ToString() + quaTang();
        }
    }
}
