using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns
{
    internal class Heart
    {
        public void Heart_Pattern()
        {


            for (int i = 1; i < 5; i++)
            {
                for (int s = 1; s <= 4 - i; s++)
                {
                    Console.Write(" ");
                }

                for (int j = 1; j < 2 * i + 2; j++)
                {
                    Console.Write("*");
                }

                for (int s = 1; s <= 9-2*i; s++)
                {
                    Console.Write(" ");
                }

                for (int j = 1; j < 2 * i + 2; j++)
                {
                    Console.Write("*");
                }

                Console.WriteLine();
            }
            for(int i=1;  i <= 10; i++)
            {
                for (int s = 1; s < i+1; s++)
                {
                    Console.Write(" ");
                }
                for (int j = 1; j <= 19-(2*i) ; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }


        }
    }
}


