using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace De_02
{
    class TinhLuong
    {
        private string hoTen;
        private string diaChi;
        private double heSoLuong;
        private static int luongCoBan = 1000000;
        public string HoTen
        {
            get => hoTen;
            set => hoTen = value;
        }
        public string DiaChi
        {
            get => diaChi;
            set => diaChi = value;
        }
        public double HeSoLuong
        {
            get => heSoLuong;
            set => heSoLuong = value;
        }
        public double LuongCoBan
        {
            get => luongCoBan;
        }
        public TinhLuong() { }
        public TinhLuong(string hoTen, string diaChi,double heSoLuong)
        {
            this.hoTen = hoTen;
            this.diaChi = diaChi;
            this.heSoLuong = heSoLuong;
        }
        public virtual double tinhLuong()
        {
            return heSoLuong * luongCoBan;
        }
    }
}
