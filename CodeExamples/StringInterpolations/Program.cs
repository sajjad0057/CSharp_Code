Console.WriteLine($"{{\"Hello\": \"{1+1}\"}}");

Console.WriteLine("-------------------Test Collections -----------------------");


var data = new[]
{
        new KeyValuePair<string, string>("name", "John Doe"),
        new KeyValuePair<string, string>("email", "johndoe@example.com"),
};

var dict = new Dictionary<string, string>()
{
    {"x1","y1"},
    {"x2","y2"}, 
    {"x3","y3"},
    {"x4","y4"}
};

Console.WriteLine();
