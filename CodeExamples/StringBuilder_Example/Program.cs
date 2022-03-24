using System.Text;

//string ? x = Console.ReadLine();  // by this if we don't assing string in x; x set default null value . 
//Console.WriteLine(x);


string text = "Hello";

string text2 = "World";

string text3 = text + text2;

//for (int i = 0; i < text.Length; i++)
//{
//    if (text[i] == 'a' || text[i] == 'b')
//        text[i] = '_';     // here not possible modifying in string conditionally . 
//}





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

while (true)
{
    var line = Console.ReadLine();  
    if (line == "")
        break;
    fulltext.Append(line);
}


Console.WriteLine(fulltext);