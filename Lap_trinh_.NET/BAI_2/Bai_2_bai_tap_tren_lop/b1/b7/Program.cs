using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace System.IO { }

namespace b7
{
    class Program
    {
        static void Main(string[] args)
        {
            string outputFileName = "file.txt";
            StreamWriter streamWriter = null;
            StreamReader streamReader = null;

            writeFile(streamWriter, outputFileName);
            readFile(streamReader, outputFileName);
        }

        static void writeFile(StreamWriter streamWriter, string fileName)
        {
            try
            {
                streamWriter = new StreamWriter(fileName);
                streamWriter.WriteLine("Hello World");
                streamWriter.WriteLine("I'm a robot");
            }
            catch (Exception e)
            {
                Console.WriteLine("Can not open file" + fileName);
                Console.WriteLine("Error: " + e.Message);
            }
            finally
            {
                if (streamWriter != null) streamWriter.Close();
            }
        }

        static void readFile(StreamReader streamReader, string fileName)
        {
            try
            {
                streamReader = new StreamReader(fileName);
                String a = streamReader.ReadLine();
                String b = streamReader.ReadLine();
                Console.WriteLine(a);
                Console.WriteLine(b);
            }
            catch (Exception e)
            {
                Console.WriteLine("Can not open file" + fileName);
                Console.WriteLine("Error: " + e.Message);
            }
            finally
            {
                if (streamReader != null) streamReader.Close();
            }
        }
    }
}
