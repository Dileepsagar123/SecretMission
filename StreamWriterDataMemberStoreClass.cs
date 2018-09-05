using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FileHandlingProject
{
    class StreamWriterDataMemberStoreClass
    {
        int id;
        string name;
        int age;
        string address;
        public  StreamWriterDataMemberStoreClass(int id1 = 0 , string name1 = null , int age1 = 0 , string address1 = null)
        {
            this.id = id1;
            this.name = name1;
            this.age = age1;
            this.address = address1; 
            
        }
        public override string ToString()
        {
            return "ID : " + id + " NAME : " + name + " AGE : " + age + " ADDRESS " + address ;
        }
        static void Main()
        {
            
            
            string path = @"WriteIntoFile1.txt"; 
            if(!File.Exists(path))
            {
                File.Create(path);

            }
            else
            {
                using (StreamWriter writer = new StreamWriter(path))
                {
                    Console.WriteLine("Enter Your Id");
                    int id = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine();
                    Console.WriteLine("Enter Your Name");
                    string name = Console.ReadLine();
                    Console.WriteLine();
                    Console.WriteLine("Enter Your Age");
                    int age = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine();
                    Console.WriteLine("Enter Your Address");
                    string address = Console.ReadLine();

                    writer.Write(new StreamWriterDataMemberStoreClass(id, name, age, address));

                }
                using (StreamReader reader = new StreamReader(path))
                {
                    Console.WriteLine("Your Details are : ");
                    Console.WriteLine(reader.ReadLine());
                }

            }
            Console.ReadKey();
        }
    }
}
