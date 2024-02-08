using System;
using System.Drawing;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> shapes = new List<Shape>();
        Square squig = new Square("green", 4);
        Rectangle jeff = new Rectangle("blue", 2, 4);
        Circle greg = new Circle("black", 4);

        shapes.Add(squig);
        shapes.Add(jeff);
        shapes.Add(greg);

        foreach (Shape shape in shapes){
            string color = shape.GetColor();
            double area = shape.GetArea();
            Console.WriteLine($"The color is {color} and the area is {area}");
        }


    }
}