

// File
// Directory 


// FileInfo 

// DirectoryInfo

/*
 * see given link for more info about File Operations in C# : 
 * 
https://www.c-sharpcorner.com/UploadFile/puranindia/file-handling-in-C-Sharp/ 
*************Learn About More Files and Directories in C# see Given Link : **********
https://www.c-sharpcorner.com/UploadFile/rohatash/working-with-the-fileinfo-class-in-C-Sharp/
*/

string t = "hello \"world";


// check exists file or not :

if (File.Exists(@"F:\CSharp_Code\CodeExamples\FileOperations\hello.txt"))
{
    Console.WriteLine("Exists file");
    //File.Delete(@"F:\CSharp_Code\CodeExamples\FileOperations\hello.txt");  // using delete() method carefully . is't can destroyed given path .
}
else
    Console.WriteLine("File doesn't exists !");




// Creating new file in using File.Create(Path/fileName.extension); 

//File.Create(@"F:\CSharp_Code\CodeExamples\FileOperations\hello.txt");


using StreamWriter writer = File.AppendText(@"F:\CSharp_Code\CodeExamples\FileOperations\hello.txt");  // here using statement is dispose StreanWriter after finish this task . 

writer.WriteLine("Hello World");













