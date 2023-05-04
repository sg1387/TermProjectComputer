using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {   
        Console.WriteLine("esm be englisi");
        Console.Write("Enter: ");
        int num=0;
        num = int.Parse(Console.ReadLine());
        if(num%2==0){
            Console.WriteLine(num*4);
        }
        else
        {
            Console.WriteLine(num*3-1);
        }
    }
}