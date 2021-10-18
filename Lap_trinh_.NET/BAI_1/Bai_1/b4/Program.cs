using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace b4
{
    class Program
    {
        static void Main(string[] args)
        {
            String hoTen, xepLoai;
            double diem;


            Console.Write("Ho va ten: ");
            hoTen = Console.ReadLine();
            
            do
            {
                Console.Write("Diem thi cuoi ki: ");
                diem = Convert.ToDouble(Console.ReadLine());
            } while (diem < 0 || diem > 10);

            if (diem >= 8)
            {
                xepLoai = "Gioi";

            }
            else if (diem >= 6.5 && diem < 8)
            {
                xepLoai = "Kha";
            }
            else if (diem >= 5 && diem < 6.5) { 
                xepLoai = "Trung binh"; 
            } 
            else { 
                xepLoai = "Yeu"; 
            }

            
            Console.WriteLine("\nHo va ten: " + hoTen.ToUpper());
            Console.WriteLine("Ket qua xep loai: " + xepLoai);

        }
    }
}
