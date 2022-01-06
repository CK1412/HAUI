using System;
using System.Collections.Generic;

#nullable disable

namespace de_07.model
{
    public partial class Thuoc
    {
        public string MaThuoc { get; set; }
        public string TenThuoc { get; set; }
        public double? GiaBan { get; set; }
        public int? SoLuong { get; set; }
        public string MaDm { get; set; }

        public virtual DanhMucThuoc MaDmNavigation { get; set; }
    }
}
