using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileHandlingProject
{
    class RemoveElementSample
    {
        static void Main()
        {
            int size, i, del, count = 0;
            int[] arr = new int[50];

           
            Console.WriteLine("Enter Array Size : ");
            size = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Array Elements : ");
            for (i = 0; i < size; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            
             
            Console.WriteLine("Enter Element to be Delete : ");
            del = Convert.ToInt32(Console.ReadLine());
            int prev =  0;
            int next = 0;
            for (i = 0; i < size; i++)
            {
               
                if (arr[i] == del)
                {
                    for (int j = i; j < (size - 1); j++)
                    { 
                        if(arr[0] == del )
                        {
                            arr[j] = arr[j  +  1];
                            next = arr[j];
                        }
                        else
                        {
                            arr[j] = arr[j + 1];
                            prev = arr[j - 1];
                        }
                       
                    }
                    count++;
                    break;
                }
              
            }
            Console.WriteLine("Count = " +count);
            if (count == 0)
            {
                Console.WriteLine("Element Not Found..!!");
            }
            else
            {
                Console.WriteLine("Element Deleted Successfully..!!");
                Console.WriteLine("\nNow the New Array is :\n");
                for (i = 0; i < (size - 1); i++)
                {
                    Console.WriteLine(arr[i] + " ");
                }
            }
            Console.WriteLine("Previous Element is " + prev);
            Console.WriteLine("Next Element is " + next);
            Console.ReadKey();
        }
    }
}