using System;

namespace Tamagochi
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello and welcome the the world of tamagotchi!");
            Console.WriteLine("First of all, what do you want to call your new pet?");
            Tamagotchi.Name= Console.ReadLine(); 
        }
    }
}
