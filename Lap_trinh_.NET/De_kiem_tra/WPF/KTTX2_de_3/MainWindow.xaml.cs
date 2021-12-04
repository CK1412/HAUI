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

namespace KTTX2_de_3
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<string> loaiNVs = new List<string>() {
        "Cơ hữu",
        "Hợp đồng",
        "Cộng tác viên",
        };
        public MainWindow()
        {
            InitializeComponent();
            comboBoxLoaiNV.ItemsSource = loaiNVs;
            datePickerNgaySinh.SelectedDate = DateTime.Now;
            textBoxHoTenNV.Focus();
        }

        private void buttonNhap_Click(object sender, RoutedEventArgs e)
        {
            labelErrorText.Content = "";

            string hoTen = textBoxHoTenNV.Text.Trim();
            string loaiNV = comboBoxLoaiNV.SelectedItem != null ? comboBoxLoaiNV.SelectedItem.ToString() : "";
            string ngaySinh = datePickerNgaySinh.Text;
            string soTienBH = textBoxSoTienBanHang.Text;

            if (hoTen == "")
            {
                labelErrorText.Content = "Vui lòng nhập họ tên nhân viên";
                return;
            }
            if (loaiNV == "")
            {
                labelErrorText.Content = "Vui lòng chọn loại nhân viên";
                return;
            }
            if (ngaySinh == "")
            {
                labelErrorText.Content = "Vui lòng nhập ngày sinh";
                return;
            }
            int tuoi = DateTime.Now.Year - datePickerNgaySinh.SelectedDate.Value.Year;
            if (tuoi < 18 || tuoi > 60)
            {
                labelErrorText.Content = "Tuổi phải >= 18 và <= 60";
                return;
            }
            if (soTienBH == "")
            {
                labelErrorText.Content = "Vui lòng nhập số tiền bán hàng";
                return;
            }
            if (!Regex.IsMatch(soTienBH, @"^\d+\.?(\d+|\d*)$"))
            {
                labelErrorText.Content = "Số tiền bán hàng phải là số thực";
                return;
            }
            double x = Convert.ToDouble(soTienBH);
            if (x <= 0)
            {
                labelErrorText.Content = "Số tiền bán hàng phải > 0";
                return;
            }

            string text = $"{hoTen} - {ngaySinh} - {loaiNV} - Tiền bán hàng: {x} - Hoa hồng: {tienHoaHong(x)}";
            listBoxData.Items.Add(text);

        }

        private void buttonXoa_Click(object sender, RoutedEventArgs e)
        {
            textBoxHoTenNV.Text = "";
            datePickerNgaySinh.SelectedDate = DateTime.Now;
            comboBoxLoaiNV.SelectedIndex = -1;
            textBoxHoTenNV.Focus();
            textBoxSoTienBanHang.Text = "";
        }

        private void buttonWindow2_Click(object sender, RoutedEventArgs e)
        {
            if (listBoxData.SelectedIndex != -1)
            {
                Window2 window2 = new Window2(listBoxData.SelectedItem.ToString());
                window2.Show();
            }
        }

        double tienHoaHong(double x)
        {
            if (x < 1000)
                return 0;
            else if (x > 5000)
                return x * 20 / 100;
            else
                return x * 10 / 100;
        }
    }
}
