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
            return pris * 1.12f + ;
        }
        static void Main(string[] args)
        {
            bool loopButton = true;
            do 
            {
                Console.WriteLine("What is the destination zone?");
                string destinasjon = Console.ReadLine();
                Console.WriteLine("What is the item price?");
                string pris = Console.ReadLine(); 
                float prisFloat = float.Parse(pris);
                if (destinasjon == "exit") | (pris )
                {
                    loopButton = false;
                }
            }
            while (loopButton)


        }
    }
}
