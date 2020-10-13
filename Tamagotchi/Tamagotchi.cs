using System;

namespace Tamagochi
{
    public class Tamagotchi
    {
        int Hunger = 0;
        int Boredome = 0; 
         static List<string> Names = new List<string>();  
        bool isAlive= true; 
        static Random generator = new Random();
        public string Name = "----";  

        public bool GetAlive = true; 


    }
    public static void Feed()
    {}
    public static void Hi() 
    {}
    public static void Teach(string word) 
    {}
    public static void Tick() 
    {}
    public static void PrintStats() 
    {}
    static void ReduceBoredom()
    {}
}
