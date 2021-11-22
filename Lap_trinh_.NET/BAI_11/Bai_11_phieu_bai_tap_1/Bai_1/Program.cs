using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            var brands = new List<Brand>()
            {
            new Brand(1,"Vingroup"),
            new Brand(2,"Samsung"),
            new Brand(3,"FPT"),
            };

            var products = new List<Product>()
            {
                new Product(1,"O to",400,new string[]{"Do","Trang","Den"},1),
                new Product(2,"Dien thoai",400,new string[]{"Den","Xanh",},2),
                new Product(3,"May giat",500,new string[]{"Trang"},2),
                new Product(4,"Tu lanh",200,new string[]{"Trang","Xam"},2),
                new Product(5,"Laptop",300,new string[]{"Xam","Den","Do"},3),
                new Product(6,"Dieu hoa",500,new string[]{"Trang"},2),
                new Product(7,"Xe may",600,new string[]{"Trang"},1),
            };

            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("\n1. in ra danh sách các sản phẩm\n");
            Console.ResetColor();
            var result1 = from product in products
                          select product;
            //var result = products.Select(product => product);
            foreach (var item in result1)
            {
                Console.WriteLine(item);
            }

            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("\n2. Chỉ lấy ra 1 loại dữ liệu của phần tử, ví dụ lấy tên sản phẩm\n");
            Console.ResetColor();
            var result2 = from product in products
                          select product.Name;
            //var result2 = products.Select(product => product.Name);
            foreach (var name in result2)
            {
                Console.WriteLine(name);
            }

            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("\n3. Trả về kiểu vô danh với toán tử new\n");
            Console.ResetColor();
            var result3 = from product in products
                          select new
                          {
                              ten = product.Name.ToUpper(),
                              mausac = string.Join(",", product.Colors)
                          };
            //var result3 = products.Select(product => new { 
            //    ten = product.Name.ToUpper(), 
            //    mausac = string.Join(",", product.Colors) 
            //});
            foreach (var item in result3)
            {
                Console.WriteLine(item.ten + " - " + item.mausac);
            }

            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("\n4. In ra các sản phẩm có giá 400\n");
            Console.ResetColor();
            var result4 = from product in products
                          where product.Price == 400
                          select product;
            //var result4 = products.Where(product => product.Price == 400);
            foreach (var item in result4)
            {
                Console.WriteLine(item);
            }

            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("\n5. In ra các sp có giá >=500 và < 600 hoặc tên sp có kí tự e\n");
            Console.ResetColor();
            var result5 = from product in products
                          where (product.Price >= 500 && product.Price < 600) || product.Name.Contains("e")
                          select product;
            //var result5 = products.Where(product => 
            //    (product.Price >= 500 && product.Price < 600) 
            //    || product.Name.Contains("e")
            //);
            foreach (var item in result5)
            {
                Console.WriteLine(item);
            }

            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("\n6. In ra tên và giá các sp, danh sách sắp xếp theo giá giảm dần\n");
            Console.ResetColor();
            var result6 = from product in products
                          orderby product.Price descending
                          select product;
            //var result6 = products.OrderByDescending(product => product.Price);
            foreach (var item in result6)
            {
                Console.WriteLine(item.Name + " - " + item.Price);
            }

            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("\n7. Lấy sp có giá <= 500, nhóm lại theo thương hiệu(cùng Brand cho vào 1 nhóm)\n");
            Console.ResetColor();
            var result7 = from product in products
                          where product.Price <= 500
                          group product by product.Brand;
            //var result7 = products.Where(product => product.Price <= 500).GroupBy(product => product.Brand);
            foreach (var group in result7)
            {
                Console.WriteLine(group.Key);
                foreach (var item in group)
                {
                    Console.WriteLine($"\t{item.Name} - {item.Price}");
                }
            }

            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("\n8. Truy vấn sp, mỗi sp căn cứ vào Brand ID của nó - lấy tên Brand tương ứng\n");
            Console.ResetColor();
            var result8 = from product in products
                          join brand in brands on product.Brand equals brand.ID
                          select new
                          {
                              name = product.Name,
                              price = product.Price,
                              brand = brand.Name,
                          };
            //var result8 = products.Join(brands, product => product.Brand, brand => brand.ID,
            //                                (product, brand) => new
            //                                {
            //                                    name = product.Name,
            //                                    price = product.Price,
            //                                    brand = brand.Name,
            //                                });
            foreach (var item in result8)
            {
                Console.WriteLine($"{item.name,10}{item.price,5}{item.brand,10}");
            }
        }
    }
}
