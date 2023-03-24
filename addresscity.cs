// Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler

using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        //Console.WriteLine ("Hello Mono World");
        fncAddress2("2273 Mckay Ave, Windsor, ON, N9B 3W6 ,Canada");
    }
        public static void fncAddress2(string address){
            string [] addressHome= address.Split(",");
            Console.WriteLine("Home number:"+addressHome[0]+
            "\n"+"City:"+addressHome[1]+
            "\n"+"Province:"+addressHome[2]+
            "\n"+"Country:"+addressHome[3]);
        }

}