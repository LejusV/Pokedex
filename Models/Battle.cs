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
            Pokemon opponent_pok = opponent_poks[0];
            
            Console.WriteLine(
                "\t\t\t\t"+ opponent_pok.Nickname+ "\n" +
                "\t\t\t\t\tlvl " + opponent_pok.Level + "\n" +
                "\t\t\t\t\t" + opponent_pok.ActualStats.Get("hp") + "/" + opponent_pok.BaseStats.Get("hp") + "HP" + "\n\n" +
                player_pok.Nickname + "\n" + 
                "\tlvl " + player_pok.Level + "\n" +
                "\t" + player_pok.ActualStats.Get("hp") + "/" + player_pok.BaseStats.Get("hp") + "HP" + "\n\n"
            );
        }
    }
}