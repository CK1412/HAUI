using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai3
{
    class Program
    {
        static void Main(string[] args)
        {
            Student s1 = new Student();
            s1.id = "id01";
            s1.name = "Tran Van A";
            s1.mark = 9;
            Console.WriteLine("------Studen 1------");
            s1.print();

        }

        class Student
        {
            public string id { get; set; }
            public string name { get; set; }
            public int mark { get; set; }

            public int scholarship
            {

                get
                {
                    if (mark > 8)
                    {
                        return 500;
                    }
                    else if (mark >= 7)
                    {
                        return 300;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
            public Student()
            {
                id = "";
                name = "";
                mark = 0;
            }

            public Student(string id)
            {
                this.id = id;
            }

            public Student(string id, string name, int mark)
            {
                this.id = id;
                this.name = name;
                this.mark = mark;
            }

            public void print()
            {
                Console.WriteLine("id: " + id);
                Console.WriteLine("name: " + name);
                Console.WriteLine("mark: " + mark);
                Console.WriteLine("scholarship: " + scholarship);
            }
        }
    }
}
