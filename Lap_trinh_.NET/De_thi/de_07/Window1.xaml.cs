using de_07.model;
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

namespace de_07
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        QLDuocPhamContext db = new();
        public Window1()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            var query1 = from thuoc in db.Thuocs
                         group thuoc by thuoc.MaDm into Dmgroup
                         select new
                         {
                             MaDanhMuc = Dmgroup.Key,
                             TongTien = Dmgroup.Sum(x => x.SoLuong * x.GiaBan),
                         };

            var query2 = from thuoc1 in query1
                         join thuoc2 in db.DanhMucThuocs on thuoc1.MaDanhMuc equals thuoc2.MaDm
                         select new
                         {
                             MaDanhMuc = thuoc1.MaDanhMuc,
                             TenDanhMuc = thuoc2.TenDm,
                             TongTien = thuoc1.TongTien,
                         };

            dataGrid.ItemsSource = query2.ToList();
        }
    }
}
