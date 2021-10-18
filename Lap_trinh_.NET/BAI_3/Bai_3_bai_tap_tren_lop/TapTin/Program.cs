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
                StreamReader streamReader = new StreamReader("original_file.txt");
                string str = streamReader.ReadToEnd();
                streamReader.Close();

                StreamWriter streamWriter = new StreamWriter("new_file.txt");
                streamWriter.WriteLine(str.ToUpper());
                int countWord = 0;
                string[] arr = str.Trim().Replace("  ", " ").Split(' ');
                countWord = arr.Length;
                streamWriter.WriteLine("\nSo tu cua file: " + countWord);

                Console.WriteLine("Da ghi vao file \"new_file.txt\" thanh cong.");
                streamWriter.Close();
            }
            catch (FileNotFoundException e)
            {
                Console.WriteLine("Khong tim thay file.");
            }
        }
    }
}
