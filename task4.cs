using System;

namespace task4{

public class program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter your age: ");
        int age = int.Parse(Console.ReadLine());
        if(age<18){
            Console.WriteLine("Sorry, you must be 18 years old");
        }
        else{
            Console.WriteLine("You can vote.");
        }
    }
}
}