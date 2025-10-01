using System;
namespace MethodOverridingDemo
{
    class Vehicle{
        public virtual void Start()
        {
            Console.WriteLine("Vehicle is starting...");
        }
    }
   class Car : Vehicle{
        public override void Start()
        {
            Console.WriteLine("Car is starting with a key...");
        }
    }
    class Bike : Vehicle{
        public sealed override void Start()
        {
            Console.WriteLine("Bike is starting with a self-start button...");
        }
    }
    class Program{
        public static void Main()
        {
            Vehicle v = new Vehicle();
            v.Start();   
            Car c = new Car();
            c.Start();  
            Bike b = new Bike();
            b.Start();  
        }
    }
}
