using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns
{
    internal class Right_Pascal_Triangle
    {
        public void left_pascal(int n)
        {
            for (int i = 1; i < n+1; i++)
            {
                for (int j = 1; j < i + 1; j++)
                {
                    Console.Write("* ");
                }

                Console.WriteLine();
            }   

            for (int i = 1; i < n+1; i++)
            {
                for (int j = 1; j < n-i+1; j++)
                {
                    Console.Write("* ");
                }

                Console.WriteLine();
            }
        }

        public void right_pascal(int n)
        {
            for (int i = 1; i < n + 1; i++)
            {
                for (int s = 1; s < n - i + 1; s++)
                {
                    Console.Write(" ");
                }

                for (int j = 1; j < i + 1; j++)
                {
                    Console.Write("*");
                }

                Console.WriteLine();
            }

            for (int i = 1; i < n + 1; i++)
            {
                for (int s = 1; s < i + 1; s++)
                {
                    Console.Write(" ");
                }

                for (int j = 1; j < n - i + 1; j++)
                {
                    Console.Write("*");
                }

                Console.WriteLine();
            }
        }


        public void sand_glass(int n)
        {
            for (int i = 1; i < n + 1; i++)
            {
                for (int s = 1; s < i; s++)
                {
                    Console.Write(" ");
                }
                for (int j = 1; j < n-i+2; j++)
                {
                    Console.Write("* ");
                }

                Console.WriteLine();
            }

            for (int i = 1; i < n + 1; i++)
            {
                for (int s = 1; s < n - i + 1; s++)
                {
                    Console.Write(" ");
                }
                for (int j = 1; j < i+1; j++)
                {
                    Console.Write("* ");
                }

                Console.WriteLine();
            }
        }






    }
}
