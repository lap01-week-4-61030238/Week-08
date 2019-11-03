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
            int p;
            Console.WriteLine("ป้อนค่าgps8เทอม");
            int[] gpa = new int[8];
            for (int n=0;n<8;n++)
            {
                int  x;
                
                x = int.Parse(Console.ReadLine());
                gpa[n] = x;
            }
            for (int n = 0; n < 8; n++)
            {
                Console.WriteLine("เกรด gps ");
                Console.WriteLine(gpa[n]);

            }
            p = (gpa[0] + gpa[1] + gpa[2]+ gpa[3] + gpa[4] + gpa[5] + gpa[6] + gpa[7])/8;
            Console.WriteLine("เกรด gpa ");
            Console.WriteLine(p);
            Console.ReadLine();






        }
        
    }
    }



