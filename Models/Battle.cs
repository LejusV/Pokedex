using System;
using System.Collections.Generic;

namespace Pokedex.Models
{
    internal class Battle
    {

        public Battle(Trainer trainer, List<Pokemon> opponent_poks)
        {
            Console.WriteLine("A new battle is about to happen !");
            
            Pokemon player_pok = trainer.Pokemons[0];
            Pokemon opp_pok = opponent_poks[0];
            
            Console.WriteLine("\t\t\t"+ opp_pok.Nickname+ "\n" +
            "\t\t\t\tlvl " + opp_pok.Level);
        }
    }
}