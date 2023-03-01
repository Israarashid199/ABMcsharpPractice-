using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        //Console.WriteLine ("Hello Mono World");
        var radius= 10;
        var area = CircleArea(radius);
        
        Console.WriteLine ("The area circle:" +area);

        calcCircumference(radius);
    }
    public static double CircleArea (double radius){
        return Math.PI *radius *radius;
    }

    // John Code Here
    private static void calcCircumference(int radius)
    {
        double convertedRadius = Convert.ToDouble(radius);
        double pi = Math.PI;
        double area = 2 * pi * radius;
        Console.WriteLine("The Circumference (C=2πr) of your circle is: {0:F2}", area);

    }
}
    