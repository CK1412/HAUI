using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace De_01
{
    class Vehicle
    {
        private string hangSX;
        private string mauSac;

        public string HangSX
        {
            get => hangSX;
            set => hangSX = value;
        }
        public string MauSac
        {
            get => mauSac;
            set => mauSac = value;
        }

        public virtual void nhap()
        {
            Console.Write(" hang san xuat: ");
            hangSX = Console.ReadLine();
            Console.Write(" mau sac: ");
            mauSac = Console.ReadLine();
        }
    }
}
