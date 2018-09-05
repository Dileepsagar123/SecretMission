using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace FileHandlingProject
{
    class StreamWriterSample
    {
        static void Main()
        {
            string path = @"dileep.txt";
            if(File.Exists(path))
            {
                Console.WriteLine("File Exists");
            }
            else
            {
                using (StreamWriter writer = new StreamWriter(path))
                {
                    writer.Write("hello this is first writing file");
                    writer.WriteLine("This is second file");
                    writer.WriteLine("This is second file");
                    writer.WriteLine("This is second file");
                    writer.WriteLine("This is second file");
                };
            }
            Console.ReadKey();
        }
    }
}
