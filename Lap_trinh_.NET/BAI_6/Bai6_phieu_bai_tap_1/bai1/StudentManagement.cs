using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai1
{
    class StudentManagement
    {
        public List<Student> students = new List<Student>();

        public void themSV()
        {
            Console.WriteLine("Nhap sinh vien can them: ");
            Student x = new Student();
            x.Input();
            students.Add(x);
        }

        public void hienThiDSSV()
        {
            if (students.Count < 1)
            {
                Console.WriteLine("Danh sach sinh vien dang rong.");
                return;
            }
            Console.WriteLine("{0,-10}{1,-20}{2,-20}{3,-10}{4,-10}{5,-10}",
                "ID", "NAME", "ADDRESS", "MATHS", "PHYSICS", "TOTAL");
            foreach (var student in students)
            {
                Console.WriteLine("{0,-10}{1,-20}{2,-20}{3,-10}{4,-10}{5,-10}",
                    student.id, student.name, student.address, student.maths, student.physics, student.Total());
            }
        }

        public void timTheoID()
        {
            if (students.Count < 1)
            {
                Console.WriteLine("Danh sach sinh vien dang rong.");
                return;
            }
            bool haveFound = false;
            Console.Write("Nhap id sinh vien can tim: ");
            int id = Convert.ToInt32(Console.ReadLine());
            foreach (var student in students)
            {
                if (student.id == id)
                {
                    student.Output();
                    haveFound = true;
                    break;
                }
            }
            if (!haveFound)
            {
                Console.WriteLine("Khong tim thay sinh vien co id " + id);
            }
        }

        public void timTheoAddress()
        {
            if (students.Count < 1)
            {
                Console.WriteLine("Danh sach sinh vien dang rong.");
                return;
            }
            bool haveFound = false;
            Console.Write("Nhap address sinh vien can tim: ");
            string address = Console.ReadLine();
            foreach (var student in students)
            {
                if (student.address.Equals(address))
                {
                    student.Output();
                    haveFound = true;
                    break;
                }
            }
            if (!haveFound)
            {
                Console.WriteLine("Khong tim thay sinh vien co adress " + address);
            }
        }

        public void xoaTheoID()
        {
            if (students.Count < 1)
            {
                Console.WriteLine("Danh sach sinh vien dang rong.");
                return;
            }
            bool haveFound = false;
            Console.Write("Nhap id sinh vien can xoa: ");
            int id = Convert.ToInt32(Console.ReadLine());
            foreach (var student in students)
            {
                if (student.id == id)
                {
                    students.Remove(student);
                    Console.WriteLine("Da xoa sinh vien co id " + id);
                    haveFound = true;
                    break;
                }
            }
            if (!haveFound)
            {
                Console.WriteLine("Khong tim thay sinh vien co id " + id);
            }
        }
    }
}
