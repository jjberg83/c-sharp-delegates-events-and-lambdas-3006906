using System;

namespace EventsSolution
{
    // define the delegate for the event handler
    public delegate void myEventHandler(float value);

    class EventPublisher
    {
        private float theVal;
        // declare the event handler
        public event myEventHandler valueChanged;

        private float balance;

        public float BalanceLink
        {
            get { return balance; }
            set { balance += value; }
        }

        public float Val
        {
            set
            {
                this.theVal = value;
                // when the value changes, fire the event
                this.valueChanged?.Invoke(theVal);
            }
        }
    }

    class ObjChangeEventArgs : EventArgs
    {
        public string propChanged;
    }

    class Program
    {
        static float balance = 0;

        static void Main(string[] args)
        {
            // create the test class
            EventPublisher obj = new EventPublisher();
            // Connect multiple event handlers
            obj.valueChanged += new myEventHandler(changeListener1);
            obj.valueChanged += new myEventHandler(changeListener2);
            obj.valueChanged += new myEventHandler(updateAmount);

            string str;
            do
            {
                Console.WriteLine("Enter a value: ");
                str = Console.ReadLine();
                if (!str.Equals("exit"))
                {
                    float theFloat;
                    bool success = float.TryParse(str, out theFloat);
                    if (success)
                    {
                        Console.WriteLine($"The number {theFloat} was successfully parsed.");
                    }
                    else
                    {
                        Console.WriteLine("Parsing failed.");
                    }
                    obj.Val = theFloat;
                }
            } while (!str.Equals("exit"));

            Console.WriteLine("Goodbye!");
        }

        static void updateAmount(float value)
        {
            Console.WriteLine($"Balance was: {balance}, will change with: {value}");
            balance += value;
            if (balance >= 501)
            {
                Console.WriteLine("You've reached your savings goal of 501!");
            }
            Console.WriteLine($"Balance is now: {balance}");
            Console.WriteLine("-----------------------------");
        }

        static void changeListener1(float value)
        {
            Console.WriteLine("The value changed to {0}", value);
        }

        static void changeListener2(float value)
        {
            Console.WriteLine("I also listen to the event and got {0}", value);
        }
    }
}
