using System.IO;
using System;
public class FileIO
{
    public void LearnFileHandling()
    {
        string fileName = "file.txt";
        if (File.Exists(fileName))
        {
       string fileContent = File.ReadAllText(fileName);
       Console.WriteLine(fileContent);
        }
        File.WriteAllText(fileName,"This is just a test file");
        
        
    
    }

    internal static object ReadAllText(string v)
    {
        throw new NotImplementedException();
    }

    public void LearnFileInfo()
    {
     string fileName = "file.txt";
     FileInfo fileInfo= new FileInfo(fileName);
     var size =- fileInfo.Length;
     var createdDate = fileInfo.CreationTime;

     Console.WriteLine($"File Size: {size} bytes");

     Console.WriteLine($"Created: {createdDate}");


    }
    public void LearnDirectories()
    {
        string directoryName = "A";
        Directory.CreateDirectory(directoryName);
    }
    // q2: create a folder"ABC" create 10 subfolders in "ABC".each subfolder
    // should contain a c# file with "hello World program
}