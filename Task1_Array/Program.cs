// Task is to create a string array with some quantity of array members
// and to transform it to string array with 3 or less members.

//Base array length:
int ArrayLength(string userMsg)
{
    Console.WriteLine(userMsg);
    return int.Parse(Console.ReadLine());
}

//Base array members from user:
string ArrayMembers(string userMsg)
{
    Console.WriteLine(userMsg);
    return Console.ReadLine();
}

//Creating array of user entered length and filling it with user entered array members
string[] CreateArray(int arrayLength)
{
    arrayLength = ArrayLength("Enter the length of array");
    string[] baseArray = new string[arrayLength];
    for (int i = 0; i < arrayLength; i++)
    {
        baseArray[i] = ArrayMembers($"Enter array [{i}] of the {i + 1} memeber of array");
    }
    Console.WriteLine("The string array initially contains the following values:");
    PrintIndexAndValues(baseArray);
    return baseArray;
}

//Printing method
void PrintIndexAndValues(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.WriteLine(" [{0}] : {1}", i, array[i]);
    }
    Console.WriteLine();
}

//Resizing array
void ResizeArray(string[] baseArray)
{
    int newSize = new Random().Next(1, 4);
    Console.WriteLine($"Randomly chosen (from 1 to 3) size of new array will be {newSize}");
    Console.WriteLine();
    Array.Resize(ref baseArray, newSize);
    Console.WriteLine("After resizing new array is: ");
    PrintIndexAndValues(baseArray);
}

//Executing the process
void Runner()
{
    int arrayLength = 0;
    string [] baseArray = CreateArray(arrayLength);
    ResizeArray(baseArray);
}
Runner();
