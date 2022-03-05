using System;
using System.Text;

namespace Pokedex.Models
{
    internal class Battle
    {
        # region Attributes
        # endregion


        public Battle(Player player1, Player player2)
        {
            
            Console.WriteLine("A new battle is about to happen !");
            
            Pokemon player1Pok = player1.Pokemons[0];
            Pokemon player2Pok = player2.Pokemons[0];
            
            StringBuilder output = new ();

            output.AppendLine($"\t\t\t\t {player2Pok.Nickname}");

            output.AppendLine($"\t\t\t\t\tLvL {player2Pok.Level}");

            output.Append($"\t\t\t\t\t{player2Pok.CurrentStats.Get("hp")} ");
            output.AppendLine($"/ {player2Pok.CalculatedStats.Get("hp")} HP");

            output.AppendLine($"{player1Pok.Nickname}");

            output.AppendLine($"\tLvL {player1Pok.Level}");

            output.Append($"\t\t\t\t\t{player1Pok.CurrentStats.Get("hp")} ");
            output.AppendLine($"/ {player1Pok.CalculatedStats.Get("hp")} HP");

            Console.WriteLine(output);
        }
    }
}