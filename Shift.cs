using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileHandlingProject
{
    class Shift
    {
        static void Main()
        {
            // int[] list = new int[] { 1, 2, 3, 4, 5, 6, };
            // Console.WriteLine("Enter Index to removed");
            //int index = Convert.ToInt32(Console.ReadLine());

            //    List<int> list = new List<int>();
            //  int prev = list[index - 1];
            //int next = list[index + 1];
            /* for (int i = 0; i < list.Length - 1; i++)
             {
                 if(index == 0)
                 {
                     list[i] = list[index - 1];
                 }
                 if (list[i] == index)
                 {

                     for (int j = i; j < list.Length-1; j++)
                     {
                         if(index == list.Length-1 )
                         {
                             list[j] = list[index + 1];
                         }
                         list[j] = list[j + 1];
                     }
                      break;
                 }
             }
             for(int i = 0; i < list.Length / 2; i++)
             {

                 Console.WriteLine(list[i]);
             }
             Console.WriteLine("Prevoius Element is " + prev);
             */
            int n, x, flag = 1, loc = 0;
            
            Console.WriteLine("Enter no. of elements you want in array:");
            n = Convert.ToInt32(Console.ReadLine());
            int[] a = new int[n];
            //int prev = a[n - 1];
           //int next = a[n + 1];
            Console.WriteLine("Enter all the elements:");
            for (int i = 0; i < n; i++)
            {
                a[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Enter the element you want to delete:");
            x = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                if (a[i] == x)
                {
                    flag = 1;
                    loc = i;
                    break;
                }
                else
                {
                    flag = 0;
                }
            }
            if (flag == 1)
            {
                for (int i = loc + 1; i < n; i++)
                {
                     
                    a[i - 1] = a[i];
                     

                }
                Console.WriteLine("After Deleting:");
                for (int i = 0; i < n - 2; i++)
                {
                   
                    Console.WriteLine(a[i] + ",");
                }
                Console.WriteLine(a[n - 2]);

            }
            else
            {
                Console.WriteLine("Element not found");
            }
            Console.WriteLine("Previous Element is " );
            Console.ReadKey();
        }
    }
}
