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

namespace b9._3_cap_nhat_thanh_vien
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

        private void btnExit_Click(object sender, RoutedEventArgs e)
        {
            var showBox = MessageBox.Show("Bạn có muốn thoát chương trình?", "Thông báo", MessageBoxButton.YesNo);
            if (showBox == MessageBoxResult.Yes)
            {
                this.Close();
            }
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            if (txtBoxName.Text != "")
            {
                string text = $"Họ tên: {txtBoxName.Text}";
                if (radioBtnMale.IsChecked == true)
                    text += "\nGiới tính: Nam";
                else
                    text += "\nGiới tính: Nữ";
                if (radioBtnMarried.IsChecked == true)
                    text += "\nTình trạng hôn nhân: Đã kết hôn";
                else
                    text += "\nTình trạng hôn nhân: Chưa kết hôn";
                if (checkBoxFootball.IsChecked == false && checkBoxSwimming.IsChecked == false 
                    && checkBoxMusic.IsChecked == false && checkBoxMountaineering.IsChecked == false)
                {
                    text += "\nSở thích: không có\n\n";
                }
                else
                {
                    text += "\nSở thích: ";
                    string hoobies = "";
                    if (checkBoxFootball.IsChecked == true)
                        hoobies += (hoobies == "") ? checkBoxFootball.Content : $", {checkBoxFootball.Content}";
                    if (checkBoxMusic.IsChecked == true)
                        hoobies += (hoobies == "") ? checkBoxMusic.Content : $", {checkBoxMusic.Content}";
                    if (checkBoxMountaineering.IsChecked == true)
                        hoobies += (hoobies == "") ? checkBoxMountaineering.Content : $", {checkBoxMountaineering.Content}";
                    if (checkBoxSwimming.IsChecked == true)
                        hoobies += (hoobies == "") ? checkBoxSwimming.Content : $", {checkBoxSwimming.Content}";
                    text += hoobies+"\n\n";
                }
                txtBoxShow.Text += text;
            }
        }
    }
}
