// See https://aka.ms/new-console-template for more information
using System;
using System.IO;

main();

void main() {
    //example();

    // Specify the path to the text file
    string filepath = "CopyThis.txt";

    // Read all lines from the file and save into string array content
    string[] content = File.ReadAllLines(filepath);

    // Change filepath to new text file
    filepath = "CopyIntoThis.txt";

    // Write data into the file
    File.WriteAllLines(filepath, content);
    Console.WriteLine("Data has been copied from CopyThis.txt into CopyIntoThis.txt"); 
}

void example(){
    // Specify the path of the text file
    string filepath = "CopyThis.txt";

    // Check if the file exists
    if(File.Exists(filepath)) {
        Console.WriteLine("File exists!");

        // Read all lines from the file
        string[] lines = File.ReadAllLines(filepath);

        // Display each line
        Console.WriteLine("Content of CopyThis.txt");
        foreach(string line in lines) {
            Console.WriteLine(line);
        }
        Console.Write("\n");
    } else {
        Console.WriteLine("File not found!");
    }

    // Specify the path of the text file
    string filePathToWrite = "CopyIntoThis.txt";

    // Data to be written
    string[] data = { "Line 1", "Line 2", "Line 3"};

    // Write data into the file
    File.WriteAllLines(filePathToWrite, data);
    Console.WriteLine("Data has been written onto CopyIntoThis.txt");   
}
