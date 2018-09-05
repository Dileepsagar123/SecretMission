using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace FileHandlingProject
{
    class TestWriterSample
    {
        static void Main()
        {

            string filepath = @"C:\Users\Dileep\Documents\Virtual Machines\Ubuntu 64-bit\vmware-0.log";

            //Read One Line
            using (TextReader tr = File.OpenText(filepath))
            {
                Console.WriteLine(tr.ReadLine());
            }

            //Read 4 Characters
            using (TextReader tr = File.OpenText(filepath))
            {
                char[] ch = new char[4];
                tr.ReadBlock(ch, 0, 4);
                Console.WriteLine(ch);
            }

            //Read full file
            using (TextReader tr = File.OpenText(filepath))
            {
                Console.WriteLine(tr.ReadToEnd());
                Console.WriteLine("Peek Point is : " + tr.Peek());
                Console.WriteLine("Read From End : " + tr.ReadToEnd());
                Console.WriteLine("Resouce is closed : ");
                //tr.Flush();
                tr.Close();
            }
            Console.ReadKey();
        }
    }
}
