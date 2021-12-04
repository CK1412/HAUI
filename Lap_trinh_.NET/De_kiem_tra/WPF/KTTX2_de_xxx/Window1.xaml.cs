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
using System.Windows.Shapes;

namespace KTTX2_de_xxx
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        List<string> texts;
        public Window1(string text)
        {
            InitializeComponent();
            this.texts = text.Split(" - ").ToList();

            textBoxHoTen.Text = texts[0];
            comboBoxDiaChi.Text = texts[1];
            textBoxSoĐienDung.Text = texts[2];
            datePicker.Text = texts[4];
        }

        private void buttonDong_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
