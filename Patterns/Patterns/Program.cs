using System;
using System.Text;
using Patterns;

namespace Pattern
{
    class half_left_pyramid
    {
        public void star(int n)
        {
            for(int i = 1; i < n+1; i++)
            {
                for (int j = 1; j < i+1; j++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }
        }

        public void number(int n)
        {
            for (int i = 1; i < n + 1; i++)
            {
                for (int j = 1; j < i + 1; j++)
                {
                    Console.Write($"{j} ");
                }
                Console.WriteLine();
            }
        }

        public void floydtriangle(int n)
        {
            int count = 1;
            for (int i = 1; i < n + 1; i++)
            {
                for (int j = 1; j < i + 1; j++)
                {
                    Console.Write($"{count} ");
                    count += 1;
                }
                Console.WriteLine();
            }
        }


        public void reversefloydtriangle(int n)
        {
            int count = (n*(n+1))/2;
            //Console.WriteLine(count);

            for (int i = 1; i < n + 1; i++)
            {
                for (int j = 1; j < i + 1; j++)
                {
                    Console.Write($"{count} ");
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

            for (int i = 1; i < n+1; i++)
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



    class DriverCode
    {
        static void Main(string[] args)
        {
            half_left_pyramid obj = new half_left_pyramid();
            half_right_pyramid obj2 = new half_right_pyramid();
            Full_Top_Pyramid obj3 = new Full_Top_Pyramid();
            Full_Down_Pyramid obj4 = new Full_Down_Pyramid();
            Diamond obj5 = new Diamond();

            Console.WriteLine("Enter the Value :");
            int num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("======================================================");


            //obj.star(num);
            //obj.number(num);
            //obj.floydtriangle(num);
            //obj.reversefloydtriangle(num);
            //obj.reversefloydtriangle_withoutcounter(num);
            //obj.samenumber(num);
            //obj.abcd(num);
            //obj.misc1(num);
            //obj.misc2(num);
            //obj.misc3(num);


            //obj2.star(num);
            //obj2.number(num);
            //obj2.floydtriangle(num);
            //obj2.reversefloydtriangle(num);
            //obj2.reversefloydtriangle_withoutcounter(num);
            //obj2.samenumber(num);
            //obj2.abcd(num);
            //obj2.misc1(num);
            //obj2.misc2(num);
            //obj2.misc3(num);

            //obj3.star(num);
            //obj4.left(num);
            //obj4.right(num);
            //obj4.full(num);
            obj5.diamond(num);

            Console.WriteLine("======================================================");

        }
    }
}