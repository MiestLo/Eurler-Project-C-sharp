using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EulerProjectInC_Sharp
{ 
    public class Problem1_Multiplesof3or5
    {
        public void Problem1()
        {
          int result = 0;
          for (int a = 0; a < 1000; a++)
            {
                if (3 * a < 1000)
                    result += 3 * a;
                if (5 * a < 1000)
                    result += 5 * a;
            }
            Console.WriteLine(result.ToString());
            //result = 266333
        }
    }
}
