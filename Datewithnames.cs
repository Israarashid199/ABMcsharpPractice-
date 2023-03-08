// Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler

using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
      //  Console.WriteLine ("Hello Mono World");
      string[] names = { "1.Israa", "2. Kelsey", "3. Rakesh", "4. Johan" };
     DateTime[] datesOfBirth = { new DateTime(1996, 12, 10), new DateTime(1993, 7, 23), new DateTime(1990, 5, 20), new DateTime(1988, 10, 7) };
     for (int i = 0; i < names.Length; i++)
    {
    Console.WriteLine($"Name: {names[i]}, Date of birth: {datesOfBirth[i].ToString("dd MMMM yyyy")}");
   }

    }
}