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
            string[] Array1 = { "January", "March", "February", "April", "May", "June", "July ", "August", "September ", "October ", "November ", "December" };

            string[] Array2 = Array.FindAll(Array1,
                element => element.EndsWith("ry",
              StringComparison.Ordinal));



            Console.WriteLine(string.Join(",", Array2));
            for (int i = 0; i < Array1.Length; i++)
            {
                Console.WriteLine(Array2[i]);

            }
            Console.WriteLine("copyเหมือนกัน");

            Console.ReadLine();

        }
    }
}




