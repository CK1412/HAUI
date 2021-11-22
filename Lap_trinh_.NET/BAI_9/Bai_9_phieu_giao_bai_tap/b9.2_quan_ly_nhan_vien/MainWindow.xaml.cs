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

namespace b9._2_quan_ly_nhan_vien
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
            string name = txtBoxName.Text;
            string gender = cbBoxGender.Text;
            string department = cbBoxDepartment.Text;
            if (name != "")
            {
                string text = $"{name} - {gender} - {department}";
                listBoxShow.Items.Add(text);
            }
        }
    }
}
