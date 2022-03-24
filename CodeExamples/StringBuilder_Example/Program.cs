using System.Text;

//string ? x = Console.ReadLine();  // by this if we don't assing string in x; x set default null value . 
//Console.WriteLine(x);


string text = "Hello";

string text2 = "World";

StringBuilder text3 = new StringBuilder(text + text2);

for (int i = 0; i < text.Length; i++)
{
    if (text3[i] == 'e' || text3[i] == 'o')
        text3[i] = '_';     // here it is possible modifying in string conditionally, if text3 be object of StringBuilder . 
}


Console.WriteLine(text3);





/*
// if we use this , every string concatenation create a new object so that this way kill memory more 
string fulltext = string.Empty;

while (true)
{
    var line = Console.ReadLine();
    if (line == "")
        break;
    fulltext += line;
}
 
 */



// efficient way to modifying string using StringBuilder, that not create new object for every modification . 

StringBuilder fulltext = new StringBuilder();

Console.WriteLine("Give String , For exit loop Press double enter - ");

while (true)
{
    var line = Console.ReadLine();  
    if (line == "")
        break;
    fulltext.Append(line);
}

Console.WriteLine($"Befor converting string , Type of fulltext : {fulltext.GetType()}");
Console.WriteLine(fulltext);

// converting fulltext type StringBuilder to string :
string res =  fulltext.ToString();

Console.WriteLine($"After converting string , Type of fulltext : {res.GetType()}");




