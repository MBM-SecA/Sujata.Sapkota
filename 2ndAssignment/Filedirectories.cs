using System;
using System.IO;
using System.Linq;
public class FileIO
{
    public void LearnDirectories()
    {
        Directory.CreateDirectory(@"E:\gitt\Sujata.Sapkota\2ndAssignment\ABC");
        string fileHello = File.ReadAllText("Hello.cs");
        for (int i = 0; i < 10; i++)
        {
            Directory.CreateDirectory($"E:/gitt/Sujata.Sapkota/2ndAssignment/ABC/Folder{i + 1}");
            File.WriteAllText($"E:/gitt/Sujata.Sapkota/2ndAssignment/ABC/Folder{i + 1}/Hello.cs", fileHello);
        }
    }
    static void Main (string[] args)
    {
        FileIO fileIO = new FileIO();
        fileIO.LearnDirectories();
    }
} 
