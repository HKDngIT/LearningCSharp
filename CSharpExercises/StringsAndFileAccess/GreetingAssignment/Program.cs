using System;
using System.IO;

main();

/* 1    Load the txt files for male and female names
*/
void main() {
    // Specify the path to the text file for female names
    string m_filepath = "txtFiles/fNames.txt";

    // Read all lines from the file and fill the array with female names
    string[] m_fNames = File.ReadAllLines(m_filepath);

    // Test print all female Names
    foreach(string line in m_fNames) {
        Console.WriteLine(line);
    }
    Console.WriteLine($"m_fNames.length = {m_fNames.Length}");

    // Specify the path to the text file for male names
    m_filepath = "txtFiles/mNames.txt";

    // Read all lines from the file and fill the array with male names
    string[] m_mNames = File.ReadAllLines(m_filepath);
    
    // Test print all male Names
    foreach(string line in m_mNames) {
        Console.WriteLine(line);
    }
    Console.WriteLine($"m_mNames.length = {m_mNames.Length}");
}