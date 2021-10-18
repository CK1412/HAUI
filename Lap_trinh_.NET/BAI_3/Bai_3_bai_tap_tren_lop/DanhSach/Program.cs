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
            int n = 0;
            List<double> numbers = new List<double>();

            Console.WriteLine("Nhap 5 phan tu:");
            try
            {
                do
                {
                    numbers.Add(Convert.ToDouble(Console.ReadLine()));
                    n++;
                } while (n < 5);

                numbers.Sort();
                Console.WriteLine("\nDa sap xep danh sach theo thu tu tang dan.");
                Console.Write("Danh sach moi: ");
                hienThi(numbers);

                numbers = numbers.Where((value) => value >= 0).ToList();
                Console.WriteLine("\nDa xoa các so am trong danh sach.");
                Console.Write("Danh sach moi: ");
                hienThi(numbers);

                double x;
                Console.Write("\nNhap x = ");
                x = Convert.ToDouble(Console.ReadLine());
                for (int i = 0; i < numbers.Count; i++)
                {
                    if (x < numbers[i])
                    {
                        numbers.Insert(i, x);
                        break;
                    }

                }
                Console.WriteLine("Da chen x vao danh sach.");
                Console.Write("Danh sach moi: ");
                hienThi(numbers);
            }
            catch (FormatException e)
            {
                Console.WriteLine(e.Message);
            }
        }

        static void hienThi(List<double> numbers)
        {
            foreach (double number in numbers)
            {
                Console.Write(number + " ");
            }
            Console.WriteLine();
        }
    }
}
