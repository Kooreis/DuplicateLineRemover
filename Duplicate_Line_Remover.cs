using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        if (args.Length != 2)
        {
            Console.WriteLine("Usage: DuplicateLineRemover <inputfile> <outputfile>");
            return;
        }
    }
}