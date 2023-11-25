using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns
{
    internal class Full_Down_Pyramid
    {
        public void left(int n)
        {
            for (int i = 1; i < n + 1; i++)
            {

                for (int j = 1; j < n - i + 1; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }

        public void right(int n)
        {
            for (int i = 1; i < n + 1; i++)
            {
                for (int s = 1; s < i; s++)
                {
                    Console.Write(" ");
                }

                for (int j = 1; j < n-i+1; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
        public void full(int n)
        {
            for (int i = 1; i < n + 1; i++)
            {
                for (int s = 1; s < i; s++)
                {
                    Console.Write(" ");
                }

                for (int j = 1; j < n-i+1; j++)
                {
                    Console.Write(" *");
                }
                Console.WriteLine();
            }
        }
    }
}
