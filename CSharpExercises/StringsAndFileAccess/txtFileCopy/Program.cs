// See https://aka.ms/new-console-template for more information
using System;
using System.IO;

string filepath = "CopyThis.txt";
if(File.Exists(filepath)) {
    Console.WriteLine("File exists!");
    string[] lines = File.ReadAllLines(filepath);
    
    foreach(string line in lines) {
        Console.WriteLine(line);
    }
} else {
    Console.WriteLine("File not found!");
}