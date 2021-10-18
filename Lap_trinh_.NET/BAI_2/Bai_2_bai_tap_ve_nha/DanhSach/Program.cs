using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DanhSach
{
    class Program
    {
        static void Main(string[] args)
        {
            var ThanhPho = new List<string>() { 
                "Ha Noi", "Hai Phong", "Da Nang", "Ho Chi Minh", "Can Tho"
            };

            Console.Write("Danh sach da sap xep theo thu tu tang dan: ");
            ThanhPho.Sort();
            foreach(var city in ThanhPho)
            {
                Console.Write(city + ", ");
            }

            ThanhPho.Remove("Ha Noi");
            Console.WriteLine("\nDa xoa thanh pho Ha Noi va them 5 thanh pho khac");
            ThanhPho.AddRange(new List<string>{ "Hue","Nha Trang","Vinh","Bien Hoa","Qui Nhơn"});
            Console.WriteLine("\nDanh sach moi: ");
            foreach(string city in ThanhPho)
            {
                Console.Write(city + ", ");
            }
            Console.WriteLine();
        }
    }
}
