using System;

namespace Tamagochi
{
    public class Tamagotchi
    {
        int Hunger = 0;
        int Boredome = 0;
        static List<string> words = new List<string>();
        bool isAlive = true;
        static Random generator = new Random();
        public string Name = "----";

        public bool GetAlive = true;

        public void Feed()
        { }
        public void Hi()
        { }
        public void Teach(string word)
        {
            words.Add(word); 

        }
        public void Tick()
        { }
        public void PrintStats()
        { }
        static void ReduceBoredom()
        { }

    }
}
