using System;

namespace task7{
public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter password: ");
        string password = Console.ReadLine();
        bool isTrue = true;
        while(isTrue){
            Console.WriteLine("Enter password again: ");
            string parol = Console.ReadLine();    
            if(parol==password){
                isTrue = false;
            }   
        }  
       }
    }
}
