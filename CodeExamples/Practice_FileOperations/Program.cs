using System.Text;
using System.IO;


Console.WriteLine("Welcome to perform basic file Operations : ");
Console.WriteLine("Add Or Search Your Word -  ");
Console.WriteLine("-------------------------------------------------------------------------------------");

string currentDirectoy = Directory.GetCurrentDirectory();

DirectoryInfo directoryInfo = new DirectoryInfo(currentDirectoy);  // creating directoryInfo object here



/// <summary>
/// Here , directoryInfo object return Full routh of this project directory that contains net[version_no] folder .
///</summary>


string path = directoryInfo.Parent.Parent.Parent.ToString();

////Console.WriteLine($"{path}; type : {path.GetType()}");

////Console.WriteLine(SearchWord("sajjad"));

////Console.WriteLine(FileExistsOrNot());

Console.WriteLine("Press 1 for Add Word -  ");
Console.WriteLine("Press 2 for Search Word - ");
Console.WriteLine("Press Any Key For Exit - ");
string command = Console.ReadLine().Trim();
Console.WriteLine("-----------------------------------------------------");

if (command == "1")
{
    Console.Write("Enter a Word : ");
    string textNote = Console.ReadLine().Trim();
    Console.WriteLine("-----------------------------------------------------");

    if (SearchWord(textNote))
    {
        Console.WriteLine("This Word Is Already Exists in file !");
    }
    else
    {
        if (!FileExistsOrNot())
        {
            using StreamWriter writer = File.CreateText($"{path}\\data.str");
            writer.WriteLine(textNote);
            Console.WriteLine("File Created and Add Your Word Successfully ! ");

        }
        else if (FileExistsOrNot())
        {
            using StreamWriter writer = File.AppendText($"{path}\\data.str");
            writer.WriteLine(textNote);
            Console.WriteLine("Your Word added Successfully ! ");
        }
        else
        {
            Console.WriteLine("Something Wrong ! Check Please ! ");
        }
    }

}
else if (command == "2")
{
    Console.Write("Enter a Word : ");
    string textNote = Console.ReadLine().Trim();
    Console.WriteLine("-----------------------------------------------------");
    if (SearchWord(textNote))
    {
        Console.WriteLine("This Word is Exists in this File !");
    }
    else
    {
        Console.WriteLine("This Word does not Exists in this File !");
    }
}







bool SearchWord(string word)
{
    if (FileExistsOrNot())
    {
        using (StreamReader reader = new StreamReader($"{path}\\data.str"))
        {
            string line = null;
            bool found = false;
            while ((line = reader.ReadLine()) != null)
            {
                string[] words = line.Split();
                foreach (string w in words)
                {
                    //Console.WriteLine(w);
                    if (w == word)
                    {
                        found = true;
                        break;
                    }
                }
            }
            return found;
        }

    }
    else
    {
        return false;
    }
}



bool FileExistsOrNot()
{
    return File.Exists($"{path}\\data.str");
}




