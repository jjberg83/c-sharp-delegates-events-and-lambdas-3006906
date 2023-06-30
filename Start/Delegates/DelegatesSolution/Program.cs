using System;

namespace DelegatesSolution
{
    class Program
    {
        static float zone1Fees(float pris) {
            return pris * 1.25f;
        }
        static float zone2Fees(float pris)
        {
            return pris * 1.12f;
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
                if (prisParse) 
                {
                    Console.WriteLine("Parsen gikk greit");
                } 
                else 
                {
                    Console.WriteLine("Parsen gikk til helvete");
                }
                
            }
            while (loopButton);


        }
    }
}
