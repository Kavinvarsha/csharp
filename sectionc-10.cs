using System;
namespace InheritanceDemo
{
    class Vehicle
    {
        public int Speed;
        public string Color;
 public void Start()
        {
            Console.WriteLine("Vehicle started");
        }
public void Stop()
        {
            Console.WriteLine("Vehicle stopped");
        }
    }
    class Car : Vehicle
    {
        public int NumberOfDoors;
public void ShowCarDetails()
        {
            Console.WriteLine($"Car Color: {Color}, Speed: {Speed}, Doors: {NumberOfDoors}");
        }
    }
    class Bike : Vehicle
    {
        public bool HasCarrier;
public void ShowBikeDetails()
        {
            Console.WriteLine($"Bike Color: {Color}, Speed: {Speed}, Has Carrier: {HasCarrier}");
        }
    }

    class Program
    {
        static void Main()
        {
            Car myCar = new Car();
            myCar.Color = "Red";
            myCar.Speed = 120;
            myCar.NumberOfDoors = 4;
            myCar.Start(); 
            myCar.ShowCarDetails();
            myCar.Stop();  

            Console.WriteLine();
            Bike myBike = new Bike();
            myBike.Color = "Black";
            myBike.Speed = 80;
            myBike.HasCarrier = true;
            myBike.Start(); 
            myBike.ShowBikeDetails();
            myBike.Stop();  
        }
    }
}
