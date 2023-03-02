// Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler

using System;
using System.Linq;
public class HelloWorld
{
    public static void Main(string[] args)
    {
       // Console.WriteLine ("Hello Mono World");
      int[] myArray = { 1, 2, 3, 4, 5, 6, 7, 8, 9,10,10};

// Mean
double sum = 0;
for (int i = 0; i < myArray.Length; i++)
{
    sum += myArray[i];
}
double mean = sum / myArray.Length;

Console.WriteLine("Mean: " + mean);

// Median
Array.Sort(myArray);
int middleIndex = myArray.Length / 2;
double median;
if (myArray.Length % 2 == 0)
{
    median = (myArray[middleIndex - 1] + myArray[middleIndex]) / 2.0;
}
else
{
    median = myArray[middleIndex];
}
Console.WriteLine("Median: " + median);

// Mode
int mode = myArray.GroupBy(v => v).OrderByDescending(g => g.Count()).First().Key;
Console.WriteLine("Mode: " + mode);
    }
}