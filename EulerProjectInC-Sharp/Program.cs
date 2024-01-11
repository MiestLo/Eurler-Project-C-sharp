using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Problem

namespace EulerProjectInC_Sharp
{
    class Program
    {
        public static Problem1_Multiplesof3or5 AccesProblem1 = new Problem1_Multiplesof3or5();
        public static Problem2_EvenFibonacciNumbers AccesProblem2 = new Problem2_EvenFibonacciNumbers();
        static void Main() //static void Main(string[] args)
        {
            //AccesProblem1.Problem1();
            AccesProblem2.Problem2();
        }
    }
}
