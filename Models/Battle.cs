using System;
using System.Text;
using System.Linq;
using System.Collections.Generic;
using Pokedex.Enums;
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
                StringBuilder output = new ();

                output.AppendLine($"\t\t\t\t\t\t┌------------------┐");

                output.AppendLine($"\t\t\t\t\t\t| {_player2.DefaultPokemon!.Nickname, -16} |");
                output.AppendLine($"\t\t\t\t\t\t| LvL{_player2.DefaultPokemon.Level, -3}           |");

                output.AppendLine($"\t\t\t\t\t\t|                  |");

                output.Append($"\t\t\t\t\t\t|   {_player2.DefaultPokemon.CurrentStats.Get("HP"), 3}");
                output.AppendLine($" / {_player2.DefaultPokemon.CalculatedStats.Get("HP"), 3} HP   |");

                output.AppendLine($"\t\t\t\t\t\t└------------------┘");

                output.AppendLine($"┌------------------┐");

                output.AppendLine($"| {_player1.DefaultPokemon!.Nickname, 16} |");
                output.AppendLine($"|           LvL{_player1.DefaultPokemon.Level, -3} |");

                output.AppendLine($"|                  |");

                output.Append($"|   {_player1.DefaultPokemon.CurrentStats.Get("HP"), 3}");
                output.AppendLine($" / {_player1.DefaultPokemon.CalculatedStats.Get("HP"), 3} HP   |");

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
            Console.WriteLine($"{this.DoBattle().Name} won the battle !");
        }

        public Player DoBattle()
        {
            int turn = 0;
            Console.WriteLine(this.Status);
            
            while (this._player1.CanFight && this._player2.CanFight)
            {
                this.DoTurn();
                this._player1.CheckCanFight();
                this._player2.CheckCanFight();

                turn++;
            }

            return this._player1.CanFight
                    ? this._player1
                    : this._player2;
        }

        private void DoTurn()
        {
            var moveQueue = new List<MoveInstance>();

            moveQueue.Add(this.MoveInput(_player1));
            moveQueue.Add(this.MoveInput(_player2));
            
            moveQueue =
                moveQueue
                .OrderByDescending(m => m.Attributes.Priority)
                .ToList();
            foreach (MoveInstance move in moveQueue)
            {
                Console.WriteLine($"{move.Owner.Nickname} used {move.Attributes.Name} !");
                if (move.Attributes.Category == MoveCategory.Physical)
                {
                    this.DoPhysicalAttack(move);
                }
                else if (move.Attributes.Category == MoveCategory.Special)
                {
                    this.DoSpecialAttack(move);
                }
                else if (move.Attributes.Category == MoveCategory.Status)
                {
                    this.DoStatusAttack(move);
                }
            }

            Console.WriteLine(this.Status);
        }

        private void DoPhysicalAttack(MoveInstance move)
        {
            this.DealDamage(
                move.Owner,
                move.Owner == _player1.DefaultPokemon!
                    ? _player2.DefaultPokemon!
                    : _player1.DefaultPokemon!,
                move
            );
        }
        private void DoSpecialAttack(MoveInstance move)
        {
            this.DealDamage(
                move.Owner,
                move.Owner == _player1.DefaultPokemon!
                    ? _player2.DefaultPokemon!
                    : _player1.DefaultPokemon!,
                move
            );
        }
        private void DoStatusAttack(MoveInstance move)
        {
        }

        public void DealDamage(PokemonInstance attacker, PokemonInstance defender, MoveInstance move)
        {
            defender.CurrentStats.Add("HP", -1 * DamageHandler.Instance.CalculateDamage(attacker, defender, move));
            attacker.CheckIsKO();
            defender.CheckIsKO();
        }

        private MoveInstance MoveInput(Player player)
        {
            MoveInstance? moveUsed = null;
            int moveIndex = 0;
            while (moveUsed == null)
            {
                if (player != PlayerAI.Instance)
                {
                    Console.WriteLine($"\t{player.Name} : Choose your move (1 2 / 3 4)");
                    Console.WriteLine(player.DefaultPokemon!.MovesDisplay);
                    int.TryParse(Input.InputLines[Input.LineIndex++], out moveIndex); // TODO : GET THIS READLINE OUT OF HERE
                }
                else
                    moveIndex = 1;

                moveUsed = (moveIndex >= 1 && moveIndex <= 4)
                    ? player.DefaultPokemon!.Moves[moveIndex - 1]
                    : null;
            }
            return moveUsed;
        }
    }
}