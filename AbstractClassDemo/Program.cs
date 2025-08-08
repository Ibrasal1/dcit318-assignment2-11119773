using System;

namespace AbstractClassDemo
{
    // Abstract class
    abstract class Shape
    {
        public abstract double GetArea();
    }

    // Circle class
    class Circle : Shape
    {
        public double Radius { get; set; }

        public Circle(double radius)
        {
            Radius = radius;
        }

        public override double GetArea()
        {
            return Math.PI * Radius * Radius;
        }
    }

    // Rectangle class
    class Rectangle : Shape
    {
        public double Width { get; set; }
        public double Height { get; set; }

        public Rectangle(double width, double height)
        {
            Width = width;
            Height = height;
        }

        public override double GetArea()
        {
            return Width * Height;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ABSTRACT CLASS DEMO\n");

            // Circle
            Console.Write("Enter radius of circle: ");
            double radius = Convert.ToDouble(Console.ReadLine());
            Shape circle = new Circle(radius);
            Console.WriteLine($"Area of circle: {circle.GetArea()}");

            // Rectangle
            Console.Write("\nEnter width of rectangle: ");
            double width = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter height of rectangle: ");
            double height = Convert.ToDouble(Console.ReadLine());
            Shape rectangle = new Rectangle(width, height);
            Console.WriteLine($"Area of rectangle: {rectangle.GetArea()}");

            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}
