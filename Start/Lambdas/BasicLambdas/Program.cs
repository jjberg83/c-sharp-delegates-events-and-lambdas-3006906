using System;

namespace BasicLambdas
{
    // define a few delegate types
    public delegate int MyDelegate(int x);
    public delegate void MyDelegate2(int x, string prefix);
    public delegate bool ExprDelegate(int x);

    class Program
    {
        static void Main(string[] args)
        {
            // TODO: Create a basic delegate that squares a number
            MyDelegate d1 = (x) => x * x;
            Console.WriteLine("The result of d1 is {0}", d1(5));

            // TODO: Dynamically change the delegate to something else
            d1 = (x) => x * 10;
            Console.WriteLine($"The reuslt of d1 is {d1(5)}");

            // TODO: Create a delegate that takes multiple arguments
            MyDelegate2 d2 = (x, y) =>
            {
                Console.WriteLine("The two-arg lambda: {1} {0}", x * 10, y);
            };
            d2(25, "En string");


            // TODO: Define an expression delegate
            //  public delegate bool ExprDelegate(int x);
            ExprDelegate d3 = (tallet) => tallet >= 0;
            bool resultat = d3(2);
            if (!resultat) 
            {
                Console.WriteLine("Tallet er negativt");
            }
            else 
            {
                Console.WriteLine("Tallet er positivt");
            }


        }
    }
}