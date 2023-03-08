// Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler

using System;
using System.Collections.Generic;
public class HelloWorld
{
    public static void Main(string[] args)
    {
        List<People> list= new  List<People>();
       People israa= new People("Israa Rashid", new DateTime(1996,12,10)); 
       People johan= new People("Johan Smith", new DateTime(1980,10,7)); 
       People kelsey= new People("Kelsey Kenndy", new DateTime(2005,6,12)); 
       People walid= new People("Walid Johan", new DateTime(2000,8,19)); 
       
       list.Add(israa);
       list.Add(johan);
       list.Add(kelsey);
       list.Add(walid);
       
       foreach(var x in list)
       {
           Console.WriteLine(x.Name+" : "+x.Dob.ToString("dd MMMM yyyy"));
       }
       
      Console.WriteLine("\n Find all 2000:");
       DateTime datelist= new DateTime(2000,01,01);
      List<People> filtered = list.FindAll(x => DateTime.Compare(x.Dob, datelist)>0);
      
      
  foreach(var x in filtered )
       {
           Console.WriteLine(x.Name+" : "+x.Dob.Year);
       }

    }
}
public class People {
    private string name;
    private  DateTime dob;
    
    public People(string name, DateTime dob)
    {
        this.name = name;
        this.dob = dob;
    }
    public string Name
    {
        get {return name;}
        set {name=value;}
    }
    public DateTime Dob
    {
        get {return dob;}
        set {dob=value;}
    }
}

