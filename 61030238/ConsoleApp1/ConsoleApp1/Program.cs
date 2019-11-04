using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppArray
{
    class Program
    {
        static void Main(string[] args)
        {
            string[][] jagged = { "sdwsd"};

            int count = 0;
            for (int row = 0; row < jagged.GetLength(0); ++row)
            {
                Console.Write("\nRow {0}:", row);
                jagged[row] = new int[row + 1];
                for (int index = 0; index < row + 1; ++index)
                {
                    ++count;
                    jagged[row][index] = count;
                    Console.Write(" {0}", count);
                }
            }
         
            Console.ReadLine();



        }
    }
}




