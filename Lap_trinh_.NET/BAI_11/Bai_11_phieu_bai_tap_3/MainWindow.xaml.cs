using Bai_11_phieu_bai_tap_3.models;
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

namespace Bai_11_phieu_bai_tap_3
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        QLBanHangContext db = new QLBanHangContext();
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            refreshData();
        }

        private void refreshData()
        {
            var query = from sanPham in db.SanPhams
                        join loaiSP in db.LoaiSanPhams on sanPham.MaLoai equals loaiSP.MaLoai
                        select new
                        {
                            maSP = sanPham.MaSp,
                            tenSP = sanPham.TenSp,
                            soLuong = sanPham.SoLuong,
                            donGia = sanPham.DonGia,
                            tenLoaiSP = loaiSP.TenLoai,
                        };

            dataGridSP.ItemsSource = query.ToList();
        }
        private void resetTextBox()
        {
            txtBoxDonGia.Text = "";
            txtBoxMaLoai.Text = "";
            txtBoxMaSP.Text = "";
            txtBoxSoLuong.Text = "";
            txtBoxTenSP.Text = "";
        }
        private void dataGridSP_SelectedCellsChanged(object sender, SelectedCellsChangedEventArgs e)
        {
            dynamic selectedItem = dataGridSP.SelectedItem;
            if (selectedItem != null)
            {
                txtBoxMaSP.Text = selectedItem.maSP;
                txtBoxTenSP.Text = selectedItem.tenSP;
                txtBoxSoLuong.Text = selectedItem.soLuong.ToString();
                txtBoxDonGia.Text = selectedItem.donGia.ToString();
                string tenLoaiSP = selectedItem.tenLoaiSP;
                txtBoxMaLoai.Text = (db.LoaiSanPhams.SingleOrDefault(e => e.TenLoai.Equals(tenLoaiSP))).MaLoai;
            }
        }

        private void btnExit_Click(object sender, RoutedEventArgs e)
        {
            var showBox = MessageBox.Show("Bạn có muốn đóng chương trình không?", "Thông báo", MessageBoxButton.OKCancel);
            if (showBox == MessageBoxResult.OK)
            {
                this.Close();
            }
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            SanPham sp = new SanPham();
            sp.MaSp = txtBoxMaSP.Text.Trim();
            sp.TenSp = txtBoxTenSP.Text.Trim();
            sp.SoLuong = Convert.ToInt32(txtBoxSoLuong.Text);
            sp.MaLoai = txtBoxMaLoai.Text.Trim();
            sp.DonGia = Convert.ToInt32(txtBoxDonGia.Text);

            LoaiSanPham loaiSPCheck = new LoaiSanPham();
            loaiSPCheck.MaLoai = txtBoxMaLoai.Text.Trim();
            try
            {
                if (!db.SanPhams.Contains(sp))
                {
                    if (!db.LoaiSanPhams.Contains(loaiSPCheck))
                    {
                        MessageBox.Show($"Không có mã loại sản phẩm {txtBoxMaLoai.Text.Trim()}", "Thông báo", MessageBoxButton.OK, MessageBoxImage.Error);
                    }
                    else
                    {
                        db.SanPhams.Add(sp);
                        db.SaveChanges();
                        refreshData();
                        resetTextBox();
                    }
                }
                else
                {
                    MessageBox.Show($"Đã tồn tại mã sản phẩm {sp.MaSp}", "Thông báo", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
            catch
            {
                MessageBox.Show("Có lỗi xảy ra", "Thông báo", MessageBoxButton.OK);
            }
        }

        private void btnEdit_Click(object sender, RoutedEventArgs e)
        {
            var sp = (from sanPham in db.SanPhams
                      where sanPham.MaSp == txtBoxMaSP.Text
                      select sanPham).SingleOrDefault();
            try
            {
                if (sp != null)
                {
                    LoaiSanPham loaiSPCheck = new LoaiSanPham();
                    loaiSPCheck.MaLoai = txtBoxMaLoai.Text.Trim();
                    if (!db.LoaiSanPhams.Contains(loaiSPCheck))
                    {
                        MessageBox.Show($"Không có mã loại sản phẩm {txtBoxMaLoai.Text.Trim()}", "Thông báo", MessageBoxButton.OK, MessageBoxImage.Error);
                    }
                    else
                    {
                        // không sửa mã sp
                        sp.MaLoai = txtBoxMaLoai.Text.Trim();
                        sp.TenSp = txtBoxTenSP.Text.Trim();
                        sp.DonGia = Convert.ToInt32(txtBoxDonGia.Text);
                        sp.SoLuong = Convert.ToInt32(txtBoxSoLuong.Text);

                        db.SaveChanges();
                        refreshData();
                    }
                }
                else
                {
                    MessageBox.Show($"Không có sản phẩm mã {sp.MaSp}", "Thông báo", MessageBoxButton.OK, MessageBoxImage.Information);
                }
            }
            catch
            {
                MessageBox.Show("Có lỗi xảy ra", "Thông báo", MessageBoxButton.OK);
            }
        }

        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {
            var sp = (from sanPham in db.SanPhams
                      where sanPham.MaSp == txtBoxMaSP.Text
                      select sanPham).SingleOrDefault();
            try
            {
                if (sp != null)
                {
                    var deleteAction = MessageBox.Show("Bạn có đồng ý xoá?", "Xác nhận", MessageBoxButton.YesNo);
                    if (deleteAction == MessageBoxResult.Yes)
                    {
                        db.SanPhams.Remove(sp);
                        db.SaveChanges();
                        refreshData();
                        resetTextBox();
                    }
                }
                else
                {
                    MessageBox.Show($"Không có sản phẩm mã {sp.MaSp}", "Thông báo", MessageBoxButton.OK, MessageBoxImage.Information);
                }
            }
            catch
            {
                MessageBox.Show("Có lỗi xảy ra", "Thông báo", MessageBoxButton.OK);
            }
        }
    }
}
