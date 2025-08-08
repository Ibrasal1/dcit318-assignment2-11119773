using System;

namespace InterfaceDemo
{
    // Interface
    interface IMovable
    {
        void Move();
    }

    // Car class
    class Car : IMovable
    {
        public void Move()
        {
            Console.WriteLine("Car is moving");
        }
    }

    // Bicycle class
    class Bicycle : IMovable
    {
        public void Move()
        {
            Console.WriteLine("Bicycle is moving");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("INTERFACE DEMO\n");

            IMovable car = new Car();
            IMovable bicycle = new Bicycle();

            car.Move();       // Output: Car is moving
            bicycle.Move();   // Output: Bicycle is moving

            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}
