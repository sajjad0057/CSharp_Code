using System.Text;
using System.IO;


Console.WriteLine("Welcome to perform basic file Operations : ");
Console.WriteLine("-------------------------------------------------------------------------------------");

string currentDirectoy = Directory.GetCurrentDirectory();

DirectoryInfo directoryInfo = new DirectoryInfo(currentDirectoy);  // creating directoryInfo object here


/// <summary>
/// Here , directoryInfo object return Full routh of this project directory that contains net[version_no] folder .
///</summary>


string path = directoryInfo.Parent.Parent.Parent.ToString();

Console.WriteLine("Enter file name with .extension must : ");

string fileName = Console.ReadLine();

Console.WriteLine($"{path}; type : {path.GetType()}");

Console.WriteLine("Enter Text note to Add this text file : ");

string textNote = Console.ReadLine();


void AppendTextNoteToFile(string textnote)
{
    using StreamWriter writer = File.AppendText($"{path}\\{fileName}");
    writer.WriteLine(textnote + " ");
    Console.WriteLine("Text Added Succesfully ! ");
}

if (!File.Exists($"{path}\\{fileName}"))
{
    File.Create($"{path}\\{fileName}");
    Console.WriteLine("File Added Sucessfully , Please Again Add Text : ");

}
else if (File.Exists($"{path}\\data.str"))
{
    AppendTextNoteToFile(textNote);
}
else
{
    Console.WriteLine("Something Wrong ! Check Please ! ");
}
