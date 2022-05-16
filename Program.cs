using Pokedex.Enums;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Instances;
using Pokedex.Models.Players;
using System;
using System.IO;
using System.Collections.Generic;
using System.Globalization;
using Pokedex.Models.Moves;

    

namespace Pokedex
{
    
    public class Input
    {
        public static List<string> InputLines = new List<string>();
        public static int LineIndex = 0;
    }
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

            foreach (string line in File.ReadLines("Data\\Input.txt")) Input.InputLines.Add(line);


            Console.Write("Choose you gender (F, M or O) : ");

            Console.WriteLine(Input.InputLines[Input.LineIndex]);
            string g = Input.InputLines[Input.LineIndex++];
            Gender gender = (Gender)Enum.Parse(typeof(Gender), g);


            Console.Write("Choose your Trainer name : ");
            
            Console.WriteLine(Input.InputLines[Input.LineIndex]);
            Player Player1 = new(Input.InputLines[Input.LineIndex++], gender);


            Console.WriteLine("What PokemonInstance do you want to start with ?\n" +
                                "\t- Bulbasaur\n" +
                                "\t- Charmander\n" +
                                "\t- Squirtle\n");

            Console.WriteLine(Input.InputLines[Input.LineIndex]);

            switch (
                new CultureInfo("en")
                .TextInfo
                .ToTitleCase(
                    Input.InputLines[Input.LineIndex++]
                    .ToLower()
                ))
            {
                case "Bulbasaur" :
                {
                    Player1.AdoptPokemon(new Bulbasaur( 50 ));
                    break;
                }

                case "Charmander" :
                {
                    Player1.AdoptPokemon(new Charmander( 50 ));
                    break;
                }

                case "Squirtle" :
                {
                    Player1.AdoptPokemon(new Squirtle( 50 ));

                    break;
                }
            }


            MoveInstance moveWaterShuriken = new IWaterShuriken(Player1.DefaultPokemon!);
            MoveInstance moveAvalanche = new IAvalanche(Player1.DefaultPokemon!);

            Console.Write("\n" +
                "How should it be called ? ");
            
            Console.WriteLine(Input.InputLines[Input.LineIndex]);
            Player1.DefaultPokemon!.Nickname = Input.InputLines[Input.LineIndex++];


            foreach (PokemonInstance? poke in Player1.Pokemons)
            {
                if (poke != null)
                {
                    poke.LearnMove(new IMegaPunch(poke), 0);
                    poke.LearnMove(new ITackle(poke), 1);
                    Console.WriteLine(poke.FullStatus);
                    Console.WriteLine(poke.Status);
                }
            }

            Console.WriteLine(Player1.DefaultPokemon.Moves[0]!.FullStatus);
            Console.WriteLine(Player1.DefaultPokemon.Moves[1]!.FullStatus);

            //Console.WriteLine(Wiki.Instance.ToString());
            PlayerAI.Instance.AdoptPokemon(new MrMime(Player1.DefaultPokemon!.Level), 0);
            PlayerAI.Instance.DefaultPokemon!.LearnMove(new IPound(PlayerAI.Instance.DefaultPokemon));

            if (Player1.PokemonsCount > 0
                && PlayerAI.Instance.PokemonsCount > 0)
            {
                Battle battle = new Battle(
                    Player1,
                    PlayerAI.Instance
                );
            }
            
            Console.SetOut (oldOut);
            writer.Close();
            ostrm.Close();
            Console.WriteLine ($"{PokemonInstance.InstanceCount} Pokemons generated");
            Console.WriteLine ("Done");
        }
    }
}