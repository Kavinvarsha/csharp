using System;
interface IShape{
    double CalculateArea();  
}
class Circle : IShape{
    public double Radius { get; set; }
    public Circle(double radius){
        Radius = radius;
    }
    public double CalculateArea(){
        return Math.PI * Radius * Radius;
    }
}
class Rectangle : IShape{
    public double Length { get; set; }
    public double Width { get; set; }
    public Rectangle(double length, double width){
        Length = length;
        Width = width;
    }
    public double CalculateArea(){
        return Length * Width;
    }
}
class Program{
    static void Main(){
        IShape circle = new Circle(5);
        IShape rectangle = new Rectangle(4, 6);

        Console.WriteLine("Circle Area: " + circle.CalculateArea());
        Console.WriteLine("Rectangle Area: " + rectangle.CalculateArea());
    }
}
