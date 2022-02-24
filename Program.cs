using Pokedex.Enums;
using Pokedex.Models;
using Pokedex.Models.Pokemons;
using System;
using System.IO;
using System.Collections.Generic;
using System.Globalization;

namespace Pokedex
{
    class Program
    {
        static void Main()
        {
            int lineIndex = 0;
            List<string> inputLines = new List<string>();
            foreach (string line in File.ReadLines("Data\\Input.txt")) inputLines.Add(line);
            Console.Write("Choose you gender (F, M or O) : ");
            Console.WriteLine(inputLines[lineIndex]);
            string g = inputLines[lineIndex++];
            Gender gender = (Gender)Enum.Parse(typeof(Gender), g);
            Console.Write("Choose your Trainer name : ");
            
            Console.WriteLine(inputLines[lineIndex]);
            Trainer Player1 = new(inputLines[lineIndex++], gender);

            Console.WriteLine("What Pokemon do you want to start with :\n" +
                                "\t- Bulbasaur (1)\n" +
                                "\t- Charmander (4)\n" +
                                "\t- Squirtle (7)\n");

            Console.WriteLine(inputLines[lineIndex]);
            switch (new CultureInfo("en").TextInfo.ToTitleCase(inputLines[lineIndex++].ToLower()))
            {
                case "Bulbasaur" :
                {
                    Pokemon bulbasaur = new Bulbasaur("Bulbasaur", 10);
                    Player1.AddPokemon(bulbasaur);
                    break;
                }

                case "Charmander" :
                {
                    Pokemon charmander = new Charmander("Charmander", 10);
                    Player1.AddPokemon(charmander);
                    break;
                }

                case "Squirtle" :
                {
                    Pokemon squirtle = new Squirtle("Squirtle", 10);
                    Player1.AddPokemon(squirtle);
                    break;
                }
            }
            Console.Write("\n" +
                "How should it be called ? ");
            
            Console.WriteLine(inputLines[lineIndex]);
            Player1.Pokemons[0].Rename = inputLines[lineIndex++];

            foreach (Pokemon poke in Player1.Pokemons)
            {
                Console.WriteLine(poke.ToString() + poke.StatsString + poke.MovesDisplay());
            }

            //Console.WriteLine(Wiki.Instance.Display());
            
            Battle battle = new Battle(
                Player1,
                new List<Pokemon>()
                { 
                    new Metapod(Player1.Pokemons[0].Level)
                }
            );

        }
    }
}