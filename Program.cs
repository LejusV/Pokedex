using Pokedex.Enums;
using Pokedex.Models;
using Pokedex.Models.Pokemons;
using Pokedex.Models.Moves.Categories;
using System;
using System.Collections.Generic;

namespace Pokedex
{
    class Program
    {
        static void Main()
        {
            Console.Write("Choose you gender (F, M or O) : ");
            string g = Console.ReadLine();
            Gender gender = (Gender)Enum.Parse(typeof(Gender), g);
            Console.Write("Choose your Trainer name : ");

            Trainer Player1 = new(Console.ReadLine(), gender);

            Console.WriteLine("What Pokemon do you want to start with :\n" +
                                "\t- Bulbasaur (1)\n" +
                                "\t- Charmander (4)\n" +
                                "\t- Squirtle (7)\n");

            if (int.TryParse(Console.ReadLine(), out int answer))
            {
                switch (answer)
                {
                    case 1 :
                    {
                        Pokemon bulbasaur = new Bulbasaur("Bulbasaur", 10);
                        bulbasaur.ResetActualStats();
                        Player1.AddPokemon(bulbasaur);
                        break;
                    }

                    case 4 :
                    {
                        Pokemon charmander = new Charmander("Charmander", 10);
                        charmander.ResetActualStats();
                        Player1.AddPokemon(charmander);
                        break;
                    }

                    case 7 :
                    {
                        Pokemon squirtle = new Squirtle("Squirtle", 10);
                        squirtle.ResetActualStats();
                        Player1.AddPokemon(squirtle);
                        break;
                    }
                }
            }
            Console.Write("\n" +
                "How should it be called ? ");

            Player1.Pokemons[0].Rename = Console.ReadLine();

            foreach (Pokemon poke in Player1.Pokemons)
            {
                Console.WriteLine(poke.ToString() + poke.MovesDisplay());
            }

            //Console.WriteLine(Wiki.Instance.Display());
            Battle battle = new Battle(Player1, new List<Pokemon>() { new Metapod("Metapod", 10) });


        }
    }
}