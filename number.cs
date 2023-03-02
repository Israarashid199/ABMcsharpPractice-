// Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler

using System;
using System.Linq;

public class HelloWorld
{
    public static void Main(string[] args)
    {
       // Console.WriteLine ("Hello Mono World");
       
         int[] oldArray = {1,2, 3,2,3,4,3};
    int[] DupArray = oldArray.Distinct().ToArray();

    String Is = "";
    for (int f = 0; f < DupArray.Length; f++)
    {
        Is += DupArray[f] +",";
    }
    Console.WriteLine(Is + " ");
    }
}