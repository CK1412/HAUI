using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TapTin
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string fileName = "matran.txt";
                StreamReader streamReader = new StreamReader(fileName);
                int row = Convert.ToInt32(streamReader.ReadLine());
                int colum = Convert.ToInt32(streamReader.ReadLine());
                int[,] matrixValues = new int[row, colum];
                int totalValue = 0;

                Console.WriteLine("Ta doc tu file duoc ma tran sau:");
                for (int i = 0; i < row; i++)
                {
                    Console.Write("\t");
                    for (int j = 0; j < colum; j++)
                    {
                        matrixValues[i, j] = Convert.ToInt32(streamReader.ReadLine());
                        Console.Write(matrixValues[i, j] + "  ");
                        totalValue += matrixValues[i, j];
                    }
                    Console.WriteLine();
                }
                streamReader.Close();
                
                Console.WriteLine("Tong cac phan tu cua ma tran: " + totalValue);

                StreamWriter streamWriter = new StreamWriter(fileName, true);
                streamWriter.WriteLine("Tong cac phan tu cua ma tran: " + totalValue);
                streamWriter.Close();
            }
            catch(Exception e)
            {
                Console.WriteLine("Ban da gap loi: " + e.Message);
            }


        }
    }
}
