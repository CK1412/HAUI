using System;
using System.Collections.Generic;

#nullable disable

namespace de_07.model
{
    public partial class DanhMucThuoc
    {
        public DanhMucThuoc()
        {
            Thuocs = new HashSet<Thuoc>();
        }

        public string MaDm { get; set; }
        public string TenDm { get; set; }

        public virtual ICollection<Thuoc> Thuocs { get; set; }
    }
}
