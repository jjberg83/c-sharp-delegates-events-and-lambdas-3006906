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
        // public event EventHandler<ObjChangeEventArgs> objChanged;

        private float balance;

        public float balanceLink
        {
            get { return balance;}
            set {balance += value;}
        }

        public float Val
        {
            set
            {
                this.theVal = value;
                // when the value changes, fire the event
                this.valueChanged(theVal);
                // this.objChanged(this, new ObjChangeEventArgs() { propChanged = "Val" });
            }
        }
    }

    class ObjChangeEventArgs : EventArgs
    {
        public float propChanged;
    }

    class Program
    {
        static void Main(string[] args)
        {
            float balance = 0;
            // create the test class
            EventPublisher obj = new EventPublisher();
            // Connect multiple event handlers
            obj.valueChanged += new myEventHandler(changeListener1);
            // obj.valueChanged += new myEventHandler(changeListener2);
            obj.valueChanged += new myEventHandler(updateAmount);


            // Use an anonymous delegate as the event handler
            // obj.valueChanged += delegate (float s)
            // {
            //     Console.WriteLine($"This came from the anonymous handler: {s}");
            // };

            static void updateAmount(float value)
            {
                
                Console.WriteLine($"Balance was: {balance}, will change with: {value}");
                Console.WriteLine("-----------------------------");

                // balance += value;
                // Console.WriteLine($"Balance is now: {balance}");

            }

            // obj.objChanged += delegate (object sender, ObjChangeEventArgs e)
            // {
            //     Console.WriteLine("{0} had the '{1}' property changed", sender.GetType(), e.propChanged);
            // };

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
                        Console.WriteLine($"Tallet {theFloat} ble konvertert riktig.");
                    }
                    else 
                    {
                        Console.WriteLine("Parsing feilet.");
                    }
                    obj.Val = theFloat;
                }
            } while (!str.Equals("exit"));
            Console.WriteLine("Goodbye!");
        }

        static void changeListener1(float value)
        {
            Console.WriteLine("The value changed to {0}", value);
        }
        static void changeListener2(float value)
        {
            Console.WriteLine("I also listen to the event, and got {0}", value);
        }
        
    }
}