using System;
using System.IO;

class SimpleFileReaderWriter
{
    // Method to read data from input file, process it, and write to output file
    public static void ProcessFile(string inputFilePath, string outputFilePath)
    {
        try
        {
            // Read data from input file
            string[] lines = File.ReadAllLines(inputFilePath);

            // Process the data
            string processedData = ProcessData(lines);

            // Write processed data to output file
            File.WriteAllText(outputFilePath, processedData);
            Console.WriteLine("Data successfully written to the output file.");
        }
        catch (FileNotFoundException)
        {
            Console.WriteLine("Input file not found.");
        }
        catch (IOException e)
        {
            Console.WriteLine($"An error occurred: {e.Message}");
        }
    }

    // Method to process data as needed
    public static string ProcessData(string[] lines)
    {
        // Example processing - converting all text to uppercase
        string result = "";
        foreach (var line in lines)
        {
            result += line.ToUpper() + "\n";
        }
        return result;
    }

    // Main method to run the program
    static void Main(string[] args)
    {
        string inputFilePath = "input.txt";
        string outputFilePath = "output.txt";
        ProcessFile(inputFilePath, outputFilePath);
        Console.ReadLine(); // To prevent console from closing
    }
}
