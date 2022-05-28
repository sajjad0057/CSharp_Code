using System.Text;


string filePath = @"F:\CSharp_Code\CodeExamples\new_using_keyword\hello.txt";



//// Example of old using keyword uses here, uses curly braces , to define despose scope 

using (FileStream fileStream = File.Open(filePath , FileMode.Append))
{
    // return a file Stream obejct  

    string text = "This is xyz, I want to be a well software engineer";

    byte[] data = Encoding.UTF8.GetBytes(text);           // By this convert text string to byte Array.Cz FileStream Object expect byte type data, not allow plain text 

    //fileStream.Write(data);                             // write all text

    fileStream.Write(data, 4, 10);                        // set offset, we can write specific portion of text. 
};



//// Example of new using keyword uses , here does not needed curly braces


using FileStream fileStream2 = File.Open(filePath, FileMode.Append); 

string text2 = "This is Sajjad, I want to be a well software engineer";

byte[] data2 = Encoding.UTF8.GetBytes(text2);            // By this convert text string to byte Array.Cz FileStream Object expect byte type data, not allow plain text 

//fileStream.Write(data);                                // write all text

fileStream2.Write(data2, 4, 10);                         // set offset, we can write specific portion of text. 



Console.WriteLine("====================================================================================================");



Console.WriteLine("Updated hello.txt file -- plz check it to open hello.txt file");
