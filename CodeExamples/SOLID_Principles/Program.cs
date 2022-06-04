using SOLID_Principles;

Square square = new Square();

square.Width = 5;
Console.WriteLine($"Result -  Area of this Square : {square.CalculateArea()} ");



Rectangle regtangle = new Rectangle();
regtangle.Width = 50;
regtangle.Height = 25;

Console.WriteLine($"Result - Area of this Rectangle : {regtangle.CalculateArea()}");
