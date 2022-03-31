using Task3;

IShape r = new Rectangle(6, 4);

Console.WriteLine(r.CalculateArea());
Console.WriteLine(r.CalculatePerimeter());


IShape t = new Triangle(5,6,7);
Console.WriteLine(t.CalculateArea());
Console.WriteLine(t.CalculatePerimeter());


IShape c = new Circle(4);
Console.WriteLine(c.CalculateArea());
Console.WriteLine(c.CalculatePerimeter());