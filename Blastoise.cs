using System;
using System.Collections.Generic;
using System.Text;

namespace MyPokemon
{
    class Blastoise : PokemonDescription
    {
        static int MaxAge = 20;
        static Random R = new Random();
        public string PokemonName;

        public Blastoise (string Name, string Move)
        {
            this.PokemonName = Name;
            this.PokemonAge = R.Next(MaxAge);
            this.PokemonColor = "Blue";
            this.PokemonType = "Water type";
            this.PokemonMoves = Move;
        }
        public void Swim()
        {
            Console.WriteLine("I can swim!");
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
