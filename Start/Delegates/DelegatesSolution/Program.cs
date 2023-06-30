using System;

namespace DelegatesSolution
{
    public delegate float MinDelegate(float pris);
    class Program
    {
        // float riskFee = 25.0f;
        static float zone1Fees(float pris) {
            return pris * 0.25f;
        }
        static float zone2Fees(float pris)
        {
            return pris * 0.12f + 25.0f;
        }
        static float zone3Fees(float pris)
        {
            return pris * .08f;
        }
        static float zone4Fees(float pris)
        {
            return pris * .04f + 25.0f;
        }
        static void Main(string[] args)
        {
            bool loopButton = true;
            do 
            {
                Console.WriteLine("What is the destination zone?");
                string destinasjon = Console.ReadLine();
                if (destinasjon == "exit") 
                {
                    Console.WriteLine("Program avsluttes");
                    break;
                }
                Console.WriteLine("What is the item price?");
                string pris = Console.ReadLine();
                if (pris == "exit")
                {
                    Console.WriteLine("Program avsluttes");
                    break;
                }
                float prisFloat;
                bool prisParse = float.TryParse(pris, out prisFloat);
                // if (prisParse) 
                // {
                //     Console.WriteLine("Parsen gikk greit");
                // } 
                // else 
                // {
                //     Console.WriteLine("Parsen gikk til helvete");
                // }
                MinDelegate f;
                if (destinasjon == "zone1")
                {
                    f = zone1Fees;
                    Console.WriteLine("The shipping fees are: " + f(prisFloat));
                }
                else if (destinasjon == "zone2")
                {
                    f = zone2Fees;
                    Console.WriteLine("The shipping fees are: " + f(prisFloat));
                }
                else if (destinasjon == "zone3")
                {
                    f = zone3Fees;
                    Console.WriteLine("The shipping fees are: " + f(prisFloat));
                }
                else if (destinasjon == "zone4")
                {
                    f = zone4Fees;
                    Console.WriteLine("The shipping fees are: " + f(prisFloat));
                }
                else 
                {
                    Console.WriteLine($"Destinasjonen {destinasjon} er ukjent.");
                }
                
            }
            while (loopButton);


        }
    }
}
