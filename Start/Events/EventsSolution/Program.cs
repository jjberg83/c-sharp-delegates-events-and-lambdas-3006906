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
            // create the test class
            EventPublisher obj = new EventPublisher();
            // Connect multiple event handlers
            obj.valueChanged += new myEventHandler(changeListener1);
            obj.valueChanged += new myEventHandler(changeListener2);

            // Use an anonymous delegate as the event handler
            obj.valueChanged += delegate (float s)
            {
                Console.WriteLine($"This came from the anonymous handler: {s}");
            };

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