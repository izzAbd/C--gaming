using System;

namespace task3{

public class Program
{
    public static void Main(string[] args)
    {
       Console.WriteLine("Enter number: ");
       int number = int.Parse(Console.ReadLine());
       if (number==0){
           Console.WriteLine("number is zero");
       }
       else if(number<0){
           Console.WriteLine("number is negative");

       }
       else{
           Console.WriteLine("number is positive");

       }
    }
}
}