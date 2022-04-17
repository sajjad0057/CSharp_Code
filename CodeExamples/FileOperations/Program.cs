

// File
// Directory 


// FileInfo 

// DirectoryInfo


string t = "hello \"world";


// check exists file or not :

if (File.Exists(@"F:\CSharp_Code\CodeExamples\FileOperations\hello.txt"))
    //if exists file , then delete this file :
    File.Delete(@"F:\CSharp_Code\CodeExamples\FileOperations\hello.txt");
else
    Console.WriteLine("File doesn't exists !");







