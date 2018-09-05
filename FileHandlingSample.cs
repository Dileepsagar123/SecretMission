using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileHandlingProject
{
    class FileHandlingSample
    {
        static void Main()
        {
            string path = "abc.txt";
            if(!File.Exists(path))
            {
                FileStream fileStream = new FileStream(path, FileMode.CreateNew, FileAccess.ReadWrite);
                Console.WriteLine("File successfully is created");
            }
            else
            {
                Console.WriteLine("File Exists");
            }
            Console.ReadKey();
            

       
        }
    }
}
