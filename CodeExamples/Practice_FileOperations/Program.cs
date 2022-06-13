var folderPath = new DirectoryInfo(Directory.GetCurrentDirectory()).Parent.Parent.Parent;
var filePath = Path.Combine(folderPath.FullName, "Data.str");

while (true)
{
    PrintOptions();
    int option = int.Parse(Console.ReadLine());

    if (option == 1)
    {
        Console.WriteLine("Enter the word:");
        var word = Console.ReadLine();
        var fileText = File.ReadAllText(filePath);

        if (!fileText.Contains(word))
            File.AppendAllText(filePath, word);

    }
    else if (option == 2)
    {
        Console.WriteLine("Enter the word:");
        var word = Console.ReadLine();
        var fileText = File.ReadAllText(filePath);

        if (fileText.Contains(word))
            Console.WriteLine("File already has the word.");
        else
            Console.WriteLine("File doesn't contain the word.");
    }
}


void PrintOptions()
{
    Console.WriteLine("Select an option:");
    Console.WriteLine("1) Add word");
    Console.WriteLine("2) Search word");
}