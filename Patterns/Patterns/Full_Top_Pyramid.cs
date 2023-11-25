using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns
{
    internal class Full_Top_Pyramid
    {
        public void star(int n)
        {
            for (int i = 1; i < n + 1; i++)
            {
                for (int s = 1; s < n - i + 1; s++)
                {
                    Console.Write(" ");
                }

                for (int j = 1; j < i + 1; j++)
                {
                    Console.Write(" *");
                }
                Console.WriteLine();
            }
        }
    }
}
