using Bai_12_phieu_bai_tap_1.models;
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

namespace Bai_12_phieu_bai_tap_1
{
    /// <summary>
    /// Interaction logic for HoaDon.xaml
    /// </summary>
    public partial class HoaDon : Window
    {
        private NguoiDung _nguoiDung;

        public HoaDon()
        {
            InitializeComponent();
        }

        public HoaDon(NguoiDung nguoiDung) : this()
        {
            _nguoiDung = nguoiDung;
            textBoxTenDangNhap.Text = _nguoiDung.TenDangNhap;
        }


        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            textBoxNgayLap.Text = DateTime.Now.ToShortDateString();
        }
    }
}
