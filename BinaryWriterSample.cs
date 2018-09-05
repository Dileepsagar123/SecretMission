using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FileHandlingProject
{
    class BinaryWriterSample
    {
        static void Main()
        {
            using (BinaryWriter binary = new BinaryWriter(File.Open("vmware-0.log", FileMode.Create)))
            {
                binary.Write("0x80234400");
                binary.Write("This is nothing but binary file");
                binary.Write("This is third Line");

            };
            Console.WriteLine("Binary File is created");
           
                Console.ReadKey();
           
        }
    }
}
