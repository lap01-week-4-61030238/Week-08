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
            for (int n = 10; n < 15; n++)

            {

                //
                // ค้นหาสมาชิกตัวแรกที่มีความยาว string ตามกำหนด
                //
                string[] array2 = Array.FindAll(array1,
                element => element.Length == n);


                Console.WriteLine(string.Join(",", array2));
            }
            Console.ReadLine();
            






        }

    }
    }



