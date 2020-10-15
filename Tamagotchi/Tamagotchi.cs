using System;

namespace Tamagochi
{
    public class Tamagotchi
    {
        int Hunger = 0;
        int Boredome = 0;
        public List<string> words = new List<string>();
        bool isAlive = true;
        static Random generator = new Random();
        public string Name = "----";

        public bool GetAlive ()
        {
            if (isAlive = true)
            {
                Console.WriteLine(first.Name + " is alive ^3^");
            }
            else
            {
                Console.WriteLine("Oh no! it's funeral time..."
                + " Or you could restart the game by exiting and entering again"); 
            }
        }

        public void Feed()
        {
            Hunger--;
        }

        public void Hi()
        { 
            
            ReduceBoredom;
        }

        public void Teach(string word)
        {
            words.Add(word); 
            ReduceBoredom;
        }

        public void Tick()
        {
            Hunger ++; 
            Boredome ++;
            if (Hunger>10 || Boredome>10)
            {
                isAlive = false; 
            }
        }

        public void PrintStats()
        { 
            Console.WriteLine(GetAlive + first.Hunger + first.Boredome);
        }
        static void ReduceBoredom()
        { 
            Boredome --; 
        }

    }
}
