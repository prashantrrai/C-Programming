using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns
{
    internal class Pascals_Triangle
    {
        public void pascal(int n)
        {
            for (int i = 1; i < n + 1; i++)
            {
                for (int s = 1; s < n-i+1; s++)
                {
                    Console.Write(" ");
                }
                for (int j = 1; j < 2*i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}
