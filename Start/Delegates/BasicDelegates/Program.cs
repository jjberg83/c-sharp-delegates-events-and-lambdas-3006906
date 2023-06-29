using System;

namespace BasicDelegates
{
    // TODO: declare the delegate type
    public delegate string MyDelegate(int arg1, int arg2);

    class MyClass
    {
        // Delegates can be bound to instance members as well as
        // static class functions
        public string gjørBegge(int arg1, int arg2)
        {
            return ((arg1 + arg2) * arg1).ToString();
        }
    }

    class Program
    {
        // TODO: Create functions to serve as delegate implementations
        static string plussDe(int a, int b)
        {
            return (a + b).ToString();
        }
        static string gangDe(int a, int b)
        {
            return (a * b).ToString();
        }


        static void Main(string[] args)
        {
            // TODO: exercise each delegate function
            MyDelegate f = plussDe;
            Console.WriteLine("Nummeret fra plussDe er: " + f(10, 20));
            f = gangDe;
            Console.WriteLine("Nummeret fra gangDe er: " + f(10, 20));



            // TODO: Use an instance function of a class as a delegate
            MyClass mc = new MyClass();
            f = mc.gjørBegge;
            Console.WriteLine("Nummeret fra gjørBegge er: " + f(10, 20));


        }
    }
}
