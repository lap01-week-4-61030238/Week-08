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
            int p,q,d;
            Console.WriteLine("ป้อนค่าที่1แต่ละเดือน12เดือน");
            Console.WriteLine("ป้อนเลข-1=วันจันทร์ม,0=อังคาร,1=พุธ,2=พฤหัส,3=ศุกร์,4=เสาร์,5=อาทิตย์");
            int[] gpa = new int[12];
            for (int n = 0; n < 12; n++)
            {
                int x;

                x = int.Parse(Console.ReadLine());
                gpa[n] = x;
            }
            Console.WriteLine("ป้อนเดือน1=มกรา,2=กุมภา,3=มีนา,4=เมษา,5=พฤษภา,6=,มิถุนา,7=กรกฎา,8=สิงหา,9=กันยา,10=ตุลา,11=พฤษจิกา,12=ธันวา");
            
            q = int.Parse(Console.ReadLine());
            if(q==1)
            {
                Console.WriteLine("วันที่");
                p = int.Parse(Console.ReadLine());
                d = (p + gpa[0])%7;
                Console.WriteLine(d);
                if(d==0)
                {
                    Console.WriteLine("วันจันทร์/มกรา/2562");
                }
                else if (d == 1)
                {
                    Console.WriteLine("วันอังคาร/มกรา/2562");
                }
                else if (d == 2)
                {
                    Console.WriteLine("วันพุธ/มกรา/2562");
                }
                else if (d == 3)
                {
                    Console.WriteLine("วันอังพฤหัส/มกรา/2562");
                }

                else if (d == 4)
                {
                    Console.WriteLine("วันศุกร/มกรา/2562");
                }
                else if (d == 5)
                {
                    Console.WriteLine("วันเสาร์/มกรา/2562");
                }
                else if (d == 6)
                {
                    Console.WriteLine("วันอาทิตย์/มกรา/2562");
                }
                else 
                {
                    Console.WriteLine("error");
                }
            }

           
           
            Console.ReadLine();
        






        }
        
    }
    }



