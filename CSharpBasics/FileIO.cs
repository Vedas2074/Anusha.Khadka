using System;
using System.IO;
namespace FileDirectoryHandling
{
    public class FileIO
    {
        public void LearnFileReading()
        {
            string fileContent = File.ReadAllText(@"F:\Test.txt");
            Console.WriteLine(fileContent);
        }
         public void LearnFileWriting()
        {
            File.WriteAllText("A.html", "I am new file just created.");
        }
        public void LearnFileInfo()
        {
            FileInfo fileInfo = new FileInfo("A.html");
            var x = fileInfo.Length;
            var y = fileInfo.CreationTime;
            var z = fileInfo.DirectoryName;
            Console.WriteLine($"File Size: {x} bytes");
            Console.WriteLine($"Created: {y} bytes");
            Console.WriteLine($"Directory: {z} bytes");
        }
        internal void LearnDirectory()
        {
            Directory.CreateDirectory("ABC");
            File.WriteAllText(@"ABC\a.Nepal" , "This is File.");

        }

        internal void LearnDirectoryInfo()
        {
            string folderpath = @"D:\files";
            DirectoryInfo directory = new DirectoryInfo(folderpath);
            var files = directory.GetFiles();
            Console.WriteLine("File count : " + files.Length);
        }
    }
}