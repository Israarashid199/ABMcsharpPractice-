using System;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        int[] array1 = { 1, 2, 3,4,5,6,7,8,9,10 };
        int[] array2 = { 20,30,40,50,60,70,80,90,10 };
        int[] JoinTwoArray = array1.Concat(array2).ToArray();

        Console.WriteLine("JoinTwoArray:");
        foreach (int f in JoinTwoArray)
        {
            Console.Write(f + " ");
        }
    }
}