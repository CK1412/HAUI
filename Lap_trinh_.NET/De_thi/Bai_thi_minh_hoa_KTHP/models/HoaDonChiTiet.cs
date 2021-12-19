using System;
using System.Collections.Generic;

#nullable disable

namespace Bai_thi_minh_hoa_KTHP.models
{
    public partial class HoaDonChiTiet
    {
        public string MaHd { get; set; }
        public string MaSp { get; set; }
        public DateTime? NgayBan { get; set; }
        public int? SoLuongMua { get; set; }

        public virtual SanPham MaSpNavigation { get; set; }
    }
}
