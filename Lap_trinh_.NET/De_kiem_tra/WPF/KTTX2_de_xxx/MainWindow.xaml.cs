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

namespace KTTX2_de_xxx
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<String> listdiaChi = new List<String>() {
        "Hà Nội",
        "Hải Phòng",
        "Quảng Ninh",
        };

        public MainWindow()
        {
            InitializeComponent();
            comboBoxDiaChi.ItemsSource = listdiaChi;
            textBoxHoTen.Focus();
            datePicker.SelectedDate = DateTime.Now;
        }

        private void buttonThem_Click(object sender, RoutedEventArgs e)
        {
            labelErrorMsg.Content = "";
            string hoTen = textBoxHoTen.Text.Trim();
            string diaChi = comboBoxDiaChi.SelectedItem.ToString();
            string soDienDung = textBoxSoĐienDung.Text.Trim();
            string ngayThang = datePicker.Text.Trim();

            if (hoTen == "")
            {
                labelErrorMsg.Content = "Vui lòng nhập họ tên";
                return;
            }
            if (soDienDung == "")
            {
                labelErrorMsg.Content = "Vui lòng nhập số điện";
                return;
            }
            if (!Regex.IsMatch(soDienDung, "^\\d*$"))
            {
                labelErrorMsg.Content = "Vui lòng nhập số điện là số dương";
                return;
            }
            int x = Convert.ToInt32(soDienDung);
            if (x < 10 || x > 100)
            {
                labelErrorMsg.Content = "Số điện phải >= 10 và <= 100";
                return;
            }
            if (ngayThang == "")
            {
                labelErrorMsg.Content = "Vui lòng nhập ngày tháng";
                return;
            }

            string text = $"{hoTen} - {diaChi} - {soDienDung} - {x * 500} - {ngayThang}";
            listBoxData.Items.Add(text);

        }

        private void buttonDong_Click(object sender, RoutedEventArgs e)
        {
            var showBox = MessageBox.Show("Bạn có muốn thoát chương trình?", "Thông báo", MessageBoxButton.YesNo);
            if (showBox == MessageBoxResult.Yes)
            {
                this.Close();
            }
        }

        private void buttonXoa_Click(object sender, RoutedEventArgs e)
        {
            textBoxHoTen.Text = "";
            textBoxSoĐienDung.Text = "";
            datePicker.SelectedDate = DateTime.Now;
            comboBoxDiaChi.SelectedIndex = 0;
            textBoxHoTen.Focus();
        }

        private void buttonChiTiet_Click(object sender, RoutedEventArgs e) 
        {
            if(listBoxData.SelectedIndex != -1)
            {
                var text = listBoxData.SelectedItem.ToString();
                Window1 window1 = new Window1(text);
                window1.Show();
            }
        }
    }
}
