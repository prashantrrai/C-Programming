using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns
{
    internal class Pattern_Task
    {
        public void pattern1(int n)
        {
            //Console.WriteLine("========Pattern 1===========");
            int Count = 11;
            for (int i = 1; i < n + 1; i++)
            {
                for (int s = 1; s < i; s++)
                {
                    Console.Write(" ");
                }
                for (int j = 1; j < 2*n-2*i+2; j++)
                {
                    Console.Write($" {Count}");
                    Count += 1;
                }
                Console.WriteLine();
            }
            for (int i = 1; i < n ; i++)
            {
                for (int s = 1; s < n - i ; s++)
                {
                    Console.Write(" ");
                }
                for (int j = 1; j < 2 * i + 2; j++)
                {
                    Console.Write($" {Count}");
                    Count += 1;
                }
                Console.WriteLine();
            }


        }


        public void pattern2(int n)
        {
            //Console.WriteLine("========Pattern 2===========");
            int temp = 1;
            for (int i = 0; i < n; i++)
            {
                for (int j = 1; j < i + 2; j++)
                {
                    Console.Write($"{(i+j)%2}");
                    temp += 1;
                }
                Console.WriteLine();
            };
        }




        public void pattern3(int n)
        {
            //Console.WriteLine("========Pattern 3===========");
            int temp = 9;
            for (int i = 1; i < n+1; i++)
            {
                for (int j = 0; j < n-i+1; j++)
                {
                    Console.Write($"{temp-j}");
                }
                temp -= 1;
                Console.WriteLine();
            };
        }





        public void pattern4(int n)
        {
            //Console.WriteLine("========Pattern 4===========");
            int temp = 9;
            for (int i = 1; i < n + 1; i++)
            {
                for (int s = 1; s < i; s++)
                {
                    Console.Write(" ");
                }

                for (int j = 0; j < n - i + 3; j++)
                {
                    Console.Write($"{temp - j}");
                }
                temp -= 1;
                Console.WriteLine();
            };

            for (int k = 1; k< n+2; k++)
            {
                Console.Write(" ");
            }
                Console.Write($"{--temp}");
                Console.WriteLine();

            temp = 9;
            for (int i = 1; i < n + 1; i++)
            {
                for (int s = 1; s < n-i+1; s++)
                {
                    Console.Write(" ");
                }

                for (int j = 1; j < n + i+1; j++)
                {
                    Console.Write($"{temp - j}");
                }
                temp += 1;
                Console.WriteLine();
            };
        }


        public void pattern5(int n)
        {
            //Console.WriteLine("========Pattern 5===========");
            int temp = 9;

            for (int i = 1; i < n + 1; i++)
            {
                for (int j = 0; j < n-i+1; j++)
                {
                    Console.Write($"{temp - j}");
                }
                temp -= 1;
                Console.WriteLine();
            };
            temp = 6;
            for (int i = 1; i < n ; i++)
            {
                for (int j = 0; j <  i + 1; j++)
                {
                    Console.Write($"{temp + j}");
                }
                temp += 1;
                Console.WriteLine();
            };
        }


        public void pattern6(int n)
        {
            //Console.WriteLine("========Pattern 6===========");
            for (int i = 1; i < n + 1; i++)
            {
                for (int s = 1; s < n - i + 1; s++)
                {
                    Console.Write(" ");
                }

                for (int j = 0; j < i ; j++)
                {
                    Console.Write($"{i-j}");
                }
                for (int j = 2; j <= i; j++)
                {
                    Console.Write($"{j}");
                }
                Console.WriteLine();
            }

            for (int i = 1; i < n ; i++)
            {
                for (int s = 1; s < i + 1; s++)
                {
                    Console.Write(" ");
                }

                for (int j = 0; j < n-i ; j++)
                {
                    Console.Write($"{n-i-j}");
                }
                for (int j = 2; j <= n-i; j++)
                {
                    Console.Write($"{j}");
                }

                Console.WriteLine();
            }
        }



        public void pattern7(int n)
        {
            //Console.WriteLine("========Pattern 1===========");
            int Count = 25;
            for (int i = 1; i < n + 1; i++)
            {
                for (int s = 1; s < i; s++)
                {
                    Console.Write(" ");
                }
                for (int j = 1; j < 2 * n - 2 * i + 2; j++)
                {
                    Console.Write($" {Count}");
                    Count -= 1;
                }
                Console.WriteLine();
            }
            for (int i = 1; i < n + 1; i++)
            {
                for (int s = 1; s < i; s++)
                {
                    Console.Write(" ");
                }
                for (int j = 1; j < 2 * n - 2 * i + 2; j++)
                {
                    Console.Write($" {Count}");
                    Count -= 1;
                }
                Console.WriteLine();
            }


        }
    }
}
