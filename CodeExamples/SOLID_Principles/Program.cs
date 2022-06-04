using SOLID_Principles;

Square square = new Square();

square.Width = 5;
Console.WriteLine($"Result -  Area of this Square : {square.CalculateArea()} ");

Rectangle regtangle = new Rectangle();
regtangle.Width = 50;
regtangle.Height = 25;

Console.WriteLine($"Result - Area of this Rectangle : {regtangle.CalculateArea()}");


Console.WriteLine("======================================================================================================");

IEngine engine = new Engine();

Car c = new Car(engine);

c.Model = "FordMass-Market Cars1903-Present";
c.Color = "Blue";
c.Start();

IEngine engine2 = new TurboEngine();

Car c2 = new Car(engine2);
c2.Model = "Mahindra Scorpio";
c2.Color = "Red";
c2.Start();
