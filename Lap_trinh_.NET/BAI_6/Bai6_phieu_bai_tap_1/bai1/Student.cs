using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai1
{
    class Student : Person
    {
        public byte maths;
        public byte physics;

        public Student() : base()
        {

        }
        public Student(string name, string address, byte maths, byte physics) : base(name, address)
        {
            this.maths = maths;
            this.physics = physics;
        }
        public int Total()
        {
            return maths + physics;
        }
        public override void Input()
        {
            base.Input();
            Console.Write("Maths: ");
            maths = Convert.ToByte(Console.ReadLine());
            Console.Write("Physics: ");
            physics = Convert.ToByte(Console.ReadLine());
        }
        public override void Output()
        {
            base.Output();
            Console.WriteLine("Maths: " + maths);
            Console.WriteLine("Physics: " + physics);
            Console.WriteLine("Total: " + Total());
        }
    }
}
