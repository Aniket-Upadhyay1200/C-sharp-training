using System;
using System.IO;


class FileHandling
{
    private string filePath;
    public FileHandling(string filePath)
    {
        this.filePath = filePath;
    }
    public void ReadAndDisplayFile()
    {
        try
        {
            string content = File.ReadAllText(filePath);
            Console.WriteLine("File Content:");
            Console.WriteLine(content);
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error reading file: {ex.Message}");
        }
    }
    
}