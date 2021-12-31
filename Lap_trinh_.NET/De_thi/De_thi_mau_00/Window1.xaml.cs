using De_thi_mau_00.model;
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

namespace De_thi_mau_00
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        SALESMANAGEMENTContext db = new();
        public Window1()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            var query1 = from pro in db.Products
                         group pro by pro.CatId into cateGroup
                         select new
                         {
                             CategoryID = cateGroup.Key,
                             TotalMoneyProduct = cateGroup.Sum(x => x.Quantity * x.UnitPrice),
                         };

            var query2 = from cate1 in query1
                         join cate2 in db.Categories on cate1.CategoryID equals cate2.CatId
                         select new
                         {
                             CategoryID = cate1.CategoryID,
                             CategoryName = cate2.CatName,
                             TotalMoneyProduct = cate1.TotalMoneyProduct,
                         };

            dataGrid.ItemsSource = query2.ToList();
        }
    }
}
