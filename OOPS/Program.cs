using System;

    //Inheritance (Single)

namespace OOPS
{
//    class A
//    {
//        protected int a=10, b=40, c;

//        public void add()
//        {
//            c = a + b;
//            Console.WriteLine("Addition is "+c);
//        }

//        public void minus()
//        {
//            c = a - b;
//            Console.WriteLine("subtraction is " + c);
//        }

//    } 

//    class B:A
//    {
//        public void multiply()
//        {
//            c = a * b;
//            Console.WriteLine("multiplication is " + c);
//        }
//        public void division()
//        {
//            c = a / b;
//            Console.WriteLine("division is " + c);
//        }

//        public void remainder()
//        {
//            c = a % b;
//            Console.WriteLine("remainder is " + c);
//        }


//        static void Main(string[] args)
//        {
//            //A a = new A();
//            //a.add();
//            //a.minus();
            
//            B b = new B();
//            b.add();
//            b.minus();
//            b.multiply();
//            b.division();   
//            b.remainder();
//        }
//    }




// SIMPLE INHERITANCE

    //class baseclass
    //{
    //    protected int A=10, B=5, C;
    //    public void add()
    //    {
    //        C = A + B;
    //        Console.WriteLine("Add"+C);
    //    }
    //}

    //class supportclass: baseclass
    //{
    //    public void sub()
    //    {
    //        C = A - B;
    //        Console.WriteLine("Sub" + C);
    //    }

    //    static void Main(String[] args)
    //    {
    //        supportclass baseobj = new supportclass();
    //        baseobj.add();
    //        baseobj.sub();
    //    }

    //}



//  MULTIPLE INHERITANCE

    interface A
    {
        void add();
    }

    interface B
    {
        void sub();
    }

    class multiple:A,B
    {

        public void add()
        {
            int a = 10, b=15;
            Console.WriteLine(a + b);
        }

        public void sub()
        {
            int a = 10, b = 15;
            Console.WriteLine(a - b);
        }
        static void Main(string[] args)
        {
            multiple obj = new multiple();

            obj.add();
            obj.sub();
        }
    }

}