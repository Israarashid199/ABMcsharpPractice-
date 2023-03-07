// Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler

using System;
using System.Collections.Generic;


 class HelloWorld
{
     static void Main(string[] args)
    {
        List<string> Names=new List <string>();
        Names.Add("Israa,f,Ottawa");
        Names.Add("Rakesh,m,Windsor");
        Names.Add("Waleed,m,Toronto");
        Names.Add("Kelsy,f,Minatoba");
    
        foreach(var name in  Names)
        {
           
            Console.WriteLine(name);
            
        }
    }
}

