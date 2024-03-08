// See https://aka.ms/new-console-template for more information
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

/* This function is just used to run the exercises
 */
execute();
void execute()
{
    exercise1();
}

/* Exercise 1
 * Copy an Array with doubled array elements
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