using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EulerProjectInC_Sharp
{
    public class Problem2_EvenFibonacciNumbers
    {
        public void Problem2()
        {
            int result = 0; // even number
            int a = 1;
            int b = 1;
            int c = 1; // will always be the result of a + b
            // except for the first loop
            int previous_number = 1;
            for (int i = 1; i < 4000000; i++)
            {
                b = previous_number;
                a = c;
                if (a + b < 4000000)
                {
                    c = a + b;
                    previous_number = c - b;
                    if (c % 2 == 0)
                        result += c;
                    //c = 2
                }
                else
                    break;
            }
            Console.WriteLine(result.ToString());
            //result = 4613732
        }
    }
}
