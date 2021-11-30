using Bai_12_phieu_bai_tap_2.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Bai_12_phieu_bai_tap_2
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        QLBanHangContext db = new QLBanHangContext();
        private NguoiDung _nguoiDung;

        List<HangBan> listHang = new List<HangBan>();

        public Window1()
        {
            InitializeComponent();
        }

        public Window1(NguoiDung nguoiDung) : this()
        {
            _nguoiDung = nguoiDung;
            textBoxTenDangNhap.Text = _nguoiDung.TenDangNhap;
        }


        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            textBoxNgayLap.Text = DateTime.Now.ToShortDateString();
            textBoxSoDT.Focus();
        }

        private void textBoxSoDT_TextChanged(object sender, TextChangedEventArgs e)
        {
            var khachHang = (from kH in db.KhachHangs
                             where kH.SoDt.Equals(textBoxSoDT.Text.Trim())
                             select kH).SingleOrDefault();

            textBoxHoTenKH.Text = (khachHang != null) ? khachHang.TenKh : null;
        }

        private void textBoxMaHang_TextChanged(object sender, TextChangedEventArgs e)
        {
            var sanPham = (from sp in db.SanPhams
                           where sp.MaSp == textBoxMaHang.Text.Trim()
                           select sp).SingleOrDefault();

            if (sanPham != null)
            {
                textBoxTenHang.Text = sanPham.TenSp;
                textBoxDonGia.Text = sanPham.DonGia.ToString();
            }
            else
            {
                textBoxTenHang.Text = null;
                textBoxDonGia.Text = null;
            }
        }

        private void btnThemSP_Click(object sender, RoutedEventArgs e)
        {
            string maHang = textBoxMaHang.Text.Trim();
            string soLuong = textBoxSoLuong.Text.Trim();
            if (maHang != "" && soLuong != "")
            {
                if (Regex.IsMatch(soLuong, "^[1-9]\\d*$"))
                {
                    int soL = Convert.ToInt32(soLuong);
                    var sanPham = (from sp in db.SanPhams
                                   where sp.MaSp == maHang
                                   select sp).SingleOrDefault();
                    if (sanPham != null)
                    {
                        int x = (int)(soL * sanPham.DonGia);

                        HangBan temp = new HangBan(sanPham.MaSp, sanPham.TenSp, sanPham.DonGia ?? 0, soL);

                        int index = listHang.IndexOf(listHang.FirstOrDefault(e => e.maH == temp.maH));

                        if (index != -1)
                        {
                            listHang[index].sl += temp.sl;
                        }
                        else
                        {
                            listHang.Add(temp);
                        }

                        dataGrid.ItemsSource = listHang.ToList();
                    }
                    else
                    {
                        MessageBox.Show("Mã hàng không tồn tại");
                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng nhập số lượng > 0");
                }


            }
            else
            {
                MessageBox.Show("Vui lòng nhập đủ thông tin hàng mua", "Cảnh báo", MessageBoxButton.OK);
            }

        }

        private void btnLuuHD_Click(object sender, RoutedEventArgs e)
        {
            string soHD = textBoxSoHD.Text.Trim();
            string soDT = textBoxSoDT.Text.Trim();
            string tenKH = textBoxHoTenKH.Text.Trim();

            if (soHD != "" && soDT != "")
            {
                if (tenKH != "")
                {
                    if (listHang.Any())
                    {
                        KhachHang khachHang = (from kh in db.KhachHangs
                                               where kh.TenKh.Equals(tenKH)
                                               select kh).SingleOrDefault();
                        HoaDon hd = new HoaDon();
                        hd.MaHd = soHD;
                        hd.NgayLap = DateTime.Now;
                        hd.MaKh = khachHang.MaKh;
                        hd.NguoiLap = _nguoiDung.TenDangNhap;

                        db.HoaDons.Add(hd);

                        listHang.ForEach(e =>
                        {
                            HoaDonChiTiet hdct = new HoaDonChiTiet();
                            hdct.MaHd = soHD;
                            hdct.MaSp = e.maH;
                            hdct.SoLuongMua = e.sl;

                            db.HoaDonChiTiets.Add(hdct);
                        });

                        db.SaveChanges();
                        resetData();
                        MessageBox.Show("Lưu hoá đơn thành công", "Thông báo", MessageBoxButton.OK);
                    }
                    else
                    {
                        MessageBox.Show("Vui lòng thêm hàng mua", "Cảnh báo", MessageBoxButton.OK);
                    }
                }
                else
                {
                    MessageBox.Show("Số điện thoại không có sẵn", "Cảnh báo", MessageBoxButton.OK);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng nhập số hoá đơn và số điện thoại", "Cảnh báo", MessageBoxButton.OK);
            }

        }

        private void resetData()
        {
            textBoxDonGia.Text = "";
            textBoxSoDT.Text = "";
            textBoxSoHD.Text = "";
            textBoxSoLuong.Text = "";
            textBoxMaHang.Text = "";
            textBoxTenHang.Text = "";
            listHang.Clear();
            dataGrid.ItemsSource = listHang;
        }
    }
}
