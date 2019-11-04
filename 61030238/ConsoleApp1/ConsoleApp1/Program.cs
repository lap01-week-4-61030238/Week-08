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
            int q = 0;
            int[,] multiplyTable = new int[12, 12];
            for (int N = 0; N < 12; N = N + 1)
            {
                q++;
                multiplyTable[N, 0] = 2 * q;
                
            }
            for (int row = 0; row < multiplyTable.GetLength(0); row++)
            {
                for (int col = 0; col < multiplyTable.GetLength(1); col++)
                {
                    Console.Write("{0,5}", multiplyTable[row, col]);
                }
                Console.WriteLine();
            }
            Console.ReadLine();


        }
    }
}




