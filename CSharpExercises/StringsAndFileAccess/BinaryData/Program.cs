using System;
using System.IO;

internal class Program
{
    private static void Main(string[] args)
    {
        // The array that has to be saved
        int[,] m_arrayToBeSaved = {
            {1, 2, 3},
            {4, 5, 6},
            {7, 8, 9}
        };

        // File path for the  binary file
        string m_filePath = "binaryFiles/data.bin";

        // Writing the array to the binary file
        writeArrayToBinaryFile(m_filePath, m_arrayToBeSaved);

        // Reading the array from the binary file
        int[,] m_readData = readArrayFromBinaryFile(m_filePath);

        // Output the read array
        Console.WriteLine("Read array:");
        PrintArray(m_readData);
    }

    /* receives the filepath and the 2-dimensional array and creates/ saves it to the corresponding
    binary file in the filepath
    */
    static void writeArrayToBinaryFile(string filepath, int[,] data) {
        using (FileStream fs = new FileStream(filepath, FileMode.Create))
        using (BinaryWriter writer = new BinaryWriter(fs))
        {
            // Writing the size of the array (number of rows and collumns)
            writer.Write(data.GetLength(0)); // Number of rows
            writer.Write(data.GetLength(1)); // Number of collumns

            // Writing the elements of the array
            for(int i = 0; i < data.GetLength(0); i++) {
                for(int j = 0; j < data.GetLength(1); j++) {
                    writer.Write(data[i, j]);
                }
            }
        }
    }

    /* Reads a two-dimensional integer array from a binary file located at the specified file path.
    */
    static int[,] readArrayFromBinaryFile(string filePath) {
        int [,] data;

        using (FileStream fs = new FileStream(filePath, FileMode.Open))
        using (BinaryReader reader = new BinaryReader(fs)) {
            // Reading the size of the array (number of rows and columns)
            int rows = reader.ReadInt32();
            int cols = reader.ReadInt32();

            // Creating a new array to store the read data
            data = new int[rows, cols];

            // Reading the elements of the array
            for(int i = 0; i < rows; i++) {
                for(int j = 0; j < cols; j++) {
                    data[i, j] = reader.ReadInt32();
                }
            }
        }
        return data;
    }

    static void PrintArray(int[,] array){
        int rows = array.GetLength(0);
        int cols = array.GetLength(1);

        for(int i = 0; i < rows; i++) {
            for(int j = 0; j < cols; j++) {
                Console.Write(array[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
}