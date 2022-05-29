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
            // For when it redirected my Input and Output to files Data/Input.txt and Data/Output.txt
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
            //Console.SetOut (writer);

            foreach (string line in File.ReadLines("Data\\Input.txt")) Input.InputLines.Add(line);

            /**************************************************************************************/
            /*************************************  BEGIN  ****************************************/
            /**************************************************************************************/

            Console.Write("Choose you gender (F, M or O) : ");


            string g = Console.ReadLine()!;
            Gender gender = (Gender)Enum.Parse(typeof(Gender), g);


            Console.Write("Choose your Trainer name : ");
            

            Player Player1 = new(Console.ReadLine()!, gender);


            Console.WriteLine("What PokemonInstance do you want to start with ?\n" +
                                "\t- Bulbasaur\n" +
                                "\t- Charmander\n" +
                                "\t- Squirtle\n");



            switch (
                new CultureInfo("en")
                .TextInfo
                .ToTitleCase(
                    Console.ReadLine()!
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
                    Player1.AdoptPokemon(new Squirtle( 40 ));
                    break;
                }
            }
            
            Player1.AdoptPokemon(new Arceus( 40 ));


            MoveInstance moveWaterShuriken = new IWaterShuriken(Player1.DefaultPokemon!);
            MoveInstance moveAvalanche = new IAvalanche(Player1.DefaultPokemon!);

            Console.Write("\n" +
                "How should it be called ? ");
            Player1.DefaultPokemon!.Nickname = Console.ReadLine()!;


            foreach (PokemonInstance? poke in Player1.Pokemons)
            {
                if (poke is not null)
                {
                    new IEndure(poke);
                    new IFlash(poke);
                    new IDrillPeck(poke);
                    new IMudSlap(poke);
                    new IRoost(poke);
                    new ITackle(poke);
                    new IHeadbutt(poke);
                    new IMegaPunch(poke);
                    new ICut(poke);
                    Console.WriteLine(poke.FullStatus);
                    Console.WriteLine(poke.Status);
                }
            }

            Console.WriteLine(Player1.DefaultPokemon.Moves[0]!.FullStatus);
            Console.WriteLine(Player1.DefaultPokemon.Moves[1]!.FullStatus);

            //Console.WriteLine(Wiki.Instance.ToString());
            PlayerAI.Instance.AdoptPokemon(new MrMime(Player1.DefaultPokemon!.Level), 0);
            PlayerAI.Instance.AdoptPokemon(new Arceus(Math.Abs(Player1.DefaultPokemon!.Level - 20)), 1);
            new IPound(PlayerAI.Instance.DefaultPokemon!);
            new ICut(PlayerAI.Instance.Pokemons[1]!);

            Console.WriteLine(PlayerAI.Instance.DefaultPokemon!.FullStatus);

            if (Player1.PokemonsCount > 0
                && PlayerAI.Instance.PokemonsCount > 0)
            {
                Battle battle = new Battle(
                    Player1,
                    PlayerAI.Instance
                );
            }
            
            /**************************************************************************************/
            /*************************************   END   ****************************************/
            /**************************************************************************************/
            
            Console.SetOut (oldOut);
            writer.Close();
            ostrm.Close();
            Console.WriteLine ($"{PokemonInstance.InstanceCount} Pokemons generated");
            Console.WriteLine ("Done");
        }
    }
}