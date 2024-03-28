using System;
using System.IO;
using Microsoft.Win32.SafeHandles;

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

    /*###############################################################################*/

    // Let user enter a name
    string m_input;
    Console.WriteLine("Please enter a Name(First name last name): ");
    m_input = Convert.ToString(Console.ReadLine());

    // Split up the entered name
    string[] parts = m_input.Split(' ');
    string m_firstName = parts[0];
    string m_surName = parts[1];

    foreach(string line in m_fNames) {
        if(line == m_firstName) {
            Console.Write("Ms. ");
        }
    }

    foreach(string line in m_mNames) {
        if(line == m_firstName) {
            Console.Write("Mr. ");
        }
    }

    Console.Write($"{m_firstName} {m_surName} \n");

}