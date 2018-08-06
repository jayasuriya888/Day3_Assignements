using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3Assignment_18_07_2018
{
    class First
    {
        static void Main(string[] args)
        {
            int a, b;
            Console.WriteLine("Enter the two values....");
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            UserTrial ut = new UserTrial();
            try
            {
                ut.show(a, b);
                ut.calculate(a, b);
                
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            
            

        }
    }
}
