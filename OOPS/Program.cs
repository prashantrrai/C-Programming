using System;

    //Inheritance (Single)

namespace OOPS
{
    class A
    {
        protected int a=10, b=40, c;

        public void add()
        {
            c = a + b;
            Console.WriteLine("Addition is "+c);
        }

        public void minus()
        {
            c = a - b;
            Console.WriteLine("subtraction is " + c);
        }

    } 

    class B:A
    {
        public void multiply()
        {
            c = a * b;
            Console.WriteLine("multiplication is " + c);
        }
        public void division()
        {
            c = a / b;
            Console.WriteLine("division is " + c);
        }

        public void remainder()
        {
            c = a % b;
            Console.WriteLine("remainder is " + c);
        }


        static void Main(string[] args)
        {
            //A a = new A();
            //a.add();
            //a.minus();
            
            B b = new B();
            b.add();
            b.minus();
            b.multiply();
            b.division();   
            b.remainder();
        }
    }
}