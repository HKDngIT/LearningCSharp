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

    // Print all female Names
    Console.WriteLine("Female Names: ");
    foreach(string line in m_fNames) {
        Console.WriteLine("    " + line);
    }

    // Specify the path to the text file for male names
    m_filepath = "txtFiles/mNames.txt";

    // Read all lines from the file and fill the array with male names
    string[] m_mNames = File.ReadAllLines(m_filepath);
    
    // Print all male Names
    Console.WriteLine("\nMale Names: ");
    foreach(string line in m_mNames) {
        Console.WriteLine("    " + line);
    }
}