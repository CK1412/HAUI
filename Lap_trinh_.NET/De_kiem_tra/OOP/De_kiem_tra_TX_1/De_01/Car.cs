using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace De_01
{
    class Car:Vehicle
    {
        private string bienSo;
        private string dongXe;
        private string phienBan;
        private double giaCoBan;

        public string BienSo
        {
            get => bienSo;
            set => bienSo = value;
        }
        public string DongXe
        {
            get => dongXe;
            set => dongXe = value;
        }
        public string PhienBan
        {
            get => phienBan;
            set => phienBan = value;
        }
        public double GiaCoBan
        {
            get => giaCoBan;
            set => giaCoBan = value;
        }

        public override void nhap()
        {
            base.nhap();
            Console.Write(" bien so: ");
            bienSo = Console.ReadLine();
            Console.Write(" dong xe: ");
            dongXe = Console.ReadLine();
            Console.Write(" phien ban: ");
            phienBan = Console.ReadLine();
            Console.Write(" gia co ban: ");
            giaCoBan = Convert.ToDouble(Console.ReadLine());
        }

        public double tinhGiaXe()
        {
            double x = 0;
            switch (phienBan.ToLower())
            {
                case "standard":
                    x = 0;
                    break;
                case "premium":
                    x = 2000;
                    break;
                case "deluxe":
                    x = 5000;
                    break;
                case "luxury":
                    x = 10000;
                    break;
            }
            return giaCoBan + x;
        }
    }
}
