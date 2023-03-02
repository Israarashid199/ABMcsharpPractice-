// Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler

using System;
using System.Linq;
public class HelloWorld
{
    public static void Main(string[] args)
    {
     //Console.WriteLine ("Hello Mono World");
     int[] evenNumber1 = { 1,2,3,4,5,6,7,8,9,10 };
    int[] OldNumber2 = { 1,2,3,4,5,6,7,8,9};
     FindNumber(evenNumber1);
     FindNumber(OldNumber2);
    }
        public static void FindNumber(int[] array)
        {
            int  arrayLength= array.Length;
            int mid= array.Length/2;
            
            if(arrayLength %2 ==0)
            {
                Console.WriteLine("mid is1:" + array[mid]);
            }
            else 
            {
                 Console.WriteLine("mid is2:" + array[mid]);
            }
        }

}