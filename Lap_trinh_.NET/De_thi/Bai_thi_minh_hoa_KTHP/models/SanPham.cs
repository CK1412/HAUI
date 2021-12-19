using System;
using System.Collections.Generic;

#nullable disable

namespace Bai_thi_minh_hoa_KTHP.models
{
    public partial class SanPham
    {
        public SanPham()
        {
            HoaDonChiTiets = new HashSet<HoaDonChiTiet>();
        }

        public string MaSp { get; set; }
        public string TenSp { get; set; }
        public int? DonGia { get; set; }
        public int? SoLuongCo { get; set; }
        public string MaLoai { get; set; }

        public virtual LoaiSp MaLoaiNavigation { get; set; }
        public virtual ICollection<HoaDonChiTiet> HoaDonChiTiets { get; set; }
    }
}
