using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace KTTX2_de_2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<String> lops = new List<string>() { "KTPM1", "KTPM2", "KTPM3", "KTPM4" };
        ObservableCollection<string> kq = new ObservableCollection<string>();
        public MainWindow()
        {
            InitializeComponent();
            textBoxMaSV.Focus();
            comboBoxLop.ItemsSource = lops;
            comboBoxLop.SelectedIndex = -1;
        }

        private void buttonXoaChon_Click(object sender, RoutedEventArgs e)
        {
            radioButtonLan1.IsChecked = false;
            radioButtonLan2.IsChecked = false;
            textBoxMaSV.Text = "";
            textBoxHoTen.Text = "";
            textBoxKhoa.Text = "";
            comboBoxLop.SelectedIndex = -1;
            checkBoxCSDL.IsChecked = false;
            checkBoxKTLT.IsChecked = false;
            checkBoxKTMT.IsChecked = false;
            checkBoxTACNTT.IsChecked = false;
            checkBoxXSTK.IsChecked = false;
        }

        private void buttonThem_Click(object sender, RoutedEventArgs e)
        {
            string lanThi;
            string maSv = textBoxMaSV.Text.Trim();
            string hoTen = textBoxHoTen.Text.Trim();
            string lop = comboBoxLop.SelectedIndex == -1 ? "" : comboBoxLop.SelectedItem.ToString();
            string khoa = textBoxKhoa.Text.Trim();
            string danhMucHocPhan = "";

            if (radioButtonLan1.IsChecked == true)
            {
                lanThi = "Lần thi 1";
            }
            else if (radioButtonLan2.IsChecked == true)
            {
                lanThi = "Lần thi 2";
            }
            else
            {
                labelErrorMsg.Content = "Vui lòng chọn lần thi";
                return;
            }
            if (maSv == "")
            {
                labelErrorMsg.Content = "Vui lòng nhập mã sinh viên";
                return;
            }
            if (hoTen == "")
            {
                labelErrorMsg.Content = "Vui lòng nhập họ tên";
                return;
            }
            if (lop == "")
            {
                labelErrorMsg.Content = "Vui lòng chọn lớp";
                return;
            }
            if (khoa == "")
            {
                labelErrorMsg.Content = "Vui lòng nhập khoá";
                return;
            }
            if (!Regex.IsMatch(khoa, @"^[1-9]+\d*$"))
            {
                labelErrorMsg.Content = "Khoá học phải là số nguyên dương";
                return;
            }
            if (checkBoxCSDL.IsChecked == true)
            {
                danhMucHocPhan += checkBoxCSDL.Content;
            }
            if (checkBoxKTLT.IsChecked == true)
            {
                danhMucHocPhan += (danhMucHocPhan == "") ? checkBoxKTLT.Content : $" - {checkBoxKTLT.Content}";
            }
            if (checkBoxKTMT.IsChecked == true)
            {
                danhMucHocPhan += (danhMucHocPhan == "") ? checkBoxKTMT.Content : $" - {checkBoxKTMT.Content}";
            }
            if (checkBoxTACNTT.IsChecked == true)
            {
                danhMucHocPhan += (danhMucHocPhan == "") ? checkBoxTACNTT.Content : $" - {checkBoxTACNTT.Content}";
            }
            if (checkBoxXSTK.IsChecked == true)
            {
                danhMucHocPhan += (danhMucHocPhan == "") ? checkBoxXSTK.Content : $" - {checkBoxXSTK.Content}";
            }
            if (danhMucHocPhan == "")
            {
                labelErrorMsg.Content = "Hãy chọn ít nhất 1 học phần ";
                return;
            }
            string text = $"{lanThi} - {maSv} - {hoTen} - {lop} - {khoa} - {danhMucHocPhan}";
            kq.Add(text);
            Window1 window1 = new Window1(kq);
            window1.Show();

        }
    }
}
