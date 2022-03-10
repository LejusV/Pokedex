using Pokedex.Enums;
using Pokedex.Models;
using Pokedex.Models.Pokemons;
using Pokedex.Models.Players;
using System;
using System.IO;
using System.Collections.Generic;
using System.Globalization;
using Pokedex.Models.Moves;

    

namespace Pokedex
{
    
    class Program
    {
        public static Random Random = new Random();
        static void Main()
        {
            FileStream ostrm;
            StreamWriter writer;
            TextWriter oldOut = Console.Out;
            try
            {
                ostrm = new FileStream ("./Data/Output.txt", FileMode.Create, FileAccess.Write);
                writer = new StreamWriter (ostrm);
            }
            catch (Exception e)
            {
                Console.WriteLine ("Cannot open Redirect.txt for writing");
                Console.WriteLine (e.Message);
                return;
            }
            Console.SetOut (writer);



            int lineIndex = 0;
            List<string> inputLines = new List<string>();
            foreach (string line in File.ReadLines("Data\\Input.txt")) inputLines.Add(line);


            Console.Write("Choose you gender (F, M or O) : ");

            Console.WriteLine(inputLines[lineIndex]);
            string g = inputLines[lineIndex++];
            Gender gender = (Gender)Enum.Parse(typeof(Gender), g);


            Console.Write("Choose your Trainer name : ");
            
            Console.WriteLine(inputLines[lineIndex]);
            Player Player1 = new(inputLines[lineIndex++], gender);


            Console.WriteLine("What PokemonInstance do you want to start with ?\n" +
                                "\t- Bulbasaur\n" +
                                "\t- Charmander\n" +
                                "\t- Squirtle\n");

            Console.WriteLine(inputLines[lineIndex]);

            Move moveWaterShuriken = new MoveWaterShuriken();
            Move moveTackle = new MoveTackle();

            switch (
                new CultureInfo("en")
                .TextInfo
                .ToTitleCase(
                    inputLines[lineIndex++]
                    .ToLower()
                ))
            {
                case "Bulbasaur" :
                {
                    Player1.AddPokemon(new BulbasaurInstance( 50 ));
                    break;
                }

                case "Charmander" :
                {
                    Player1.AddPokemon(new CharmanderInstance( 50 ));
                    break;
                }

                case "Squirtle" :
                {
                    Player1.AddPokemon(new SquirtleInstance( 50 ));
                    Player1.Pokemons[0].LearnMove(moveWaterShuriken);
                    Player1.Pokemons[0].LearnMove(moveTackle);
                    break;
                }
            }


            Console.Write("\n" +
                "How should it be called ? ");
            
            Console.WriteLine(inputLines[lineIndex]);
            Player1.Pokemons[0].Nickname = inputLines[lineIndex++];


            foreach (PokemonInstance poke in Player1.Pokemons)
            {
                Console.WriteLine(poke.FullStatus);
                Console.WriteLine(poke.Status);
            }

            Console.WriteLine(moveWaterShuriken.FullStatus);
            Console.WriteLine(moveTackle.FullStatus);

            //Console.WriteLine(Wiki.Instance.ToString());
            PlayerAI.Instance.Pokemons = new List<PokemonInstance>(){new MrRimeInstance(Player1.Pokemons[0].Level)};

            Battle battle = new Battle(
                Player1,
                PlayerAI.Instance
            );

            //Console.WriteLine("hp: " + Player1.Pokemons[0].IV.Get("hp"));
            //Console.WriteLine("attack: " + Player1.Pokemons[0].IV.Get("attack"));
            //Console.WriteLine("defense: " + Player1.Pokemons[0].IV.Get("defense"));
            //Console.WriteLine("sp_attack: " + Player1.Pokemons[0].IV.Get("sp_attack"));
            //Console.WriteLine("sp_defense: " + Player1.Pokemons[0].IV.Get("sp_defense"));
            //Console.WriteLine("speed: " + Player1.Pokemons[0].IV.Get("speed"));
            //Console.WriteLine(Player1.Pokemons[0].StatsString);
            
            Console.SetOut (oldOut);
            writer.Close();
            ostrm.Close();
            Console.WriteLine ($"{PokemonInstance.InstanceCount} Pokemons generated");
            Console.WriteLine ("Done");
        }
    }
}