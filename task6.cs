using System;

namespace task6{

public class program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter number: ");
        int number = int.Parse(Console.ReadLine());
       for(int i=1;i<=10;i++){
          
            Console.WriteLine($"{number} * {i} = {number * i}");
           
       }
    }
}
}