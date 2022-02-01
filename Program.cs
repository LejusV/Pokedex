using Pokedex.Enums;
using Pokedex.Models;
using Pokedex.Models.Pokemons;
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


            Pokemon[] starter_pokemons = {
                new Bulbasaur("Bulbisaur", 1),
                new Charmander("Charmander", 1),
                new Squirtle("Squirtle", 1)
            };

            /*new Meowth("Miaouss", 1),
            new MrMime("M. Mime", 1),
            new Pichu("Pika", 1),
            new Geodude("Racaillou", 1),
            new Caterpie("Chenipan", 1),*/

            Console.WriteLine("What Pokemon do you want to start with :\n" +
                                "\t- Bulbasaur (1)\n" +
                                "\t- Charmander (4)\n" +
                                "\t- Squirtle (7)\n");

            if (int.TryParse(Console.ReadLine(), out int answer))
            {
                foreach (Pokemon p in starter_pokemons)
                {
                    if (p.Id == answer) Player1.AddPokemon(p);
                }
            }
            Console.Write("\n" +
                "How should it be called ? ");

            Player1.Pokemons[0].Rename = Console.ReadLine();

            /*foreach (Pokemon poke in pokemons)
            {
                Player1.AddPokemon(poke);
            }

            foreach (Pokemon poke in Player1.Pokemons)
            {
                Console.WriteLine(poke.ToString());
            }*/

            Console.WriteLine(Wiki.Instance.Display());

        }
    }
}
