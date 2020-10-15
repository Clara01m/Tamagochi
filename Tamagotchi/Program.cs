using System;

namespace Tamagochi
{
    class Program
    {
        static void Main(string[] args)
        {
            Tamagotchi first = new Tamagotchi(); 

            Console.WriteLine("Hello and welcome the the world of tamagotchi!");
            Console.WriteLine("First of all, what do you want to call your new pet?");
            first.Name= Console.ReadLine(); 
            Console.WriteLine("So" + first.Name + "? Great choice!");

            
            
        }
    }
}
