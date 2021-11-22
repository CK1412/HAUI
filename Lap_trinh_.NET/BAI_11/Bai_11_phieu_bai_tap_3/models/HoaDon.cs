using System;
using System.Collections.Generic;

#nullable disable

namespace Bai_11_phieu_bai_tap_3.models
{
    public partial class HoaDon
    {
        public HoaDon()
        {
            HoaDonChiTiets = new HashSet<HoaDonChiTiet>();
        }

        public string MaHd { get; set; }
        public DateTime? NgayLap { get; set; }
        public string MaKh { get; set; }
        public string NguoiLap { get; set; }

        public virtual KhachHang MaKhNavigation { get; set; }
        public virtual ICollection<HoaDonChiTiet> HoaDonChiTiets { get; set; }
    }
}
