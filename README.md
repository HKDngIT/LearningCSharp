# Content
This Repository currently contains files for the following projects in C#

# Exercises in C# using Console
## Dynamic memory [link to source code](https://github.com/HKDngIT/LearningCSharp/blob/main/CSharpExercises/dynamicMemory/dynamicMemory/Program.cs)
- [x] Copy of an array with doubled array elements
- [x] Summarizing two arrays
- [x] 2-Dimensional arrays - DOUBLE POINTERS NOT POSSIBLE IN C# IMPLEMENTATION NON DYNAMIC
- [x] 2-Dimensional arrays with initial values - DOUBLE POINTERS NOT POSSIBLE IN C# IMPLEMENTATION NON DYNAMIC
- [x] Pascal's Triangle - DOUBLE POINTERS NOT POSSIBLE IN C# IMPLEMENTATION WITH JAGGED ARRAYS
- [x] 3-Dimensional arrays

## Strings and File Access 
- [x] Simple Minicalculator [link to source code](https://github.com/HKDngIT/LearningCSharp/blob/main/CSharpExercises/StringsAndFileAccess/ConsoleApp1/Program.cs)
- [ ] .txt file copy [link to source code](https://github.com/HKDngIT/LearningCSharp/blob/main/CSharpExercises/StringsAndFileAccess/txtFileCopy/Program.cs)
- [ ] Greeting Assignment with Name List
- [ ] Writing and Reading Binary Files
- [ ] Simple handling with binary files and arrays

# Simple programs using Windows Forms
## A calculator
![Calculator](./Images/Calc_SS.jpg)  
- Basic arithmetic operations
- Some special operations like "inverse"

## A memory game
![Memory](./Images/Memory_SS.jpg)  
- Timer feature which starts when the start button is pressed and stops when all pairs have been found
- Counts the tries until all pairs have been found

# Programs with a touch of electrical science
## Program for Star-Delta-Transformation calculation
![StarDeltaCalculator](/Images/StarDeltaCalculator.jpg)  
- with error handling for invalid inputs
- invalid inputs are:
  - empty textboxes
  - the use of non digits
  - zero or negative values for the resistors
- in case of an error, a message box will show up with further detailed information

## Impedance Calculator
![ImpCalc](/Images/ImpedanceCalculator.png)
- [Wikipedia article about impedances](https://en.wikipedia.org/wiki/Electrical_impedance)
- Handles impedances when adding serial and parallel ideal components correctly
- Displays impedances in cartesian form and polar form
- Frequency can be freely adjusted
- For ease to input values, toggle buttons for unit prefix can be used (kilo, milli, mikro µ and nano)
- Uses the 'Complex Struct' to calculate with complex numbers/ values of the components - see here:  
  https://learn.microsoft.com/en-us/dotnet/api/system.numerics.complex?view=net-8.0

### Validation/ Verification of Impedance Calculator
- To verify the correct program behavior I used an old exercise


![impedance](/Images/01Imp.jpg)
![impedance](/Images/02Imp.jpg)    
- Due to the structure of the program I have to start from the outermost components - the two capacitors and resistor.
- The nano toggle button for the capacitor and kilo toggle button for the resistor are working as intended
- After further input of the inductor and last resistor the program is in the state of the UI screenshot as shown further above
- The right values can be validated with the solutions below
- [Video which shows the program in action](https://drive.google.com/file/d/13HRK1U6Viz_Pkg_ShcqiDvh-22s1TW7p/view?usp=sharing)

  
![impedance](/Images/03Imp.jpg)
![impedance](/Images/04Imp.jpg)
![impedance](/Images/05Imp.jpg)

# Programs for math problems
## Matrice operations
![Matrices](/Images/Matrices.jpg)
- error handling for invalid inputs(same as in the Star-Delta-Calculator)
- basic matrice operations
- can calculate determinant of a 3x3 matrix using the *Rule of Sarrus* https://en.wikipedia.org/wiki/Rule_of_Sarrus
- can calculate inverse of a 3x3 matrix using the adjunct transposed matrix and the determinant
- in case of no determinante/ 0-determinante an error window will pop up because no inverse exists
