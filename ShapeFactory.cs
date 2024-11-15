public class Shape
{
    public virtual void Draw()
    {
        Console.WriteLine("Drawing a shapeshape");
    }
}

public class Circle : Shape
{
    public override void Draw()
    {
        Console.WriteLine("Drawing a circle");
    }
}

public class Rectangle : Shape
{
    public override void Draw()
    {
        Console.WriteLine("Drawing a rectangle");
    }
}

public class Triangle : Shape
{
    public override void Draw()
    {
        Console.WriteLine("Drawing a triangle");
    }
}

class ShapeFactory
{
    public static Shape CreateShape()
    {
        return new Triangle();
    }
}
class Program1 {
    public static void Main_poly (string[] args) {
        Console.WriteLine("This is a shape factory");
        Shape shape1 = new Shape();
        Shape shape2 = new Circle();
        Shape shape3 = new Rectangle();
        Shape shape4 = new Triangle();
        Shape shape5 = ShapeFactory.CreateShape();

        shape1.Draw(); // Outputs "Drawing a shape"
        shape2.Draw(); // Outputs "Drawing a circle"
        shape3.Draw(); // Outputs "Drawing a rectangle"
        shape4.Draw(); // Outputs "Drawing a triangle"     
        shape5.Draw();
    }
}