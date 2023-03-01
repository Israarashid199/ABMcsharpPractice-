using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        //Console.WriteLine ("Hello Mono World");
        var radius= 10;
        var area = CircleArea(radius);
        
        Console.WriteLine ("The area circle:" +area);
    }
    public static double CircleArea (double radius){
        return Math.PI *radius *radius;
    }
    }
    