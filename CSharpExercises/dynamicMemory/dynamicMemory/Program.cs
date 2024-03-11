// See https://aka.ms/new-console-template for more information
using System.Data;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

/* This function is just used to run the exercises
 */
execute();
void execute()
{
    //exercise1();
    //exercise2();
    //exercise3();
    //exercise4();
    exercise5();
}

/*###########################################################################################################################################################*/
/* Exercise 1
 * Copy an array with doubled array elements
 */
unsafe void exercise1()
{
    int[] iArray1 = { 1, 2, 3 };
    int* iArray2 = twiceret(iArray1, iArray1.Length);

    // Print the result
    for(int i = 0; i < 3; i++)
    {
        Console.Write(iArray1[i] + " ");
    }
    Console.Write('\n');
    for (int i = 0; i < 3; i++)
    {
        Console.Write(iArray2[i] + " ");
    }
    Console.Write('\n');

    // Free the allocated memory
    Marshal.FreeHGlobal((IntPtr)iArray2);
}

unsafe int* twiceret(int[] arr, int length)
{
    // Allocate the unmanaged memory for an int array of 3 integers
    IntPtr ptr = Marshal.AllocHGlobal(Marshal.SizeOf(typeof(int)) * 3);

    // Access and use the allocated memory
    int* twice = (int*)ptr.ToPointer();
    for (int index = 0; index < length; index++)
    {
        twice[index] = arr[index] * 2;
    }
    return twice;
}

/*###########################################################################################################################################################*/
/* Exercise 2
 * Summarizing 2 arrays
 */
unsafe void exercise2() {
    int[] iArray1 = { 1, 2, 3 };
    int[] iArray2 = { 4, 5, 6 };

    int* iArrayAdd = vadd(iArray1, iArray2, 3);

    // Print the result
    for(int i = 0; i < 3; i++)
    {
        Console.Write(iArrayAdd[i] + " ");
    }

    // Free the allocated memory
    Marshal.FreeHGlobal((IntPtr)iArrayAdd);
}

unsafe int* vadd(int[] arr1, int[] arr2, int length)
{
    // Allocate the unmanaged memory for an int array of 3 integers
    IntPtr ptr = Marshal.AllocHGlobal(Marshal.SizeOf(typeof(int)) * 3);

    // Access and use the allocated memory
    int* arrx = (int*)ptr.ToPointer();
    for(int i = 0; i < length; i++)
    {
        arrx[i] = arr1[i] + arr2[i];
    }
    return arrx;
}

/*###########################################################################################################################################################*/
/* Exercise 3
 * 2-Dimensional arrays
 */

void exercise3()
{
    Console.Write("Arraysize: ");
    int iAS = Convert.ToInt32(Console.ReadLine());

    int[,] array2D = new int[iAS, iAS];

    // Filling the array
    for(int i = 0; i < iAS; i++)
    {
        for(int y = 0;  y < iAS; y++)
        {
            array2D[i, y] = i + y;
        }
    }

    // Output the array on the console
    for(int i = 0; i < iAS; i++)
    {
        for(int y = 0; y < iAS; y++)
        {
            Console.Write("[{0}]", array2D[i, y]);
        }
        Console.WriteLine("\n");
    }
}

/*###########################################################################################################################################################*/
/* Exercise 4
 * 2-Dimensional arrays with initial value
 */

void exercise4()
{
    int iRow;
    int iCollumn;
    int iValue;

    Console.Write("Please enter m: ");
    iRow = Convert.ToInt32(Console.ReadLine());


    Console.Write("Please enter n: ");
    iCollumn = Convert.ToInt32(Console.ReadLine());


    Console.Write("Please enter initial value: ");
    iValue = Convert.ToInt32(Console.ReadLine());

    int[,] iArray = new int[iRow, iCollumn];

    fillArray(iArray, iValue);

    printArray(iArray);
}

// Fills the array with the initial value
void fillArray(int[,] array, int initialValue)
{
    for (int rowindex = 0; rowindex < array.GetLength(0); rowindex++)
    {
        for (int collumnindex = 0; collumnindex < array.GetLength(1); collumnindex++)
        {
            array[rowindex, collumnindex] = initialValue;
        }
    }
}

// Outputs the array on the console
void printArray(int[,] array)
{
    for (int rowindex = 0; rowindex < array.GetLength(0); rowindex++)
    {
        for (int collumnindex = 0; collumnindex < array.GetLength(1); collumnindex++)
        {
            Console.Write("[{0}] ", array[rowindex, collumnindex]);
        }
        Console.Write("\n");
    }
}

/*###########################################################################################################################################################*/
/* Exercise 5
 * Pascal's Triangle
 */

void exercise5()
{
    int iValue;

    Console.Write("Please enter the value: ");
    iValue = Convert.ToInt32(Console.ReadLine());

    // Using jaggedArray for flexible array/ dimensional array with varying lengths
    int[][] jaggedArray = new int[iValue + 1][];
    for (int i = 0; i <= iValue; i++)
    {
        jaggedArray[i] = new int[i + 1];
    }

    // Filling the pascal's triangle with values
    for(int i = 0; i <= iValue; i++)
    {
        for(int w = 0; w <= i; w++)
        {
            if(w == 0 || w == i)
            {
                jaggedArray[i][w] = 1;
            } else
            {
                jaggedArray[i][w] = jaggedArray[i - 1][w - 1] + jaggedArray[i - 1][w];
            }
        }
    }

    // Print the triangle
    for(int i = 0; i <= iValue; i++)
    {
        for(int w = 0; w <= i; w++)
        {
            Console.Write("[{0}] ", jaggedArray[i][w]);
        }
        Console.Write("\n");
    }
}

