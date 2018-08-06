using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Day3_Assignment_18_07_2018_02
{
    class Program
    {
        static void Main(string[] args)
        {
            string str1;
            Console.WriteLine("Enter a string...");
            str1 = Console.ReadLine();

            string str2 = "Deloitte Training";
            try
            {
                if (!(str1.Equals(str2)))
                {
                    throw new NoMatchException("No Match Found Exception...");
                }
                else
                {
                    Console.WriteLine("The Strings are matching...");
                }
            }
            catch(NoMatchException ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
    }

  
}
