using Bai_thi_minh_hoa_KTHP.models;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Bai_thi_minh_hoa_KTHP
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        QLBanHangContext db = new QLBanHangContext();
        List<LoaiSp> loaiSPs = new List<LoaiSp>();
        public MainWindow()
        {
            InitializeComponent();
        }

        public void refreshData()
        {
            var data = from sp in db.SanPhams
                       where sp.DonGia > 100
                       orderby sp.TenSp descending
                       select new
                       {
                           MaSp = sp.MaSp,
                           TenSp = sp.TenSp,
                           MaLoai = sp.MaLoai,
                           SoLuongCo = sp.SoLuongCo,
                           DonGia = sp.DonGia,
                           ThanhTien = sp.DonGia * sp.SoLuongCo,
                       };
            dataGrid.ItemsSource = data.ToList();
        }
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            refreshData();
            textBoxMaSP.Focus();
            var query = from loai in db.LoaiSps
                        select loai;
            loaiSPs = query.ToList();

            comboBoxLoaiSP.ItemsSource = loaiSPs.Select(e => e.TenLoai);
        }
        private void dataGrid_SelectedCellsChanged(object sender, SelectedCellsChangedEventArgs e)
        {
            dynamic selectedItem = dataGrid.SelectedItem;
            if (selectedItem != null)
            {
                textBoxMaSP.Text = selectedItem.MaSp;
                textBoxTenSP.Text = selectedItem.TenSp;
                textBoxSoLuongCo.Text = selectedItem.SoLuongCo.ToString();
                textBoxDonGia.Text = selectedItem.DonGia.ToString();
                comboBoxLoaiSP.SelectedIndex = (loaiSPs.Select(e => e.MaLoai).ToList().IndexOf(selectedItem.MaLoai));
            }
        }
        private void buttonThem_Click(object sender, RoutedEventArgs e)
        {
            labelMaLoi.Content = "";
            string maSP = textBoxMaSP.Text.Trim();
            string tenSP = textBoxTenSP.Text.Trim();
            string loaiSP = (comboBoxLoaiSP.SelectedIndex != -1) ? comboBoxLoaiSP.Text.Trim() : "";
            string soLuongCo = textBoxSoLuongCo.Text.Trim();
            string donGia = textBoxDonGia.Text.Trim();

            if (maSP == "" || tenSP == "" || loaiSP == "" || soLuongCo == "" || donGia == "")
            {
                labelMaLoi.Content = "Vui lòng nhập đầy đủ dữ liệu của các trường";
                return;
            }
            if (!Regex.IsMatch(soLuongCo, @"^\d*[1-9]{1}\d*$") || !Regex.IsMatch(donGia, @"^\d*[1-9]{1}\d*$"))
            {
                labelMaLoi.Content = "Số lượng có hoặc đơn giá phải là số nguyên > 0";
                return;
            }

            var sanPhams = (from sanPham in db.SanPhams
                            where sanPham.MaSp.Equals(maSP)
                            select sanPham).SingleOrDefault();
            if (sanPhams != null)
            {
                MessageBox.Show("Mã sản phẩm đã tồn tại", "Cảnh báo", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }

            SanPham sp = new SanPham();
            sp.MaSp = maSP;
            sp.TenSp = tenSP;
            sp.MaLoai = loaiSPs[comboBoxLoaiSP.SelectedIndex].MaLoai;
            sp.SoLuongCo = Convert.ToInt32(soLuongCo);
            sp.DonGia = Convert.ToInt32(donGia);

            db.SanPhams.Add(sp);
            db.SaveChanges();
            refreshData();
        }

        private void buttonXoa_Click(object sender, RoutedEventArgs e)
        {
            var sp = (from sanPham in db.SanPhams
                      where sanPham.MaSp == textBoxMaSP.Text.Trim()
                      select sanPham).SingleOrDefault();
            if (sp != null)
            {
                var deleteAction = MessageBox.Show("Bạn có đồng ý xoá?", "Xác nhận", MessageBoxButton.YesNo);
                if (deleteAction == MessageBoxResult.Yes)
                {
                    db.SanPhams.Remove(sp);
                    db.SaveChanges();
                    refreshData();
                }
            }
            else
            {
                MessageBox.Show($"Không có sản phẩm mã {sp.MaSp}", "Thông báo", MessageBoxButton.OK, MessageBoxImage.Information);
            }
        }

        private void buttonSua_Click(object sender, RoutedEventArgs e)
        {
            labelMaLoi.Content = "";
            string maSP = textBoxMaSP.Text.Trim();
            string tenSP = textBoxTenSP.Text.Trim();
            string loaiSP = (comboBoxLoaiSP.SelectedIndex != -1) ? comboBoxLoaiSP.Text.Trim() : "";
            string soLuongCo = textBoxSoLuongCo.Text.Trim();
            string donGia = textBoxDonGia.Text.Trim();

            if (maSP == "" || tenSP == "" || loaiSP == "" || soLuongCo == "" || donGia == "")
            {
                labelMaLoi.Content = "Vui lòng nhập đầy đủ dữ liệu của các trường";
                return;
            }
            if (!Regex.IsMatch(soLuongCo, @"^\d*[1-9]{1}\d*$") || !Regex.IsMatch(donGia, @"^\d*[1-9]{1}\d*$"))
            {
                labelMaLoi.Content = "Số lượng có hoặc đơn giá phải là số nguyên > 0";
                return;
            }

            var sp = (from sanPham in db.SanPhams
                      where sanPham.MaSp == textBoxMaSP.Text.Trim()
                      select sanPham).SingleOrDefault();
            if (sp != null)
            {
                sp.MaLoai = loaiSPs[comboBoxLoaiSP.SelectedIndex].MaLoai;
                sp.TenSp = textBoxTenSP.Text.Trim();
                sp.DonGia = Convert.ToInt32(textBoxDonGia.Text);
                sp.SoLuongCo = Convert.ToInt32(textBoxSoLuongCo.Text);

                db.SaveChanges();
                refreshData();
            }
            else
            {
                MessageBox.Show($"Không có sản phẩm mã {textBoxMaSP.Text}", "Thông báo", MessageBoxButton.OK, MessageBoxImage.Information);
            }
        }

        private void buttonTim_Click(object sender, RoutedEventArgs e)
        {
            Window1 window1 = new Window1();
            window1.Show();
        }
    }
}
