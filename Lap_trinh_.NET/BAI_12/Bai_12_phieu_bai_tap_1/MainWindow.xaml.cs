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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Bai_12_phieu_bai_tap_1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        QLBanHangContext db = new QLBanHangContext();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            txtBoxUserName.Focus();
        }

        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {
            if (AllowLogin())
            {
                string tenDangNhap = txtBoxUserName.Text.Trim();
                string matKhau = txtBoxPassword.Text.Trim();
                var taiKhoan = (from nguoiDung in db.NguoiDungs
                            where nguoiDung.TenDangNhap == tenDangNhap && nguoiDung.MatKhau == matKhau
                            select nguoiDung).SingleOrDefault();

                try
                {
                    if (taiKhoan == null)
                    {
                        MessageBox.Show("Tên đăng nhập hoặc mật khẩu không chính xác", "Cảnh báo", MessageBoxButton.OK);
                        txtBoxUserName.Focus();
                    }
                    else
                    {
                        HoaDon hoaDonWindow = new HoaDon(taiKhoan as NguoiDung);
                        hoaDonWindow.Show();
                        this.Close();
                    }
                }
                catch
                {
                    MessageBox.Show("Có lỗi xảy ra", "Thông báo", MessageBoxButton.OK);
                }
            }
        }

        private bool AllowLogin()
        {
            if(txtBoxUserName.Text.Trim() == "")
            {
                MessageBox.Show("Bạn chưa nhập tên đăng nhập", "Cảnh báo", MessageBoxButton.OK);
                txtBoxUserName.Focus();
                return false;
            }
            else if(txtBoxPassword.Text.Trim() == "")
            {
                MessageBox.Show("Bạn chưa nhập mật khẩu", "Cảnh báo", MessageBoxButton.OK);
                txtBoxPassword.Focus();
                return false;
            }
            else
            {
                return true;
            }
        }

        
    }
}
