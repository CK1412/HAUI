using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_12_phieu_bai_tap_2
{
    class HangBan
    {
        public string maH { get; set; }
        public string tenH { get; set; }
        public int donGia { get; set; }
        public int sl { get; set; }
        public int thanhTien { get => donGia * sl; set { } }

        public HangBan(string maH, string tenH, int donGia, int sl)
        {
            this.maH = maH;
            this.tenH = tenH;
            this.donGia = donGia;
            this.sl = sl;
            this.thanhTien = this.donGia * this.sl;
        }
    }
}
