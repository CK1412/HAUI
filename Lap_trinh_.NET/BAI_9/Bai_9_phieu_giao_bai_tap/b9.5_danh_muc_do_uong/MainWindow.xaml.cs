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

namespace b9._5_danh_muc_do_uong
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            WindowStartupLocation = System.Windows.WindowStartupLocation.CenterScreen;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

            if (chkBoxOrangeJuice.IsChecked == false && chkBoxMangoJuice.IsChecked==false
                && chkBoxKiwiJuice.IsChecked==false && chkBoxFreshMilk.IsChecked==false
                && chkBoxCoffee.IsChecked==false)
            {
                MessageBox.Show("Bạn chưa chọn đồ uống nào");
            }
            else
            {
                string text = "";
                if (chkBoxOrangeJuice.IsChecked == true)
                    text += (text == "") ? "Nước cam tươi" : ", Nước cam tươi";
                if (chkBoxKiwiJuice.IsChecked == true)
                    text += (text == "") ? "Nước kiwi ép" : ", Nước kiwi ép";
                if (chkBoxMangoJuice    .IsChecked == true)
                    text += (text == "") ? "Nước xoài ép" : ", Nước xoài ép";
                if (chkBoxFreshMilk.IsChecked == true)
                    text += (text == "") ? "Sữa tươi" : ", Sữa tươi";
                if (chkBoxCoffee.IsChecked == true)
                    text += (text == "") ? "Cà phê Espresso" : ", Cà phê Espresso";
                MessageBox.Show($"Bạn đã chọn {text}.");
            }
        }
    }
}
