// Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler

using System;
using System.Collections.Generic;


 class HelloWorld
{
     static void Main(string[] args)
    {
        Dictionary <int,string> Names=new Dictionary <int,string>();
        Names.Add(1,"BC");
        Names.Add(2,"ON");
        Names.Add(3,"MA");
        Names.Add(4,"AB");
    
        foreach(var name in  Names.Values)
        {
            Console.WriteLine(name);
        }
    }
}

