using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai1
{
    class Program
    {
        static void Main(string[] args)
        {
            StudentManagement studentManagement = new StudentManagement();

            Console.WriteLine("-------------MENU-------------");
            Console.WriteLine("\t1. Them mot sinh vien");
            Console.WriteLine("\t2. Hien thi danh sach sinh vien");
            Console.WriteLine("\t3. Tim kiem sinh vien theo id");
            Console.WriteLine("\t4. Tim kiem sinh vien theo address");
            Console.WriteLine("\t5. Xoa mot sinh vien theo id");
            Console.WriteLine("\t6. Ket thuc chuong trinh");

            int selected;
            bool isRunning = true;

            while (isRunning)
            {
                try
                {
                    Console.WriteLine("------------------------------");
                    Console.Write("Nhap lua chon cua ban: ");
                    selected = Convert.ToInt32(Console.ReadLine());

                    switch (selected)
                    {
                        case 1:
                            studentManagement.themSV();
                            break;
                        case 2:
                            studentManagement.hienThiDSSV();
                            break;
                        case 3:
                            studentManagement.timTheoID();
                            break;
                        case 4:
                            studentManagement.timTheoAddress();
                            break;
                        case 5:
                            studentManagement.xoaTheoID();
                            break;
                        case 6:
                            isRunning = false;
                            Console.WriteLine("Dong thanh cong chuong trinh");
                            break;
                    }
                }
                catch
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Vua co loi xay ra, vui long thuc hien lai thao tac.");
                    Console.ResetColor();
                }
            }
        }



    }
}
