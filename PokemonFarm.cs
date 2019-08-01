using System;

namespace MyPokemon
{
    class PokemonFarm
    {
        static Charizard[] Chari = new Charizard[4];
        static void CreateNewCharizard()
        {
            Chari[0] = new Charizard("Drago", "Flamethrower");
            Chari[1] = new Charizard("Fred", "Flare Blitz");
            Chari[2] = new Charizard("Pablo", "Fire Fang");
            Chari[3] = new Charizard("Milo", "Overheat");
        }
        static void VisitCharizards()
        {
            for (int i = 0; i < Chari.Length; i++)
            {
                Console.WriteLine($"\nMy Charizard's name is {Chari[i].PokemonName} and he is {Chari[i].PokemonAge} years old. He is {Chari[i].PokemonColor} and" +
                $" is a {Chari[i].PokemonType}. His favorite move is {Chari[i].PokemonMoves}.");
                if (i == 0)
                {
                    Chari[i].Fly();
                }
                else if (i == 1)
                {
                    Chari[i].Yawn();
                }
                else if (i == 2)
                {
                    Chari[i].Hungry();
                }
                else
                {
                    Chari[3].Greet();
                }
            }
        }
        static Blastoise[] Blasti = new Blastoise[4];
        static void CreateNewBlastoise()
        {
            Blasti[0] = new Blastoise("Teddy", "Bubble");
            Blasti[1] = new Blastoise("Carl", "Water Gun");
            Blasti[2] = new Blastoise("Kevin", "Hydro Pump");
            Blasti[3] = new Blastoise("Sam", "Water Pulse");
        }
        static void VisitBlastoise()
        {
            for (int i = 0; i < Blasti.Length; i++)
            {
                Console.WriteLine($"\nMy Blastoise's name is {Blasti[i].PokemonName} and he is {Blasti[i].PokemonAge} years old. He is {Blasti[i].PokemonColor} and" +
                $" is a {Blasti[i].PokemonType}. His favorite move is {Blasti[i].PokemonMoves}.");
                if (i == 0)
                {
                    Blasti[i].Swim();
                }
                else if (i == 1)
                {
                    Blasti[i].Yawn();
                }
                else if (i == 2)
                {
                    Blasti[i].Hungry();
                }
                else
                {
                    Blasti[3].Greet();
                }
            }
        }
        static Pikachu[] Pika = new Pikachu[4];
        static void CreateNewPikachu()
        {
            Pika[0] = new Pikachu("Shawn", "Thunderbolt");
            Pika[1] = new Pikachu("Stev", "Volt Tackle");
            Pika[2] = new Pikachu("Dustin", "Thunder Shock");
            Pika[3] = new Pikachu("Calvin", "Thunder");
        }
        static void VisitPikachu()
        {
            for (int i = 0; i < Pika.Length; i++)
            {
                Console.WriteLine($"\nMy Pikachu's name is {Pika[i].PokemonName} and he is {Pika[i].PokemonAge} years old. He is {Pika[i].PokemonColor} and" +
                $" is a {Pika[i].PokemonType}. His favorite move is {Pika[i].PokemonMoves}.");
                if (i == 0)
                {
                    Pika[i].Run();
                }
                else if (i == 1)
                {
                    Pika[i].Yawn();
                }
                else if (i == 2)
                {
                    Pika[i].Hungry();
                }
                else
                {
                    Pika[3].Greet();
                }
            }
        }
        static Venusaur[] Vena = new Venusaur[4];
        static void CreateNewVenusaur()
        {
            Vena[0] = new Venusaur("Chris", "Solar Beam");
            Vena[1] = new Venusaur("Paul", "Leaf Blade");
            Vena[2] = new Venusaur("Jerry", "Leaf Storm");
            Vena[3] = new Venusaur("Alvin", "Razor Whip");
        }
        static void VisitVenusaur()
        {
            for (int i = 0; i < Vena.Length; i++)
            {
                Console.WriteLine($"\nMy Venusaur's name is {Vena[i].PokemonName} and he is {Vena[i].PokemonAge} years old. He is {Vena[i].PokemonColor} and" +
                $" is a {Vena[i].PokemonType}. His favorite move is {Vena[i].PokemonMoves}.");
                if (i == 0)
                {
                    Vena[i].Jump();
                }
                else if (i == 1)
                {
                    Vena[i].Yawn();
                }
                else if (i == 2)
                {
                    Vena[i].Hungry();
                }
                else
                {
                    Vena[3].Greet();
                }
            }
        }
        public static void Main(string[] args)
        {
            Console.WriteLine("MyPokemon.PokemonFarm.Main()");

            CreateNewCharizard();
            VisitCharizards();

            CreateNewBlastoise();
            VisitBlastoise();

            CreateNewPikachu();
            VisitPikachu();

            CreateNewVenusaur();
            VisitVenusaur();
        }
    }
}
