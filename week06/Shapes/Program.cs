using System;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> shapes = new List<Shape>();

        Square sOne = new Square("Red", 2);
        
        double areaSquare = sOne.GetArea();
        Console.WriteLine(areaSquare);

        Rectangle rOne = new Rectangle("Blue", 4, 6);
        
        double areaRectangle = rOne.GetArea();
        Console.WriteLine(areaRectangle);

        Circle cOne = new Circle("Yellow", 5);

        double areaCircle = cOne.GetArea();
        Console.WriteLine(areaCircle);
        
        shapes.Add(sOne);
        shapes.Add(rOne);
        shapes.Add(cOne);

        foreach (Shape s in shapes)
        {
            string color = s.GetColor();
            double area = s.GetArea();

            Console.WriteLine($"The {color} shape has an area of: {area}.");
        }
    }
}