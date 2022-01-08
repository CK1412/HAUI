using de_03.model;
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

namespace de_03
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        QLNhanVienContext db = new();
        public Window1()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            var query1 = from nv in db.Nhanviens
                         group nv by nv.MaPhong into phGroup
                         select new
                         {
                             MaPhong = phGroup.Key,
                             SLNhanVien = phGroup.Count(),
                             TongLuong = phGroup.Sum(x => x.Luong)
                         };
            var query2 = from ph in db.PhongBans
                         join phGroup in query1 on ph.MaPhong equals phGroup.MaPhong
                         select new
                         {
                             phGroup.MaPhong,
                             TenPhong = ph.TenPhong,
                             phGroup.SLNhanVien,
                             phGroup.TongLuong
                         };
            dataGrid.ItemsSource = query2.ToList();
        }
    }
}
