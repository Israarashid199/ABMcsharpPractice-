// Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler

using System;
using System.Collections.Generic;


public class HelloWorld
{
    public static void Main(string[] args)
    {
        //Console.WriteLine ("Hello Mono World");
           string Tags = "the world is nice the world is nice ";

        string[] words = Tags.Split(' ');

        Dictionary<string, int> oddw = new Dictionary<string, int>();

        foreach (string item in words)
        {
            if (item != "")
            {
                if (oddw.ContainsKey(item) == false)
                {
                    oddw.Add(item, 1);
                }
                else
                {
                    oddw[item]++;
                }
            }
        }

        foreach (var item in oddw)
        {
            Console.WriteLine(item);
        }
    }
}