using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns
{
    internal class Hollow
    {
        public void triangle_hollow(int n)
        {


            for (int i = 1; i < n + 1; i++)
            {
                for (int s = 1; s < n - i + 1; s++)
                {
                    Console.Write(" ");
                }

                for (int j = 1; j < 2*i; j++)
                {
                    if (j == 1 || j == 2 * i-1 || i==n)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
        }


        public void pyramid_hollow(int n)
        {


            for (int i = 1; i < n + 1; i++)
            {
                for (int s = 1; s < n - i + 1; s++)
                {
                    Console.Write(" ");
                }

                for (int j = 1; j < 2 * i; j++)
                {
                    if (j == 1 || j == 2 * i - 1 )
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
            for (int i = 1; i < n + 1; i++)
            {
                for (int s = 1; s < i+1; s++)
                {
                    Console.Write(" ");
                }

                for (int j = 1; j < 2*n-2*i; j++)
                {
                    if (j == 1 || j == 2 * n - 2*i-1)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }

        }
    }
}
