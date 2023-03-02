// Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler
using System;
using System.Linq;
public class HelloWorld
{
    public static void Main(string[] args)
    {
        //Console.WriteLine ("Hello Mono World");
        string sentence="My Name is Basant Gera";
        ReverseAstring(sentence);
    }
    public static void ReverseAstring(string sentence){
           var reversedWords = string.Join(" ",
      sentence.Split(' ')
         .Select(x => new String(x.Reverse().ToArray()))
         .ToArray());
         Console.WriteLine (reversedWords);
    }
}