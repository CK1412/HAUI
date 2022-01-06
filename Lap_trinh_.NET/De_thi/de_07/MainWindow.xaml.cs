using de_07.model;
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

namespace de_07
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        QLDuocPhamContext db = new();
        List<DanhMucThuoc> danhMucThuocs = new();
        public MainWindow()
        {
            InitializeComponent();
        }
        private void refreshData()
        {
            var query = from thuoc in db.Thuocs
                        where thuoc.SoLuong <= 200
                        orderby thuoc.TenThuoc ascending
                        select new
                        {
                            MaThuoc = thuoc.MaThuoc,
                            TenThuoc = thuoc.TenThuoc,
                            MaDanhMuc = thuoc.MaDm,
                            GiaBan = thuoc.GiaBan,
                            SoLuong = thuoc.SoLuong,
                            ThanhTien = thuoc.GiaBan * thuoc.SoLuong,
                        };
            dataGrid.ItemsSource = query.ToList();
        }
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            refreshData();

            danhMucThuocs = (from cate in db.DanhMucThuocs
                             select cate).ToList<DanhMucThuoc>();
            comboBoxDanhMucThuoc.ItemsSource = danhMucThuocs;
            comboBoxDanhMucThuoc.DisplayMemberPath = "TenDm";
            comboBoxDanhMucThuoc.SelectedValuePath = "MaDm";

            textBoxMaThuoc.Focus();
        }
        private void dataGrid_SelectedCellsChanged(object sender, SelectedCellsChangedEventArgs e)
        {
            dynamic selectedItem = dataGrid.SelectedItem;
            if (selectedItem != null)
            {
                textBoxMaThuoc.Text = selectedItem.MaThuoc;
                textBoxTenThuoc.Text = selectedItem.TenThuoc;
                textBoxSoLuong.Text = selectedItem.SoLuong.ToString();
                textBoxGiaBan.Text = selectedItem.GiaBan.ToString();
                comboBoxDanhMucThuoc.SelectedIndex = danhMucThuocs.Select(e => e.MaDm).ToList().IndexOf(selectedItem.MaDanhMuc);
            }
        }
        private bool isCheckValidateInput()
        {
            labelMaLoi.Content = "";
            string maThuoc = textBoxMaThuoc.Text.Trim();
            string tenThuoc = textBoxTenThuoc.Text.Trim();
            string soLuong = textBoxSoLuong.Text.Trim();
            string giaBan = textBoxGiaBan.Text.Trim();
            var danhMuc = comboBoxDanhMucThuoc.SelectedItem as DanhMucThuoc;
            if (maThuoc == "" || tenThuoc == "" || soLuong == "" || giaBan == "" || danhMuc == null)
            {
                labelMaLoi.Content = "Vui lòng nhập đủ các trường";
                return false;
            }
            if (!Regex.IsMatch(soLuong, @"^\d*[1-9]{1}\d*$") || !Regex.IsMatch(giaBan, @"^\d+\.?(\d+|\d*)$"))
            {
                labelMaLoi.Content = " số lượng phải là số nguyên dương và giá bán phải là số thực dương. ";
                return false;
            }
            return true;
        }
        private void buttonThem_Click(object sender, RoutedEventArgs e)
        {
            if (isCheckValidateInput())
            {
                var query = (from thuoc in db.Thuocs
                             where thuoc.MaThuoc.Equals(textBoxMaThuoc.Text.Trim())
                             select thuoc).SingleOrDefault();
                if (query != null)
                {
                    MessageBox.Show("Mã thuốc đã tồn tại", "Cảnh báo", MessageBoxButton.OK, MessageBoxImage.Warning);
                    return;
                }
                else
                {
                    Thuoc newThuoc = new();
                    newThuoc.MaThuoc = textBoxMaThuoc.Text.Trim();
                    newThuoc.TenThuoc = textBoxTenThuoc.Text.Trim();
                    newThuoc.SoLuong = Convert.ToInt32(textBoxSoLuong.Text);
                    newThuoc.GiaBan = Convert.ToDouble(textBoxGiaBan.Text);
                    newThuoc.MaDm = (comboBoxDanhMucThuoc.SelectedItem as DanhMucThuoc).MaDm;

                    db.Thuocs.Add(newThuoc);
                    db.SaveChanges();
                    refreshData();
                }

            }
        }

        private void buttonXoa_Click(object sender, RoutedEventArgs e)
        {
            var query = (from thuoc in db.Thuocs
                         where thuoc.MaThuoc.Equals(textBoxMaThuoc.Text.Trim())
                         select thuoc).SingleOrDefault();
            if (query == null)
            {
                MessageBox.Show($"Không tìm thấy thuốc", "Thông báo", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            else
            {
                var deleteAction = MessageBox.Show("Bạn có đồng ý xoá?", "Xác nhận", MessageBoxButton.YesNo);
                if (deleteAction == MessageBoxResult.Yes)
                {
                    db.Thuocs.Remove(query);
                    db.SaveChanges();
                    refreshData();
                }
            }
        }

        private void buttonSua_Click(object sender, RoutedEventArgs e)
        {
            var query = (from thuoc in db.Thuocs
                         where thuoc.MaThuoc.Equals(textBoxMaThuoc.Text.Trim())
                         select thuoc).SingleOrDefault();
            if (query == null)
            {
                MessageBox.Show($"Không tìm thấy thuốc", "Thông báo", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            else
            {
                if (isCheckValidateInput())
                {
                    query.TenThuoc = textBoxTenThuoc.Text.Trim();
                    query.SoLuong = Convert.ToInt32(textBoxSoLuong.Text);
                    query.GiaBan = Convert.ToDouble(textBoxGiaBan.Text);
                    query.MaDm = (comboBoxDanhMucThuoc.SelectedItem as DanhMucThuoc).MaDm;

                    db.SaveChanges();
                    refreshData();
                }
            }
        }

        private void buttonTim_Click(object sender, RoutedEventArgs e)
        {
            Window1 window1 = new Window1();
            window1.Show();
        }
    }
}
