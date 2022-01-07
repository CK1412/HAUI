using de_03.model;
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

namespace de_03
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        QLNhanVienContext db = new();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            setData();
        }

        private void setData()
        {
            var query = from nv in db.Nhanviens
                        where nv.Luong > 5000
                        orderby nv.Luong ascending
                        select new
                        {
                            MaPhong = nv.MaPhong,
                            MaNV = nv.MaNv,
                            HoTen = nv.Hoten,
                            Luong = nv.Luong,
                            Thuong = nv.Thuong,
                            TongTien = nv.Luong + nv.Thuong
                        };
            dataGrid.ItemsSource = query.ToList();

            var query2 = from pb in db.PhongBans
                         select pb.MaPhong;

            comboBoxMaPhong.ItemsSource = query2.ToList();
        }

        private void loadData()
        {
            var query = from nv in db.Nhanviens
                        select new
                        {
                            MaPhong = nv.MaPhong,
                            MaNV = nv.MaNv,
                            HoTen = nv.Hoten,
                            Luong = nv.Luong,
                            Thuong = nv.Thuong,
                            TongTien = nv.Luong + nv.Thuong
                        };
            dataGrid.ItemsSource = query.ToList();
        }

        private void dataGrid_SelectedCellsChanged(object sender, SelectedCellsChangedEventArgs e)
        {
            dynamic selectedItem = dataGrid.SelectedItem;
            if (selectedItem != null)
            {
                textBoxMaNV.Text = selectedItem.MaNV;
                textBoxHoTen.Text = selectedItem.HoTen;
                textBoxLuong.Text = selectedItem.Luong.ToString();
                textBoxThuong.Text = selectedItem.Thuong.ToString();
                comboBoxMaPhong.SelectedItem = selectedItem.MaPhong;
            }
        }

        private bool checkValidate()
        {
            labelMaLoi.Content = "";
            string maNV = textBoxMaNV.Text.Trim();
            string hoTen = textBoxHoTen.Text.Trim();
            string luong = textBoxLuong.Text.Trim();
            string thuong = textBoxThuong.Text.Trim();
            string maPhong = comboBoxMaPhong.Text;
            if (maNV == "" || hoTen == "" || luong == "" || thuong == "" || maPhong == "")
            {
                labelMaLoi.Content = "Các trường không được rỗng";
                return false;
            }
            if(Regex.IsMatch(luong,@"^\d$") || Regex.IsMatch(thuong, @"^\d$"))
            {
                labelMaLoi.Content = "Lương và thưởng phải là số";
                return false;
            }
            int tienLuong = Convert.ToInt32(luong);
            int tienThuong = Convert.ToInt32(thuong);

            if(tienLuong < 3000 || tienLuong > 9000)
            {
                labelMaLoi.Content = "Lương phải từ 3000 đến 9000";
                return false;
            }
            if (tienThuong < 100 || tienThuong > 900)
            {
                labelMaLoi.Content = " thưởng phải từ 100 đến 900";
                return false;
            }

            return true;
        }

        private void buttonThem_Click(object sender, RoutedEventArgs e)
        {
            if (checkValidate())
            {
                var exitsItem = (from nv in db.Nhanviens
                               where nv.MaNv.Equals(textBoxMaNV.Text.Trim())
                               select nv).SingleOrDefault();
                if(exitsItem == null)
                {
                    Nhanvien nv = new();
                    nv.MaNv = textBoxMaNV.Text.Trim();
                    nv.Hoten = textBoxHoTen.Text.Trim();
                    nv.MaPhong = comboBoxMaPhong.Text;
                    nv.Luong = Convert.ToInt32(textBoxLuong.Text);
                    nv.Thuong = Convert.ToInt32(textBoxThuong.Text);

                    db.Nhanviens.Add(nv);
                    db.SaveChanges();
                    loadData();
                }
                else
                {
                    labelMaLoi.Content = "Mã nhân viên đã tồn tại";
                }
            }
        }

        private void buttonSua_Click(object sender, RoutedEventArgs e)
        {
            var exitsItem = (from nv in db.Nhanviens
                             where nv.MaNv.Equals(textBoxMaNV.Text.Trim())
                             select nv).SingleOrDefault();
            if(exitsItem != null)
            {
                if (checkValidate())
                {
                    exitsItem.Hoten = textBoxHoTen.Text.Trim();
                    exitsItem.MaPhong = comboBoxMaPhong.Text;
                    exitsItem.Luong = Convert.ToInt32(textBoxLuong.Text);
                    exitsItem.Thuong = Convert.ToInt32(textBoxThuong.Text);

                    db.SaveChanges();
                    loadData();
                }
            }
            else
            {
                labelMaLoi.Content = "Không tìm thấy mã nhân viên";
            }
        }

        private void buttonXoa_Click(object sender, RoutedEventArgs e)
        {
            var exitsItem = (from nv in db.Nhanviens
                             where nv.MaNv.Equals(textBoxMaNV.Text.Trim())
                             select nv).SingleOrDefault();
            if (exitsItem != null)
            {
                var deleteAction = MessageBox.Show("Bạn có đồng ý xoá?", "Xác nhận", MessageBoxButton.YesNo);
                if (deleteAction == MessageBoxResult.Yes)
                {
                    db.Nhanviens.Remove(exitsItem);
                    db.SaveChanges();
                    loadData();
                }
            }
            else
            {
                labelMaLoi.Content = "Không tìm thấy mã nhân viên";
            }
        }

        private void buttonTim_Click(object sender, RoutedEventArgs e)
        {
            Window1 window1 = new();
            window1.Show();
        }
    }
}
