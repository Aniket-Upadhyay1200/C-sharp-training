using System;
using System.IO;


class FileHandling
{
    private string filePath;
     public FileHandling(string filePath)
    {
        this.filePath = filePath;
    }
     public void WriteInFile(filePath)
    {
        string[] colors = new string[5];

        Console.WriteLine("Enter your 5 favorite colors:");

        for (int i = 0; i < 5; i++)
        {
            Console.Write($"Color {i + 1}: ");
            colors[i] = Console.ReadLine();
        }

        try
        {
            File.WriteAllLines(filePath, colors);
            Console.WriteLine($"Colors successfully written to {filePath}");
        }
        catch (Exception ex)
        {
            Console.WriteLine("An error occurred while writing to the file: " + ex.Message);
        }
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

