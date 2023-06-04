string inputFilePath = args[0];
string outputFilePath = args[1];

if (!File.Exists(inputFilePath))
{
    Console.WriteLine("Input file does not exist.");
    return;
}