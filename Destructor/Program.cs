using System;
namespace Destructor
{

    class Person
    {

        public Person(int errorCode)
        {
            Console.WriteLine("Constructor called."+errorCode);
        }

        // destructor
        ~Person()
        {
            Console.WriteLine("Destructor called.");
        }

        public void random(int errorCode)
        {
            Console.WriteLine("last statement called." + errorCode);
        }

        public static void Main(string[] args)
        {
            // Creates an object of Person
            Person p1 = new Person(420);

            // Explicitly call garbage collector
            GC.Collect();
            GC.WaitForPendingFinalizers();

            Thread.Sleep(5000);


            p1.random(200);
        }

    }
}