using System;

namespace MyApplication
{
  class Program
  {
    static void Main(string[] args)
    {
      int start = 2;
     
      do 
      {
        Console.WriteLine(start);
        start+=2;
      }
      while (start <= 100);
    }
  }
}