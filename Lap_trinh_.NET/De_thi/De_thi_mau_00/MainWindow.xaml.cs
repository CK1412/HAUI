using De_thi_mau_00.model;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace De_thi_mau_00
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        SALESMANAGEMENTContext db = new();
        List<Category> categories = new();
        public MainWindow()
        {
            InitializeComponent();
        }
        private void refreshData()
        {
            var products = from pro in db.Products
                           where pro.Quantity <= 150
                           orderby pro.ProductName ascending
                           select new
                           {
                               ProductID = pro.ProductId,
                               ProductName = pro.ProductName,
                               CategoryID = pro.CatId,
                               UnitPrice = pro.UnitPrice,
                               Quantity = pro.Quantity,
                               Amount = pro.UnitPrice * pro.Quantity,
                           };
            dataGrid.ItemsSource = products.ToList();
        }
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            refreshData();

            categories = (from cate in db.Categories
                          select cate).ToList<Category>();
            comboBoxCategory.ItemsSource = categories;
            comboBoxCategory.DisplayMemberPath = "CatName";
            comboBoxCategory.SelectedValuePath = "CatID";

            textBoxProductID.Focus();
        }
        private void dataGrid_SelectedCellsChanged(object sender, SelectedCellsChangedEventArgs e)
        {
            dynamic selectedItem = dataGrid.SelectedItem;
            if (selectedItem != null)
            {
                textBoxProductID.Text = selectedItem.ProductID;
                textBoxProductName.Text = selectedItem.ProductName;
                textBoxQuantity.Text = selectedItem.Quantity.ToString();
                textBoxUnitPrice.Text = selectedItem.UnitPrice.ToString();
                comboBoxCategory.SelectedIndex = categories.Select(e => e.CatId).ToList().IndexOf(selectedItem.CategoryID);
            }
        }

        private void buttonInsert_Click(object sender, RoutedEventArgs e)
        {
            if (isCheckValidateInput())
            {
                var testProduct = (from pro in db.Products
                            where pro.ProductId.Equals(textBoxProductID.Text.Trim())
                            select pro).SingleOrDefault();
                if(testProduct != null)
                {
                    MessageBox.Show("Mã sản phẩm đã tồn tại", "Cảnh báo", MessageBoxButton.OK, MessageBoxImage.Warning);
                    return;
                }
                else
                {
                    Product newProduct = new();
                    newProduct.ProductId = textBoxProductID.Text.Trim();
                    newProduct.ProductName = textBoxProductName.Text.Trim();
                    newProduct.UnitPrice = Convert.ToInt32(textBoxUnitPrice.Text);
                    newProduct.Quantity = Convert.ToInt32(textBoxQuantity.Text);
                    newProduct.CatId = (comboBoxCategory.SelectedItem as Category).CatId;

                    db.Products.Add(newProduct);
                    db.SaveChanges();
                    refreshData();
                }

            }
        }

        private bool isCheckValidateInput()
        {
            labelErrorMsg.Content = "";
            string productID = textBoxProductID.Text.Trim();
            string productName = textBoxProductName.Text.Trim();
            string quantity = textBoxQuantity.Text.Trim();
            string unitPrice = textBoxUnitPrice.Text.Trim();
            var category = comboBoxCategory.SelectedItem as Category;
            if (productID == "" || productName == "" || quantity == "" || unitPrice == "" || category == null)
            {
                labelErrorMsg.Content = "Vui lòng nhập đủ các trường";
                return false;
            }
            if (!Regex.IsMatch(quantity, @"^\d*[1-9]{1}\d*$") || !Regex.IsMatch(unitPrice, @"^\d*[1-9]{1}\d*$"))
            {
                labelErrorMsg.Content = " Quantity và Unit Price phải là số nguyên dương.";
                return false;
            }
            return true;
        }

        private void buttonUpdate_Click(object sender, RoutedEventArgs e)
        {
            var product = (from pro in db.Products
                           where pro.ProductId.Equals(textBoxProductID.Text.Trim())
                           select pro).SingleOrDefault();
            if(product == null)
            {
                MessageBox.Show($"Không tìm thấy sản phẩm", "Thông báo", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            else
            {
                if (isCheckValidateInput())
                {
                    product.ProductName = textBoxProductName.Text.Trim();
                    product.UnitPrice = Convert.ToInt32(textBoxUnitPrice.Text);
                    product.Quantity = Convert.ToInt32(textBoxQuantity.Text);
                    product.CatId = (comboBoxCategory.SelectedItem as Category).CatId;

                    db.SaveChanges();
                    refreshData();
                }
            }
        }

        private void buttonDelete_Click(object sender, RoutedEventArgs e)
        {
            var product = (from pro in db.Products
                           where pro.ProductId.Equals(textBoxProductID.Text.Trim())
                           select pro).SingleOrDefault();
            if (product == null)
            {
                MessageBox.Show($"Không tìm thấy sản phẩm", "Thông báo", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            else
            {
                var deleteAction = MessageBox.Show("Bạn có đồng ý xoá?", "Xác nhận", MessageBoxButton.YesNo);
                if (deleteAction == MessageBoxResult.Yes)
                {
                    db.Products.Remove(product);
                    db.SaveChanges();
                    refreshData();
                }
            }
        }

        private void buttonSearch_Click(object sender, RoutedEventArgs e)
        {
            Window1 window1 = new Window1();
            window1.Show();
        }
    }
}
