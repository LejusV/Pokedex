using System;
using System.Text;
using System.Linq;
using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Players;

namespace Pokedex.Models
{
    internal class Battle
    {
        private Player _player1;
        private Player _player2;


        # region Attributes

        public Player Player1 => _player1;

        public Player Player2 => _player2;

        public string Status
        {
            get
            {
                PokemonInstance player1Pok = _player1.Pokemons[0];
                PokemonInstance player2Pok = _player2.Pokemons[0];
                
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
        }
        # endregion


        public Battle(Player player1, Player player2)
        {
            _player1 = player1;
            _player2 = player2;
            Console.WriteLine("A new battle is about to happen !");
            Console.WriteLine(this.Status);
        }

        public Player DoBattle()
        {
            int turn = 0;
            
            while (this._player1.CanFight && this._player2.CanFight)
            {
                // Code
                this.DoTurn();

                turn++;
            }

            return this._player1.CanFight
                    ? this._player1
                    : this._player2;
        }

        public void DoTurn()
        {
            var moveQueue = new List<MoveInstance>();

            MoveInstance? moveUsed = null;
            int moveIndex = 0;
            while (moveUsed == null)
            {
                if (_player1 != PlayerAI.Instance)
                {
                    Console.WriteLine("\tPlayer 1 : Choose your move");
                    int.TryParse(Console.ReadLine() !, out moveIndex);
                }

                moveUsed = (moveIndex >= 0 && moveIndex < 4)
                    ? _player1.Pokemons[0].Moves[moveIndex]
                    : null;
            }

            moveQueue.Add(moveUsed);

            while (moveUsed == null)
            {
                if (_player2 != PlayerAI.Instance)
                {
                    Console.WriteLine("\tPlayer 2 : Choose your move");
                    int.TryParse(Console.ReadLine() !, out moveIndex);
                }

                moveUsed = (moveIndex >= 0 && moveIndex < 4)
                    ? _player2.Pokemons[0].Moves[moveIndex]
                    : null;
            }

            moveQueue.Add(moveUsed);
            moveQueue = moveQueue.OrderByDescending(m => m.Attributes.Priority).ToList();
            this.DealDamage()
        }
        public void DealDamage(PokemonInstance attacker, PokemonInstance defender, MoveInstance move)
        {
            defender.CurrentStats.Add("HP", -1 * DamageHandler.Instance.CalculateDamage(attacker, defender, move));
        }
    }
}