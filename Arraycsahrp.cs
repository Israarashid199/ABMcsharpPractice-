using System;
using System.Collections.Generic;

public class HelloWorld
{
    public static void Main(string[] args)
    {
       // Console.WriteLine ("Hello Mono World");
       
       var Students  = new List<string>();
      Students.Add("Ahmed");
      Students.Add("Reem");
      Students.Add("Noor");
      Students.Add("Safa");
      
    
      
      
          for (int i=0;i<Students .Count;i++)
       {
           if (Students [i]=="Ahmed")
           {
              Students  [i]="Hajer";
           }
           foreach (var student in Students  )
           {
               Console.WriteLine(student );
           }
       }
    }
}