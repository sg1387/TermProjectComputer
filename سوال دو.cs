using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {   
        Console.WriteLine("esm be englisi");
        Console.WriteLine("Enter: ");
        int num=0;
        num = int.Parse(Console.ReadLine());
        for (int i = num; i > 0; i--) 
        {
          Console.WriteLine(i);
        }
        
    }
}