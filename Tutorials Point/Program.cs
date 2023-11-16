using System;

namespace TutorialsPoint
{
    class Rectangle
    {
        double length;
        double width;

        public void AcceptDetails()
        {
            length = 10;
            width = 8;
        }

        public double GetArea()
        {
            return length * width;
        }

        public void Display()
        {
            Console.WriteLine("Length: " + length); // Fixed the Console.WriteLine statements
            Console.WriteLine("Width: " + width);
            Console.WriteLine("Area of Rectangle: " + GetArea());
        }
    }

    class ExecuteRectangle
    {
        static void Main(string[] args)
        {
            Rectangle rect = new Rectangle();
            rect.AcceptDetails();
            rect.Display();

            DataTypeApplication data = new DataTypeApplication();
            data.Size();

            TypeCastingDoubleToInt Mynum = new TypeCastingDoubleToInt();
            Mynum.Type();

            TypeConversionApplication typeConversionApplication = new TypeConversionApplication();
            typeConversionApplication.TypeConversion();


            SumofTriangle result = new SumofTriangle();

            //int x  = int.Parse(Console.ReadLine());
            //int y  = Convert.ToInt16(Console.ReadLine());
            //int z  = Convert.ToInt16(Console.ReadLine());


            //Console.WriteLine($"The sum of {x}, {y}, {z} is {result.Sum(x, y, z)}");

            EscapeChar escapeChar = new EscapeChar();
            escapeChar.Escape();

            Operator ops = new Operator();
            ops.MyOps();

            Loopss myloop = new Loopss();

            int nums = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine($"Table of {nums}");
            myloop.Multiplicationtable(nums);
            Console.ReadLine();
        }
    }

    class DataTypeApplication
    {
        public void Size()
        {
            Console.WriteLine("Size of int : {0}", sizeof(int));
        }
    }

    class TypeCastingDoubleToInt
    {
        public void Type()
        {
            double num = 123456.87;
            int i;

            i = (int)num;
            Console.WriteLine("Type Casted from {0}, {1}", num, i);
        }
    }



    class TypeConversionApplication
    {
        public void TypeConversion()
        {
            int i = 34;
            float f = 94.980f;
            double d = 874.7848;
            bool b = false;

            Console.WriteLine(i.ToString());
            Console.WriteLine(f.ToString());
            Console.WriteLine(d.ToString());
            Console.WriteLine(b.ToString());
        }
    }

    class SumofTriangle
    {
        //int x, y, z;
        public int Sum(int x, int y, int z)
        {
            return x + y + z;
        }
    }

    class EscapeChar
    {
        public void Escape()
        {
            Console.WriteLine("Hello\tWorld\n\n");
        }
    }

    class Operator
    {

        int a = 10;
        public void MyOps()
        {
            Console.WriteLine(typeof(StreamReader));
            Console.WriteLine(sizeof(int));
            //Console.WriteLine(&a);
        }
    }

    class Loopss
    {
        public void Multiplicationtable(int nums)
        {      
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"{nums} X {i} = {nums * i}");
            }
        }
    }

}