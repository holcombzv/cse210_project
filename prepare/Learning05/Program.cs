using System;

class Program
{
    static void Main(string[] args)
    {
        Square square = new Square(2);
        // Console.WriteLine(square.getArea());

        Rectangle rectangle = new Rectangle(2, 3);
        // Console.WriteLine(rectangle.getArea());

        Circle circle = new Circle(2);
        Console.WriteLine(circle.getArea());
    }
}