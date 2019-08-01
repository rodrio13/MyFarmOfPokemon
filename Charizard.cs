using System;
using System.Collections.Generic;
using System.Text;

namespace MyPokemon
{
    public class Charizard : PokemonDescription
    {
        static int MaxAge = 20;
        static Random R = new Random();
        public string PokemonName;

        public Charizard(string Name, string Move)
        {
            this.PokemonName = Name;
            this.PokemonAge = R.Next(MaxAge);
            this.PokemonColor = "Red";
            this.PokemonType = "Fire type";
            this.PokemonMoves = Move;
        }
        public void Fly()
        {
            Console.WriteLine("I can fly!");
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
