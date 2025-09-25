using System;
using System.IO;

class Program
{
    static void Main()
    {
        Console.Write("Enter source file path: ");
        string sourcePath = Console.ReadLine();

        Console.Write("Enter destination file path: ");
        string destPath = Console.ReadLine();

        try
        {
            // Read all text from source file
            string content = File.ReadAllText(sourcePath);

            // Write content to destination file
            File.WriteAllText(destPath, content);

            Console.WriteLine("File copied successfully!");
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error: " + ex.Message);
        }
    }
}
