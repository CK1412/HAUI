using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai1
{
    class Course
    {
        public string courseId;
        public string courseName;
        public int fee;
        public List<Student> listStd;

        public Course()
        {
            listStd = new List<Student>();
        }
        public Course(string courseId)
        {
            this.courseId = courseId;
        }
        public void InputCourse()
        {
            Console.Write("course id: ");
            courseId = Console.ReadLine();
            Console.Write("course name: ");
            courseName = Console.ReadLine();
            Console.Write("fee: ");
            fee = Convert.ToInt32(Console.ReadLine());
            Console.Write("So sinh vien tham gia khoa hoc: ");
            int n = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("sinh vien thu " + (i+1));
                Student student = new Student();
                student.InputStudent();
                listStd.Add(student);
            }
        }
        public void DisplayCourseAndStudents()
        {
            Console.WriteLine("course id: " + courseId);
            Console.WriteLine("course name: " + courseName);
            Console.WriteLine("fee: " + fee);
            Console.WriteLine("Danh sach sinh vien tham gia:");
            Console.WriteLine("{0,-10}{1,-20}{2,-10}", "ID", "NAME", "MARK");
            foreach (var student in listStd)
            {
                Console.WriteLine(student);
            }
        }

        public List<Student> GetAllStudent() => listStd;

        public override bool Equals(object obj)
        {
            Course x = (Course)obj;
            return this.courseId.Equals(x.courseId);
        }
        public override int GetHashCode()
        {
            return 0;
        }
    }
}
