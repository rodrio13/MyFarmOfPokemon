using System;
using System.Collections.Generic;
using System.Text;

namespace MyPokemon
{
    class Venusaur : PokemonDescription
    {
        static int MaxAge = 20;
        static Random R = new Random();
        public string PokemonName;

        public Venusaur (string Name, string Move)
        {
            this.PokemonName = Name;
            this.PokemonAge = R.Next(MaxAge);
            this.PokemonColor = "Green";
            this.PokemonType = "Grass type";
            this.PokemonMoves = Move;
        }
        public void Jump()
        {
            Console.WriteLine("I can jump!");
        }
        public void Yawn()
        {
            Console.WriteLine("I'm sleepy...");
        }
        public void Hungry()
        {
            Console.WriteLine("FEED ME!");
        }
        public void Greet()
        {
            Console.WriteLine("Hey! Nice to meet you!");
        }
    }
}
