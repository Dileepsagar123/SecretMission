using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace FileHandlingProject
{
    class WritingFileSample
    {
        static void Main()
        {
            string path = @"data.txt";
            if(File.Exists(path))
            {
                Console.WriteLine("File Exists");
            }
            else
            {
                FileStream fileStream = new FileStream(path, FileMode.Create, FileAccess.Write);
                Console.WriteLine("File has been Created");
            }
        }
    }
}
