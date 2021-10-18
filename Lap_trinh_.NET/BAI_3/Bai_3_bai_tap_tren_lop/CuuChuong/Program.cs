using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CuuChuong
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 9;
            Console.WriteLine("\t\t---BANG CUU CHUONG---\n");
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= n; j++)
                {
                    Console.Write(String.Format($"{j} * {i} = {j * i}").PadRight(13));
                }
                Console.WriteLine();
            }
        }
    }
}
