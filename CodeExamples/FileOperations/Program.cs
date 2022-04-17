using System.Text;
using System.IO;

/*
------------------------------------------------------------------------------------------------
 Stream is One type of Connection Object. 
------------------------------------------------------------------------------------------------

 File
 Directory 

 FileInfo 
 DirectoryInfo
 
 */

/*
 * see given link for more info about File Operations in C# : 
 * 
https://www.c-sharpcorner.com/UploadFile/puranindia/file-handling-in-C-Sharp/ 
----------------------------------------------------------------------------------------------
********** Learn About More Files and Directories in C# see Given Link : **********
----------------------------------------------------------------------------------------------
https://www.c-sharpcorner.com/UploadFile/rohatash/working-with-the-fileinfo-class-in-C-Sharp/
*/

#region  check file exists or not / and How delete File :
// check file exists or not :

if (File.Exists(@"F:\CSharp_Code\CodeExamples\FileOperations\hello.txt"))
{
    Console.WriteLine("Exists file");
    //File.Delete(@"F:\CSharp_Code\CodeExamples\FileOperations\hello.txt");  // using delete() method carefully . is't can destroyed given path .
}
else
    Console.WriteLine("File doesn't exists !");

#endregion

#region Create file and Append text 
// Creating new file in using File.Create(Path/fileName.extension); 

//File.Create(@"F:\CSharp_Code\CodeExamples\FileOperations\hello.txt");


//using StreamWriter writer = File.AppendText(@"F:\CSharp_Code\CodeExamples\FileOperations\hello.txt");  // here using statement is dispose StreanWriter after finish this task . 

//writer.WriteLine("Hello World");

#endregion


#region Open file with verious Mode
/*
Stream is One type of Connection Object. FileStream  It is used to read from and write to any location within a file .  
*/

//using (FileStream fileStream = File.Open(@"F:\CSharp_Code\CodeExamples\FileOperations\hello.txt", FileMode.Append))
//{
//    // return a file Stream obejct  

//    string text = "This is Sajjad, I want to be a well software engineer";

//    byte[] data = Encoding.UTF8.GetBytes(text);            // By this convert text string to byte Array.Cz FileStream Object expect byte type data, not allow plain text 

//    //fileStream.Write(data);                             // write all text

//    fileStream.Write(data, 4, 10);                        // set offset, we can write specific portion of text. 
//};

#endregion

#region Copy One file to another place

//string sourceFilePath = @"F:\CSharp_Code\CodeExamples\FileOperations\hello.txt";

//string destinationFilePath = @"F:\CSharp_Code\CodeExamples\FileOperations\world2.txt";

// // static way to Copy file to another one :

//File.Copy(sourceFilePath, destinationFilePath);

#endregion

#region  Perform File Operation using FileInfo() object ( It's using (Object) better than static approach ).

// //Another way ( By creating object ) to Copy file to another one . we can aslo do all File Operation by creating FileInfo() Object. 

//string sourceFilePath = @"F:\CSharp_Code\CodeExamples\FileOperations\hello.txt";

////string destinationFilePath = @"F:\CSharp_Code\CodeExamples\FileOperations\world2.txt";

//FileInfo fileInfo = new FileInfo(sourceFilePath);
//if (fileInfo.Exists)
//{
//    fileInfo.Delete();
//}

#endregion
















