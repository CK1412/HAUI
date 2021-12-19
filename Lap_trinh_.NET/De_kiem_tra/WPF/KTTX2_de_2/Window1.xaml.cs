using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace KTTX2_de_2
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        ObservableCollection<string> data = new ObservableCollection<string>();
        public Window1(ObservableCollection<string> a)
        {
            InitializeComponent();
            listBox.ItemsSource = a;
            data = a;
        }

        private void buttonXoá_Click(object sender, RoutedEventArgs e)
        {
            if (listBox.SelectedIndex != -1)
            {
                data.Remove(listBox.SelectedItem.ToString());
            }
        }
    }
}
