using System;

namespace AnonymousDelegates
{
    public delegate string MyDelegate(int arg1, int arg2);

    class Program
    {
        static void Main(string[] args)
        {
            // TODO: Implement an anonymous delegate
            MyDelegate f = delegate(int a, int b) {
                return $"{a-b}";
            };
            Console.WriteLine("Nummeret fra anonymDelgat blir da: " + f(4,1));

        }
    }
}
