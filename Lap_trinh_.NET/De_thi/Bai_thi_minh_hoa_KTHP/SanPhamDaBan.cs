using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_thi_minh_hoa_KTHP
{
    class SanPhamDaBan
    {
        string maSp;
        string tenSp;
        string tenLoaiSp;
        int sLdaBan;
        int soTienBan;
        public string MaSp { get => maSp; set => maSp = value; }
        public string TenSp { get => tenSp; set => tenSp = value; }
        public string TenLoaiSp { get => tenLoaiSp; set => tenLoaiSp = value; }
        public int SLdaBan { get => sLdaBan; set => sLdaBan = value; }
        public int SoTienBan { get => soTienBan; set => soTienBan = value; }

        public SanPhamDaBan() { }
        public SanPhamDaBan(string maSp, string tenSp, string tenLoaiSp,int? sLdaBan, int? soTienBan)
        {
            this.maSp = maSp;
            this.tenLoaiSp = tenLoaiSp;
            this.tenSp = tenSp;
            this.sLdaBan = sLdaBan ?? 0;
            this.soTienBan = soTienBan ?? 0;
        }
    }
}
