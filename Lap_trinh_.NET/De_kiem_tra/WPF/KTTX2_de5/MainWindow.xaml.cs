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

namespace KTTX2_de5
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            textBoxHoTen.Focus();
            datePicker.SelectedDate = DateTime.Now;
        }

        private void buttonNhap_Click(object sender, RoutedEventArgs e)
        {
            labelErrorText.Content = "";
            string hoTen = textBoxHoTen.Text.Trim();
            string soNgayLam = textBoxSoNgayLamViec.Text.Trim();
            string ngayTuyenDung = datePicker.Text;

            if (hoTen == "")
            {
                labelErrorText.Content = "Vui lòng nhập họ tên";
                return;
            }
            if (soNgayLam == "")
            {
                labelErrorText.Content = "Vui lòng nhập số ngày làm";
                return;
            }
            else
            {
                if (!Regex.IsMatch(soNgayLam, @"^\d+\.0*[1-9]+\d*$"))
                {
                    labelErrorText.Content = "Số ngày làm việc phải là số thập phân > 0";
                    return;
                }
            }

            if (DateTime.Now.CompareTo(datePicker.SelectedDate.Value) <= 0) {
                labelErrorText.Content = "Ngày tuyển dụng phải là ngày hiện tại hoặc trước ngày hiện tại.";
                return;
            }

            double x = Convert.ToDouble(soNgayLam);
            string gioiTinh = radioButtonNam.IsChecked == true ? "Nam" : "Nữ";
            string text = $"{hoTen} - {ngayTuyenDung} - {gioiTinh} - Số ngày làm việc: {x} - Tiền lương: {tienLuong(x)}";
            listBox.Items.Add(text);
        }

        double tienLuong(double x)
        {
            if (x <= 10)
                return x * 200000;
            else return 2000000 + (x - 10) * 400000;
        }

        private void buttonXoa_Click(object sender, RoutedEventArgs e)
        {
            textBoxHoTen.Focus();
            datePicker.SelectedDate = DateTime.Now;
            textBoxHoTen.Text = "";
            textBoxSoNgayLamViec.Text = "";
            radioButtonNam.IsChecked = true;
        }

        private void buttonWindow2_Click(object sender, RoutedEventArgs e)
        {
            if (listBox.Items != null)
            {
                Window2 window2 = new Window2(listBox.Items[0].ToString());
                window2.Show();
            }
        }
    }
}
