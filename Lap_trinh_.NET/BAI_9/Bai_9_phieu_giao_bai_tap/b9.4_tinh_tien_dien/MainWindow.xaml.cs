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

namespace b9._4_tinh_tien_dien
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            List<Customer> customers = new List<Customer>() {
            new Customer("Trần Văn A",15,75),
            new Customer("Trần Văn B",65,155),
            new Customer("Trần Văn C",345,725),
            new Customer("Trần Văn D",5,35),
            };
            cbBoxName.ItemsSource = customers;
            cbBoxName.DisplayMemberPath = "name";
        }

        private void btnCalculated_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                txtBoxTotalMoney.Text = (cbBoxName.SelectedItem as Customer).tongTien().ToString();
            }
            catch
            {
                return;
            }
        }

        private void btnExit_Click(object sender, RoutedEventArgs e)
        {
            var showBox = MessageBox.Show("Bạn có muốn thoát chương trình?", "Thông báo", MessageBoxButton.YesNo);
            if (showBox == MessageBoxResult.Yes)
            {
                this.Close();
            }
        }

        private void btnPrint_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                string text="";
                var customer = cbBoxName.SelectedItem as Customer;
                if(customer!=null)
                {
                    text = customer.name + $"\nSố kw tiêu thụ: {customer.chiSoTieuThu} \nTổng tiền: {customer.tongTien()}";
                }
                txtBlockShow.Text = text;
            }
            catch
            {
                return;
            }
            
        }
    }
}
