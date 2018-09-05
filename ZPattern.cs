using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JSONAPP
{
    class ZPattern
    {
        static void Main(string[] args)
        {
            for (int row = 0; row < 10; row++)
            {
                for (int column = 0; column < 10; column++)
                {
                    if (row == 0 || row == 10 - 1 || column == 10 - 1 - row || (column == row) )
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                     
                }
                Console.WriteLine();

            }
            Console.ReadLine();
        }
    }
}
