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
            List<Course> courses = new List<Course>();

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("---------------MENU---------------");
            Console.WriteLine("\t1. Them khoa hoc");
            Console.WriteLine("\t2. Hien thi khoa hoc");
            Console.WriteLine("\t3. Tim kiem khoa hoc");
            Console.WriteLine("\t4. Tim kiem sinh vien");
            Console.WriteLine("\t5. Xoa mot khoa hoc");
            Console.WriteLine("\t6. Ket thuc chuong trinh");

            bool isRunning = true;
            int selected;
            while (isRunning)
            {
                try
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("------------------------------");
                    Console.Write("Nhap lua chon: ");
                    selected = Convert.ToInt32(Console.ReadLine());
                    Console.ResetColor();

                    int index = -1;
                    switch (selected)
                    {
                        case 1:
                            Course newCourse = new Course();
                            newCourse.InputCourse();
                            courses.Add(newCourse);
                            break;
                        case 2:
                            if (courses.Count > 0)
                            {
                                for (int i = 0; i < courses.Count; i++)
                                {
                                    Console.WriteLine($"------Course {i + 1}------");
                                    courses[i].DisplayCourseAndStudents();
                                }
                            }
                            else
                            {
                                Console.WriteLine("Hien chua co khoa hoc");
                            }
                            break;
                        case 3:
                            Console.Write("nhap courseId can tim:");
                            string id = Console.ReadLine();

                            index = courses.IndexOf(new Course(id));
                            if (index != -1)
                            {
                                courses[index].DisplayCourseAndStudents();
                            }
                            else
                            {
                                Console.WriteLine("Khong co khoa hoc co courseId " + id);
                            }
                            index = -1;
                            break;
                        case 4:
                            Console.Write("Nhap studentId can tim: ");
                            int studentId = Convert.ToInt32(Console.ReadLine());
                            foreach (var course in courses)
                            {
                                List<Student> students = course.GetAllStudent();
                                index = students.IndexOf(new Student(studentId));
                                if (index != -1)
                                {
                                    students[index].OutputStudent();
                                    break;
                                }
                            }
                            if (index == -1)
                            {
                                Console.WriteLine("Khong co sinh vien co id " + studentId);
                            }
                            index = -1;
                            break;
                        case 5:
                            Console.Write("nhap courseId can xoa:");
                            id = Console.ReadLine();

                            index = courses.IndexOf(new Course(id));
                            if (index != -1)
                            {
                                courses.RemoveAt(index);
                                Console.WriteLine("Da xoa thanh cong khoa hoc co courseId " + id);
                            }
                            else
                            {
                                Console.WriteLine("Khong co khoa hoc co courseId " + id);
                            }
                            index = -1;
                            break;
                        case 6:
                            isRunning = false;
                            Console.WriteLine("Da dong thanh cong chuong trinh");
                            break;
                    }
                }
                catch
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Vua xay ra loi, vui long thao tac lai!");
                    Console.ResetColor();
                }
            }

        }
    }
}
