using Bai_thi_minh_hoa_KTHP.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Bai_thi_minh_hoa_KTHP
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        QLBanHangContext db = new QLBanHangContext();
        public Window1()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            var query = from loaiSp in db.LoaiSps
                        join sp in db.SanPhams on loaiSp.MaLoai equals sp.MaLoai
                        join hdct in db.HoaDonChiTiets on sp.MaSp equals hdct.MaSp
                        select new SanPhamDaBan(sp.MaSp, sp.TenSp, loaiSp.TenLoai, hdct.SoLuongMua, hdct.SoLuongMua * sp.DonGia);

            var data = query.ToList().GroupBy(e => e.MaSp);
            foreach (var group in data)
            {
                SanPhamDaBan spDaBan = new SanPhamDaBan();

                foreach (var x in group)
                {
                    spDaBan.MaSp = x.MaSp;
                    spDaBan.TenSp = x.TenSp;
                    spDaBan.TenLoaiSp = x.TenLoaiSp;
                    spDaBan.SLdaBan += x.SLdaBan;
                    spDaBan.SoTienBan += x.SoTienBan;
                }
                dataGrid.Items.Add(spDaBan);
            }
        }
    }
}
