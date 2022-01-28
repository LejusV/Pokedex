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
            List<Pokemon> pokemons = new List<Pokemon>
            {
                new Pikachu("Pikatchum", 17),
                new Charizard("Dracofeu", 49),
                new Bulbasaur("Bulbizarre", 12),
                new Blastoise("Tortank", 666),
                new Meowth("Miaouss", 1),
                new Charmander("Salamèche", 42),
                new MrMime("M. Mime", 2),
                new Geodude("Racaillou", 999)
            };

            foreach(Pokemon poke in pokemons)
                poke.Display();
        }
    }
}
