```CSharp
using System;
using System.IO;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        if (args.Length != 2)
        {
            Console.WriteLine("Usage: DuplicateLineRemover <inputfile> <outputfile>");
            return;
        }

        string inputFilePath = args[0];
        string outputFilePath = args[1];

        if (!File.Exists(inputFilePath))
        {
            Console.WriteLine("Input file does not exist.");
            return;
        }

        var lines = File.ReadAllLines(inputFilePath);
        var distinctLines = lines.Distinct();

        File.WriteAllLines(outputFilePath, distinctLines);

        Console.WriteLine("Duplicate lines removed successfully.");
    }
}
```