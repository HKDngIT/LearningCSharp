// See https://aka.ms/new-console-template for more information
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

/* This function is just used to run the exercises
 */
execute();
void execute()
{
    //exercise1();
    //exercise2();
    exercise3();
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
    int iAS;
    Console.Write("Arraysize: ");
    iAS = Convert.ToInt32(Console.ReadLine());
    int[,] array2D = new int[iAS, iAS];
    for(int i = 0; i < iAS; i++)
    {
        for(int y = 0;  y < iAS; y++)
        {
            array2D[i, y] = i + y;
        }
    }

    for(int i = 0; i < iAS; i++)
    {
        for(int y = 0; y < iAS; y++)
        {
            Console.Write("[{0}]", array2D[i, y]);
        }
        Console.WriteLine("\n");
    }
}