using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace De_02
{
    class NhanVien:TinhLuong,IComparable
    {
        private string maNV;
        private string chucVu;
        public string MaNV
        {
            get => maNV;
            set => maNV = value;
        }
        public string ChucVu
        {
            get => chucVu;
            set => chucVu = value;
        }
        public override double tinhLuong()
        {
            double phuCap;
            switch (chucVu.ToLower())
            {
                case "giam doc":
                    phuCap = 0.5;
                    break;
                case "truong phong":
                case "pho giam doc":
                    phuCap = 0.4;
                    break;
                case "pho phong":
                    phuCap = 0.3;
                    break;
                default:
                    phuCap = 0;
                    break;
            }
            return (HeSoLuong + phuCap) * LuongCoBan;
        }

        public int CompareTo(object obj)
        {
            NhanVien x = (NhanVien)obj;
            return this.tinhLuong().CompareTo(x.tinhLuong());
        }
    }
}
