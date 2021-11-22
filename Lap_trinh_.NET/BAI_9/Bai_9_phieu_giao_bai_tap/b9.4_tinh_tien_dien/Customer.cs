using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace b9._4_tinh_tien_dien
{
    class Customer
    {
        public string name { set; get; }
        public int oldIndex { set; get; }
        public int newIndex { set; get; }
        public int soKwTrongDinhMuc
        {
            get
            {
                if (chiSoTieuThu <= 50)
                    return chiSoTieuThu;
                else
                    return 50;
            }
            set {}
        }
        public int soKwVuotDinhMuc
        {
            get
            {
                if (chiSoTieuThu <= 50)
                    return 0;
                else
                    return chiSoTieuThu - 50;
            }
            set { }
        }
        public int chiSoTieuThu
        {
            get=> newIndex - oldIndex;
            set { }
        }
        public Customer(string name, int oldIndex, int newIndex)
        {
            this.name = name;
            this.oldIndex = oldIndex;
            this.newIndex = newIndex;
        }
        public int tongTien() => soKwTrongDinhMuc * 500 + soKwVuotDinhMuc * 1000;
    }
}
