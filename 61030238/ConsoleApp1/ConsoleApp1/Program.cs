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
           

            string[] AseanCountries = new string[] { "January", "March", "February", "April", "May", "June", "July ", "August", "September ", "October ", "November ", "December" };

            // C# program that uses LINQ
            
            var sortDescending = from country in AseanCountries
                                 orderby country descending
                                 select country;

           

            

            Console.WriteLine("------String sort descending----------");
            foreach (string c in sortDescending)
                Console.WriteLine(c);
            // wait
            Console.ReadLine();


            
            






        }

    }
    }



