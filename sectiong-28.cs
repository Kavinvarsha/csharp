using System;
interface IShape{
    void Draw();
}
class Circle : IShape{
    public void Draw(){
        Console.WriteLine("Drawing a Circle");
    }}
class Rectangle : IShape{
    public void Draw(){
        Console.WriteLine("Drawing a Rectangle");
    }}
class ShapeFactory{
    public IShape GetShape(string shapeType) {
        if (shapeType.Equals("Circle", StringComparison.OrdinalIgnoreCase)){
            return new Circle();
        }
        else if (shapeType.Equals("Rectangle", StringComparison.OrdinalIgnoreCase)) {
            return new Rectangle();
        }
        else{
            return null;
        }
    }
}
class Program{
    static void Main(){
        ShapeFactory factory = new ShapeFactory();
        IShape shape1 = factory.GetShape("Circle");
        shape1.Draw();
        IShape shape2 = factory.GetShape("Rectangle");
        shape2.Draw();
    }
}
