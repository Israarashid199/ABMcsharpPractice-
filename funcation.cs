// Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler

using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        //Console.WriteLine ("Hello Mono World");
     string myString = "Hello World!";
        int myInt = 10;
        double myDouble = 3.14;
        char myChar = 'A';
        bool myBool = true;

        Console.WriteLine("My string is: " + MyStringFunction(myString));
        Console.WriteLine("My int is: " + MyIntFunction(myInt));
        Console.WriteLine("My double is: " + MyDoubleFunction(myDouble));
        Console.WriteLine("My char is: " + MyCharFunction(myChar));
        Console.WriteLine("My bool is: " + MyBoolFunction(myBool));
    }

    static string MyStringFunction(string inputString)
    {
        // do something with inputString
        return inputString.ToUpper();
    }

    static int MyIntFunction(int inputInt)
    {
        // do something with inputInt
        return inputInt * 2;
    }

    static double MyDoubleFunction(double inputDouble)
    {
        // do something with inputDouble
        return inputDouble / 2;
    }

    static char MyCharFunction(char inputChar)
    {
        // do something with inputChar
        return (char)(inputChar);
    }

    static bool MyBoolFunction(bool inputBool)
    {
        // do something with inputBool
        return !inputBool;
    }
}
