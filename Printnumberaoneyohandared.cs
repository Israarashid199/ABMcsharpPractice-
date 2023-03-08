// Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler

using System;
using System.Collections;
using System.Linq;
public class HelloWorld
{
  public static void Main(string[] args)
    {
        numberloop();
    }
    public static void numberloop()
    {
       int[] numbers = Enumerable.Range(1, 100).ToArray();

for (int i = 0; i < 10; i++)
{
    for (int j = 0; j < 10; j++)
    {
        int index = i * 10 + j;
        Console.Write("{0,3}", numbers[index]);
    }
    Console.WriteLine();
}
    }
}