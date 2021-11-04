using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace De_01
{
    class Nguoi
    {
        private string hoTen;
        private string diaChi;

        public string Hoten
        {
            get => hoTen;
            set => hoTen = value;
        }
        public string DiaChi
        {
            get => diaChi;
            set => diaChi = value;
        }
        public virtual void nhap()
        {
            Console.Write(" ho ten: ");
            hoTen = Console.ReadLine();
            Console.Write(" dia chi: ");
            diaChi = Console.ReadLine();
        }

    }
}
