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
            Console.WriteLine("ป้อนค่าที่1แต่ละเดือน12เดือน");
            Console.WriteLine("ป้อนเลข1=วันจันทร์ม2=อังคาร,3=พุธ,4=พฤหัส,5=ศุกร์,6=เสาร์,7=อาทิตย์");
            int[] gpa = new int[12];
            for (int n = 0; n < 12; n++)
            {
                int x;

                x = int.Parse(Console.ReadLine());
                gpa[n] = x;
            }
            Console.WriteLine("ป้อนเดือน");
            for (int n = 0; n < 8; n++)
            {
                Console.WriteLine("เกรด gps ");
                Console.WriteLine(gpa[n]);

            }
            switch
        {
            Console.ReadLine();
        }






        }
        
    }
    }



