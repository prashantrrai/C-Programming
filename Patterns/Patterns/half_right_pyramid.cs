using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns
{

    class half_right_pyramid
    {
        public void star(int n)
        {
            for (int i = 1; i < n + 1; i++)
            {
                for (int s = 1; s <2*( n - i) + 1; s++)
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

        public void number(int n)
        {
            for (int i = 1; i < n + 1; i++)
            {
                for (int j = 1; j < n-i+1; j++)
                {
                    Console.Write(" ");
                }
                for (int j = 1; j < i + 1; j++)
                {
                    Console.Write($"{j}");
                }
                Console.WriteLine();
            }
        }

        public void floydtriangle(int n)
        {
            int count = 1;
            for (int i = 1; i < n + 1; i++)
            {
                for (int j = 1; j < n - i + 1; j++)
                {
                    Console.Write(" ");
                }
                for (int j = 1; j < i + 1; j++)
                {
                    Console.Write($"{count}");
                    count += 1;
                }
                Console.WriteLine();
            }
        }


        public void reversefloydtriangle(int n)
        {
            int count = (n * (n + 1)) / 2;
            //Console.WriteLine(count);

            for (int i = 1; i < n + 1; i++)
            {
                for (int j = 1; j < n - i + 1; j++)
                {
                    Console.Write(" ");
                }
                for (int j = 1; j < i + 1; j++)
                {
                    Console.Write($"{count}");
                    count -= 1;
                }
                Console.WriteLine();
            }
        }


        public void reversefloydtriangle_withoutcounter(int n)
        {

            for (int i = 1; i <= n + 1; i++)
            {
                for (int j = 1; j < i + 1; j++)
                {
                    Console.Write($"{i * (i - 1) / 2 + j} ");
                }
                Console.WriteLine();
            }
        }
        public void samenumber(int n)
        {
            for (int i = 1; i < n + 1; i++)
            {
                for (int j = 1; j < i + 1; j++)
                {
                    Console.Write($"{i} ");
                }
                Console.WriteLine();
            }
        }




        public void abcd(int n)
        {
            int temp = 65;
            for (int i = 1; i < n + 1; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write(Convert.ToChar(temp));
                    temp += 1;
                }
                Console.WriteLine();
            }
        }


        public void misc1(int n)
        {

            for (int i = 1; i < n + 1; i++)
            {
                for (int j = 1; j < i + 1; j++)
                {
                    Console.Write($"{i * j + j} ");
                }
                Console.WriteLine();
            }
        }
        public void misc2(int n)
        {

            for (int i = 1; i <= 5; i++)
            {
                for (int j = 1; j < i + 1; j++)
                {
                    Console.Write($"{i * j + j - 1} ");
                }
                Console.WriteLine();
            }
        }



        public void misc3(int n)
        {
            for (int i = 1; i < n + 1; i++)
            {
                int temp = i;

                for (int j = 1; j < i + 1; j++)
                {
                    Console.Write($"{temp} ");
                    //temp = temp + n - j;
                    temp = 2 * n - i + 1;
                }
                Console.WriteLine();
            }

        }


    }

}
