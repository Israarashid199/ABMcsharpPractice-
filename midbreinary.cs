// Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler

using System;
using System.Linq;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        //Console.WriteLine ("Hello Mono World");
  int[] value = { 1, 2, 3,4,5,6,7,8,9,10 };
  int Searcnumber = 5;

int midElement = value.Length / 2;
  Console.WriteLine(midElement +" ");
  
Console.WriteLine("Numbers from the middle:");
for (int g = midElement; g < (value.Length); g++)
{
    Console.WriteLine(value[g]);
}
var lessNumbers = value.Where(n => f < Searcnumber);

Console.WriteLine("search Number " + Searcnumber + ":");
foreach (int f in lessNumbers)
{
    Console.WriteLine(f);
}

    }
}