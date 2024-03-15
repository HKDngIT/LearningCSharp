using System;
using System.IO;

main();

/* 1    Load the txt files for male and female names
*/
void main() {
    // Specify the path to the text file
    string m_filepath = "txtFiles/fNames.txt";

    // Read all lines from the file and fill the array with female names
    string[] m_fNames = File.ReadAllLines(m_filepath);

    // Test print all female Names
    foreach(string line in m_fNames) {
        Console.WriteLine(line);
    }
}