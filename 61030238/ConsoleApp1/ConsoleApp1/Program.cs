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
            string[] array1 = { "January", "March", "February", "April","May", "June", "July ", "August", "September ", "October ", "November ", "December" };
            
            string[] array2 = Array.FindAll(array1,
                element => element.StartsWith("J",
              StringComparison.Ordinal));


            Console.WriteLine(string.Join(",", array2));

            Console.ReadLine();
            






        }

    }
    }



