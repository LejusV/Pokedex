using System;
using System.Collections.Generic;

namespace Pokedex.Models
{
    internal class Battle
    {

        public Battle(Player player1, Player player2)
        {
            private static Bug? _instance = null;
            public static Bug Instance
            {
                get
                {
                    if (_instance == null)
                    {
                        _instance = new Bug();
                    }
                    return _instance;
                }
            }
            Console.WriteLine("A new battle is about to happen !");
            
            Pokemon player1Pok = player1.Pokemons[0];
            Pokemon player2Pok = opponent_poks[0];
            
            Console.WriteLine(
                "\t\t\t\t"+ opponent_pok.Nickname+ "\n" +
                "\t\t\t\t\tlvl " + opponent_pok.Level + "\n" +
                "\t\t\t\t\t" + opponent_pok.CurrentStats.Get("hp") + "/" + opponent_pok.CalculatedStats.Get("hp") + "HP" + "\n\n" +
                player_pok.Nickname + "\n" + 
                "\tlvl " + player_pok.Level + "\n" +
                "\t" + player_pok.CurrentStats.Get("hp") + "/" + player_pok.CalculatedStats.Get("hp") + "HP" + "\n\n"
            );
        }
    }
}