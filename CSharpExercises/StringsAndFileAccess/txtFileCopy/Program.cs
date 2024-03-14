// See https://aka.ms/new-console-template for more information
using System;
using System.IO;

string filepath = "CopyThis.txt";
if(File.Exists(filepath)) {
    Console.WriteLine("File exists!");
    string[] lines = File.ReadAllLines(filepath);
    
    Console.WriteLine("Content of CopyThis.txt");
    foreach(string line in lines) {
        Console.WriteLine(line);
    }
    Console.Write("\n");
} else {
    Console.WriteLine("File not found!");
}

string filePathToWrite = "CopyIntoThis.txt";
string[] data = { "Line 1", "Line 2", "Line 3"};

File.WriteAllLines(filePathToWrite, data);
Console.WriteLine("Data has been written onto CopyIntoThis.txt");
