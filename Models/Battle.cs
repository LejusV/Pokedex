using System;
using System.Text;

namespace Pokedex.Models
{
    internal class Battle
    {
        # region Attributes
        public string Status(Player player1, Player player2)
        {
            Pokemon player1Pok = player1.Pokemons[0];
            Pokemon player2Pok = player2.Pokemons[0];
            
            StringBuilder output = new ();

            output.AppendLine($"\t\t\t\t\t\t┌------------------┐");

            output.AppendLine($"\t\t\t\t\t\t| {player2Pok.Nickname, -16} |");
            output.AppendLine($"\t\t\t\t\t\t| LvL{player2Pok.Level, -3}           |");

            output.AppendLine($"\t\t\t\t\t\t|                  |");

            output.Append($"\t\t\t\t\t\t|   {player2Pok.CurrentStats.Get("HP"), 3}");
            output.AppendLine($" / {player2Pok.CalculatedStats.Get("HP"), 3} HP   |");

            output.AppendLine($"\t\t\t\t\t\t└------------------┘");

            output.AppendLine($"┌------------------┐");

            output.AppendLine($"| {player1Pok.Nickname, 16} |");
            output.AppendLine($"|           LvL{player1Pok.Level, -3} |");

            output.AppendLine($"|                  |");

            output.Append($"|   {player1Pok.CurrentStats.Get("HP"), 3}");
            output.AppendLine($" / {player1Pok.CalculatedStats.Get("HP"), 3} HP   |");

            output.AppendLine($"└------------------┘");

            return output.ToString();
        }
        # endregion


        public Battle(Player player1, Player player2)
        {
            Console.WriteLine("A new battle is about to happen !");
            Console.WriteLine(Status(player1, player2));
        }
    }
}