// Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler

using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
       // Console.WriteLine ("Hello Mono World");
    
        string[] firstName= {"Israa","Waled","Johan","Kelsey"};
        string[] lastName={"Rashid","Waled","Johan","Kennedy"};
        for (int i=0;i<firstName.Length; i++)
        {
            Console.WriteLine(firstName[i]+" "+lastName[i]);
        }
    }
    
}