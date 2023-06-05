# Python Documentation

# Python Script: Remove Duplicates

This repository contains a Python script that removes duplicate lines from a text file. The script is named `remove_duplicates.py`.

## Script Description

The script `remove_duplicates.py` reads a text file, removes any duplicate lines, and writes the unique lines back to the same file. The script uses Python's built-in `set` data structure to ensure uniqueness of lines.

## How to Use

To use this script, simply call the function `remove_duplicates` with the filename of the text file you want to process as an argument. For example:

```python
remove_duplicates('yourfile.txt')
```

This will remove any duplicate lines from `yourfile.txt`.

## Code Explanation

The script does not import any external libraries. It uses only built-in Python functions and data structures.

Here is a brief explanation of the code:

```python
def remove_duplicates(filename):
    lines = open(filename, 'r').readlines()
    lines_set = set(lines)
    out = open(filename, 'w')
    for line in lines_set:
        out.write(line)
```

- `def remove_duplicates(filename):` This line defines the function `remove_duplicates` that takes a filename as an argument.
- `lines = open(filename, 'r').readlines()` This line opens the file in read mode and reads all lines into a list.
- `lines_set = set(lines)` This line converts the list of lines into a set, which automatically removes any duplicates because sets only allow unique elements.
- `out = open(filename, 'w')` This line opens the file again, this time in write mode. This will overwrite the original file.
- `for line in lines_set:` This line starts a loop that goes through each unique line in the set.
- `out.write(line)` This line writes each unique line back to the file.

## Conclusion

This script is a simple and efficient way to remove duplicate lines from a text file using Python. It can be easily integrated into larger projects or used as a standalone tool.

---

# C# Documentation

# Duplicate Line Remover

This is a simple C# script that removes duplicate lines from a text file. The script takes two command-line arguments: the path to the input file and the path to the output file. It reads all lines from the input file, removes duplicates, and writes the result to the output file.

## Libraries Used

The script uses the following libraries:

- `System`: This is a fundamental library in C# that provides base functionalities such as Console I/O operations.

- `System.IO`: This library is used for reading from and writing to files. In this script, it is used to check if the input file exists, read all lines from the input file, and write the result to the output file.

- `System.Linq`: This library provides a set of query operators that can be used to perform operations on sequences of data. In this script, it is used to remove duplicate lines from the input file.

## Code Explanation

The script first checks if the correct number of command-line arguments have been provided. If not, it prints a usage message and exits.

Next, it checks if the input file exists. If not, it prints an error message and exits.

The script then reads all lines from the input file into an array of strings. It uses the `Distinct` method from the `System.Linq` library to remove duplicate lines.

Finally, it writes the result to the output file and prints a success message.

## Usage

To use this script, compile it and run it from the command line as follows:

```
DuplicateLineRemover <inputfile> <outputfile>
```

Replace `<inputfile>` with the path to the input file and `<outputfile>` with the path to the output file.

---

# Java Documentation

# Duplicate Line Remover

This Java script is designed to remove duplicate lines from a text file. It reads from an input file, removes any duplicate lines, and writes the unique lines to an output file.

## How it Works

The script uses a `BufferedReader` to read the input file line by line. Each line is then added to a `LinkedHashSet`. This data structure automatically removes any duplicate entries, ensuring that only unique lines are stored. The unique lines are then written to the output file using a `BufferedWriter`.

## Imported Libraries

The script uses the following Java libraries:

- `java.io.*`: This library provides classes for system input and output through data streams, serialization and the file system. In this script, it is used to read from and write to text files.

- `java.util.*`: This library contains the collections framework, legacy collection classes, event model, date and time facilities, internationalization, and miscellaneous utility classes. In this script, it is used to create a `LinkedHashSet` which stores the unique lines from the input file.

## Code Breakdown

```java
import java.io.*;
import java.util.*;
```
These are the imported libraries that the script uses.

```java
public class DuplicateLineRemover {
```
This is the main class of the script.

```java
public static void main(String[] args) throws IOException {
```
This is the main method that the Java runtime environment calls.

```java
BufferedReader reader = new BufferedReader(new FileReader("input.txt"));
```
This line creates a `BufferedReader` that reads from a file named "input.txt".

```java
Set<String> lines = new LinkedHashSet<String>();
```
This line creates a `LinkedHashSet` that stores the unique lines from the input file.

```java
while ((line = reader.readLine()) != null) {
    lines.add(line);
}
```
This loop reads the input file line by line and adds each line to the `LinkedHashSet`.

```java
BufferedWriter writer = new BufferedWriter(new FileWriter("output.txt"));
```
This line creates a `BufferedWriter` that writes to a file named "output.txt".

```java
for (String unique : lines) {
    writer.write(unique);
    writer.newLine();
}
```
This loop writes each unique line from the `LinkedHashSet` to the output file.

```java
reader.close();
writer.close();
```
These lines close the `BufferedReader` and `BufferedWriter`, releasing any system resources associated with them.

---
