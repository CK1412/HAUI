using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KiemTra1
{
    class Person
    {
        private string hoTen;
        private string dienThoai;
        public string Hoten
        {
            get => hoTen;
            set => hoTen = value;
        }
        public string DienThoai
        {
            get => dienThoai;
            set => dienThoai = value;
        }
        public Person() { }
        public virtual void nhap()
        {
            Console.Write(" ho ten: ");
            hoTen = Console.ReadLine();
            Console.Write(" dien thoai: ");
            dienThoai = Console.ReadLine();
        }
    }
}
