using StructureExamples;

// Value Type 
int x1 = 5;
int x2 = x1;
Console.WriteLine($"x1 = {x1}");
x2 = 9;
x1 = 7;
Console.WriteLine($"x2 = {x2} ; x1 = {x1}");



Product p1 = new Product();

p1.Name = "Camera";
p1.Price = 2000;
p1.Name = "nokia";


Product p2 = new Product();
p2 = p1;

Console.WriteLine($"P2:Name {p2.Name}, P2:Price {p2.Price}");

p2.Name = "Television";
p2.Price = 50000;

Console.WriteLine($"P1:Name {p1.Name}, P1:Price {p1.Price}");

Console.WriteLine($"P2:Name {p2.Name}, P2:Price {p2.Price}");

Console.WriteLine($"P1 is Product  ? : {p1 is Product}");

