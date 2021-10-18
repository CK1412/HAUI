using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai1
{
    class Student
    {
        public int studentId;
        public string name;
        public string mark;

        public Student() { }
        public Student(int id)
        {
            this.studentId = id;
        }
        public override string ToString()
        {
            return string.Format("{0,-10}{1,-20}{2,-10}", studentId, name, mark);
        }
        public void InputStudent()
        {
            Console.Write(" student id: ");
            studentId = Convert.ToInt32(Console.ReadLine());
            Console.Write(" name: ");
            name = Console.ReadLine();
            Console.Write(" mark: ");
            mark = Console.ReadLine();
        }

        public void OutputStudent()
        {
            Console.WriteLine("Student id: " + studentId);
            Console.WriteLine("name: " + name);
            Console.WriteLine("mark: " + mark);
        }
        public override bool Equals(object obj)
        {
            Student x = (Student)obj;
            return this.studentId.Equals(x.studentId);
        }
        public override int GetHashCode()
        {
            return 0;
        }
    }
}
