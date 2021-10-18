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
            List<Vehicles> vehicles = new List<Vehicles>();

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("---------------MENU---------------");
            Console.WriteLine("\t1. Nhap du lieu");
            Console.WriteLine("\t2. Hien thi du lieu");
            Console.WriteLine("\t3. Tim kiem theo id");
            Console.WriteLine("\t4. Tim kiem theo maker");
            Console.WriteLine("\t5. Sap xep theo price");
            Console.WriteLine("\t6. Sap xep theo year");
            Console.WriteLine("\t7. Ket thuc");

            bool isRunning = true;
            int selected;

            while (isRunning)
            {
                try
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("----------------------------------");
                    Console.Write("Nhap lua chon: ");
                    selected = Convert.ToInt32(Console.ReadLine());
                    Console.ResetColor();

                    switch (selected)
                    {
                        case 1:
                            vehicles.Add(new Car("vh1", "maker 1", "car 1", 2021, 300000000, "blue"));
                            vehicles.Add(new Car("vh2", "maker 2", "car 2", 2020, 550000000, "black"));
                            vehicles.Add(new Car("vh3", "maker 3", "car 3", 2018, 720000000, "green"));

                            vehicles.Add(new Truck("vh4", "maker 2", "truck 1", 2011, 200000000, 300));
                            vehicles.Add(new Truck("vh5", "maker 4", "truck 2", 2020, 430000000, 200));
                            vehicles.Add(new Truck("vh6", "maker 3", "truck 3", 2016, 310000000, 120));

                            Console.WriteLine("Da them 3 Car va 3 Truck");
                            break;
                        case 2:
                            xuatDanhSach(vehicles);
                            break;
                        case 3:
                            Console.Write("Nhap id can tim: ");
                            string id = Console.ReadLine();

                            int index = vehicles.IndexOf(new Vehicles(id));
                            if (index == -1)
                            {
                                Console.WriteLine($"Khong co id {id} trong danh sach.");
                            }
                            else
                            {
                                vehicles[index].Output();
                            }
                            break;
                        case 4:
                            Console.Write("Nhap maker can tim: ");
                            string maker = Console.ReadLine();

                            List<Vehicles> vehicles1 = new List<Vehicles>();
                            foreach (var vehicle in vehicles)
                            {
                                if (vehicle.maker.Equals(maker))
                                {
                                    vehicles1.Add(vehicle);
                                }
                            }
                            if (vehicles1.Count > 0)
                            {
                                xuatDanhSach(vehicles1);
                            }
                            else
                            {
                                Console.WriteLine("Khong xe nao cua hang " + maker);
                            }
                            break;
                        case 5:
                            Console.WriteLine("--------DANH SACH TRUOC KHI SAP XEP--------");
                            xuatDanhSach(vehicles);

                            vehicles.Sort();

                            Console.WriteLine("--------DANH SACH SAU KHI SAP XEP THEO PRICE--------");
                            xuatDanhSach(vehicles);
                            break;
                        case 6:
                            Console.WriteLine("--------DANH SACH TRUOC KHI SAP XEP--------");
                            xuatDanhSach(vehicles);

                            vehicles.Sort(new CompareToYear());

                            Console.WriteLine("--------DANH SACH SAU KHI SAP XEP THEO YEAR--------");
                            xuatDanhSach(vehicles);
                            break;
                        case 7:
                            isRunning = false;
                            Console.WriteLine("Dong thanh cong chuong trinh");
                            break;
                    }
                }
                catch
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Vua xay ra loi, Vui long thao tac lai!");
                    Console.ResetColor();
                }
            }
        }

        public static void xuatDanhSach(List<Vehicles> vehicles)
        {
            foreach (var vehicle in vehicles)
            {
                Console.WriteLine(vehicle);
            }
        }
    }
}
