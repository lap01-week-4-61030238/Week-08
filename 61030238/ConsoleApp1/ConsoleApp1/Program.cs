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
            var sortAscending = from country in AseanCountries
                                orderby country
                                select country;
            

           

            Console.WriteLine("------String sort ascending----------");
            foreach (string c in sortAscending)
                Console.WriteLine(c);

            
            Console.ReadLine();


            
            






        }

    }
    }



