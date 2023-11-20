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

    //interface A
    //{
    //    void add();
    //}

    //interface B
    //{
    //    void sub();
    //}

    //class multiple:A,B
    //{

    //    public void add()
    //    {
    //        int a = 10, b=15;
    //        Console.WriteLine(a + b);
    //    }

    //    public void sub()
    //    {
    //        int a = 10, b = 15;
    //        Console.WriteLine(a - b);
    //    }
    //    static void Main(string[] args)
    //    {
    //        multiple obj = new multiple();

    //        obj.add();
    //        obj.sub();
    //    }
    //}


    //Compile Time / Static POLYMORPHISM (method overloading)
    //class calculator
    //{
    //    public int Add(int a, int b)
    //    {
    //        return a+b;
    //    }

    //    public string Add(string a, string b)
    //    {
    //        return a+b;
    //    }
    //}



    ////POLYMORPHISM (Runtime Polymorphism (Method Overriding)/ Dynamic Polymorphism)
    //class Animal
    //{
    //    public virtual void Sound()
    //    {
    //        Console.WriteLine("Animal makes sound");
    //    }
    //}

    //class Dog : Animal
    //{
    //    public override void Sound()
    //    {
    //        Console.WriteLine("Dog makes sound too");
    //    }
    //}

    //class cat : Animal
    //{
    //    public override void Sound()
    //    {
    //        Console.WriteLine("cat makes sound too");
    //    }
    //}

    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        Animal animal = new Animal();
    //        Animal dog = new Dog();
    //        Animal cat = new cat();

    //        animal.Sound();
    //        dog.Sound();
    //        cat.Sound();


    //        calculator calc = new calculator();

    //        int result1 = calc.Add(1, 33);
    //        string result2 = calc.Add("Prashant", "Rai");

    //        Console.WriteLine("Result1: " + result1); 
    //        Console.WriteLine("Result2: " + result2);


    //    }
    //}


    //abstract class Animal
    //{
    //    public abstract void run();
    //    public void sleep()
    //    {
    //        Console.WriteLine("dog is sleeping");
    //    }
    //}

    //class helper: Animal
    //{
    //    public override void run()
    //    {
    //        Console.WriteLine("This si me helper");
    //    }
    //}

    //interface IAnimal
    //{
    //    void animal();
    //}

    //interface IBird
    //{
    //    void bird();
    //}

    //interface IHumans
    //{
    //    void human();
    //}

    //class Dog: IAnimal, IBird, IHumans       //called as Implement class
    //{
    //    public void animal()
    //    {
    //        Console.WriteLine("interfacce is working animal");
    //    }

    //    public void bird()
    //    {
    //        Console.WriteLine("interfacce is working bird");
    //    }

    //    public void human()
    //    {
    //        Console.WriteLine("interfacce is working human");
    //    }
    //}



    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        //helper obj = new helper();
    //        //obj.run();
    //        //obj.sleep();

    //        //Dog dog = new Dog();
    //        //dog.animal();
    //        //dog.bird(); 
    //        //dog.human();


    //    }
    //}


    //enum




    /*    class Program
        {
            enum status
            {
                pending, assigning, assigned, started, ended, completed
            }

            enum Months
            {
                January,    // 0
                February,   // 1
                March,      // 2
                April,      // 3
                May,        // 4
                June,       // 5
                July        // 6
            }

            enum ridestatus
            {
                pending, assigning, assigned=5, started, ended, completed
            }




            static void Main(string[] args)
            {


                status current = status.pending;
                Console.WriteLine(current);

                int months = (int) Months.April;
                Console.WriteLine(months);

                int ride = (int)ridestatus.started;
                Console.WriteLine(ride);
            }
        }
    */


    class Student
    {
        int BankBalance;

        public int AddBalance
        {
            get { return BankBalance; }

            set { BankBalance = value; }

        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Student S1 = new Student();
            S1.AddBalance = 200;
            Console.WriteLine("Details are " + S1.AddBalance);
        }
    }

}












