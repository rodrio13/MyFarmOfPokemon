using System;
using System.Collections.Generic;
using System.Text;

namespace MyPokemon
{
    class Pikachu : PokemonDescription
    {
        static int MaxAge = 20;
        static Random R = new Random();
        public string PokemonName;

        public Pikachu (string Name, string Move)
        {
            this.PokemonName = Name;
            this.PokemonAge = R.Next(MaxAge);
            this.PokemonColor = "Yellow";
            this.PokemonType = "Electric type";
            this.PokemonMoves = Move;
        }
        public void Run()
        {
            Console.WriteLine("I can run fast!");
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
