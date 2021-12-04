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
using System.Windows.Shapes;

namespace KTTX2_de_3
{
    /// <summary>
    /// Interaction logic for Window2.xaml
    /// </summary>
    public partial class Window2 : Window
    {
        List<string> texts;
        public Window2(string text)
        {
            InitializeComponent();
            this.texts = text.Split(" - ").ToList();
            textBoxHoTenNV.Text = texts[0];
            comboBoxLoaiNV.Text = texts[2];
            datePickerNgaySinh.Text = texts[1];
            textBoxSoTienBanHang.Text = texts[3].Split(":").ToList().Last();
        }

        private void buttonThoat_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
