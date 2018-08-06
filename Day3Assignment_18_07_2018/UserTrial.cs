using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Day3Assignment_18_07_2018
{
    class UserTrial
    {

        public void show(int val1, int val2)
        {

            if (val1 > 0)
            {
                Console.WriteLine(val1+" is greater than 0");
            }
            else
            {
                throw new Exception("First value is the negative number");
            }

            if (val2 > 0)
            {
                Console.WriteLine(val2 +" is greater than 0");
            }
            else
            {
              throw new Exception("Second value is the Negative number");
            }
        }

        public void calculate(int val1, int val2)
        {
            int c = val1 - val2;
            if (c < 0)
                throw new Exception("The difference is the negative number.");
        }

    }
}
