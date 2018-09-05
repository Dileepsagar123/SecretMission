using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileHandlingProject
{
    class SwitchSample
    {
       static void Main()
        {
            int size = 0 , del, count = 0;
            int[] arr = new int[50];
          
            int prev = 0;
            int next = 0;
            int choice;

            do
            {
                Console.WriteLine("Enter 1 for input size of an elemnets");
                Console.WriteLine("Enter 2 for input insert elements.");
                Console.WriteLine("Enter 3 for Delete an element.");
                Console.WriteLine("Enter 4 for Display element");
                Console.WriteLine("Enter 5 to exit//");
                Console.WriteLine("Enter your choice ");
                choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Enter Array Size : ");
                        size = Convert.ToInt32(Console.ReadLine());
                         
                        break;
                    case 2:
                        if (size == 0)
                        {
                            Console.WriteLine("Please Enter Array Size");

                            Console.WriteLine();
                            break;
                        }
                        Console.WriteLine("Enter Array Elements : ");
                        for (int i = 0; i < size; i++)
                        {
                          
                            arr[i] = Convert.ToInt32(Console.ReadLine());
                        }
                        
                        break;
                    case 3:
                        if(size == 0 )
                        {
                            Console.WriteLine("Please Enter Element first");
                            Console.WriteLine();
                            continue;
                        }
                        Console.WriteLine("Enter Element to be Delete : ");
                        del = Convert.ToInt32(Console.ReadLine());
                        for (int i = 0; i < size; i++)
                        {
                            

                            if (arr[i] == del)
                            {
                                for (int j = i; j < (size - 1); j++)
                                {
                                    if(size <= 3)
                                    {
                                        if (arr[0] == del)
                                        {
                                            arr[j] = arr[j + 1];
                                            next = arr[j];
                                        }
                                        else
                                        {
                                            arr[j] = arr[j + 1];
                                            prev = arr[j - 1];
                                        }
                                    }
                                    if (arr[0] == del)
                                    {
                                        arr[j] = arr[j + 1];
                                        next = arr[j];
                                    }
                                    else
                                    {
                                        arr[j] = arr[j + 1];
                                        prev = arr[j-1];
                                    }

                                }
                                count--;
                                break;
                            }

                        }
                         
                        break;
                    case 4:
                        if (size == 0)
                        {
                            Console.WriteLine("Please Enter element first");
                            Console.WriteLine();
                            break;
                        }
                        if (count == 0)
                        {
                            Console.WriteLine("Element Not Found..!!");
                        }
                        else
                        {
                            Console.WriteLine("Element Deleted Successfully..!!");
                            Console.WriteLine("\nNow the New Array is :\n");
                            for (int i = 0; i < (size - 1); i++)
                            {
                                Console.WriteLine(arr[i] + " ");
                            }
                            Console.WriteLine("===========================");
                            Console.WriteLine();
                            Console.WriteLine("Previous Element is " + prev);
                            Console.WriteLine("Next Element is " + next);
                            Console.WriteLine("============================");
                            Console.WriteLine();
                        }
                         
                        break;
                    default:
                        if(choice == 5 )
                        {
                            Console.WriteLine("Enter any key to exit...");
                            break;
                        }
                        Console.WriteLine("You Entered Wrong choice");
                        Console.WriteLine();
                        Console.WriteLine();
                        break;
                }

            } while (choice != 5 );
            Console.ReadKey();
        }
       
    }
}
