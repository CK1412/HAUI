using System;
using System.Collections.Generic;
using System.ComponentModel;
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

namespace b9._1_chuong_trinh_chon_sach
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<String> books = new List<string>() {
                "Công nghệ thực tại ảo",
                "Đảm bảo chất lượng phần mềm",
                "Giải thuật di truyền và ứng dụng",
                "Hệ chuyên gia",
                "Lập trình căn bản",
                "Lập trình hướng đối tượng",
                "Lập trình mạng",
                "Lập trình trên window",
                "Một số phương pháp tính toán phần mềm",
                "Nhập môn tin học",
                "Phân tích thiết kế hệ thống",
                "Phân tích và thống kê số liệu",
                "Thiết kế Cơ sở dữ liệu",
                "Thiết kế trang web",
                "Tin văn phòng",
        };
        public MainWindow()
        {
            InitializeComponent();

            listBoxLeft.ItemsSource = books;
        }

        private void btnExit_Click(object sender, RoutedEventArgs e)
        {
            var showBox = MessageBox.Show("Bạn có muốn thoát chương trình?", "Thông báo", MessageBoxButton.YesNo);
            if (showBox == MessageBoxResult.Yes)
            {
                this.Close();
            }
        }

        private void btnToRight_Click(object sender, RoutedEventArgs e)
        {
            string text = listBoxLeft.SelectedItem.ToString();
            if (listBoxRight.Items.Contains(text))
            {
                MessageBox.Show("Sách đã được thêm.");
            }
            else
            {
                listBoxRight.Items.Add(text);
            }

        }

        private void btnALlToRight_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                listBoxRight.Items.Clear();
                foreach (var item in listBoxLeft.Items)
                {
                    listBoxRight.Items.Add(item);
                }
            }
            catch
            {
                return;
            }
        }

        private void btnToLeft_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                listBoxRight.Items.Remove(listBoxRight.SelectedItem);
            }
            catch
            {
                return;
            }
        }

        private void btnAllToLeft_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                listBoxRight.Items.Clear();
            }
            catch
            {
                return;
            }
        }
    }
}
