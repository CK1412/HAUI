using System;
using System.Collections.Generic;

#nullable disable

namespace Bai_thi_minh_hoa_KTHP.models
{
    public partial class LoaiSp
    {
        public LoaiSp()
        {
            SanPhams = new HashSet<SanPham>();
        }

        public string MaLoai { get; set; }
        public string TenLoai { get; set; }

        public virtual ICollection<SanPham> SanPhams { get; set; }
    }
}
