using System;
using System.Collections.Generic;

#nullable disable

namespace Bai_11_phieu_bai_tap_3.models
{
    public partial class HoaDonChiTiet
    {
        public string MaHd { get; set; }
        public string MaSp { get; set; }
        public int? SoLuongMua { get; set; }

        public virtual HoaDon MaHdNavigation { get; set; }
        public virtual SanPham MaSpNavigation { get; set; }
    }
}
