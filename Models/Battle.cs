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
        # region Variables
        private Player _player1;
        private Player _player2;
        # endregion

        # region Attributes
            # region GetPokemons
        /// <summary>
        /// Returns all not-KO pokemons of the Battle (usefull for the moves with target attribute "AllPokemons")
        /// </summary>
        /// <value>List<PokemonInstance></value>
        private List<PokemonInstance> AllPokemons
        {
            get
            {
                var result = new List<PokemonInstance>();
                foreach (var poke in _player1.Pokemons)
                {
                    if (poke is not null && !poke.IsKO)
                        result.Add(poke);
                }
                foreach (var poke in _player2.Pokemons)
                {
                    if (poke is not null && !poke.IsKO)
                        result.Add(poke);
                }
                return result;
            }
        }
            # endregion
            # region GetPlayers
        /// <summary>
        /// Getter of the Player N°1
        /// </summary>
        public Player Player1 => _player1;
        
        /// <summary>
        /// Getter of the Player N°1
        /// </summary>
        public Player Player2 => _player2;
        
        /// <summary>
        /// Getter of the Opponent of a Player
        /// </summary>
        public Player OpponentOf(Player opponent)
        {
            if (opponent == Player1)
            {
                return Player2;
            }
            else
            {
                return Player1;
            }
        }
            # endregion
            # region String Getters
        /// <summary>
        /// Getter of a string displaying the state of the battle
        /// </summary>
        /// <value></value>
        public string Status
        {
            get
            {                
                StringBuilder output = new ();

                output.AppendLine($"\t\t\t\t\t\t┌------------------┐");

                output.AppendLine($"\t\t\t\t\t\t| {_player2.ActivePokemon!.Nickname, -16} |");
                output.AppendLine($"\t\t\t\t\t\t| LvL{_player2.ActivePokemon.Level, -3}           |");

                output.AppendLine($"\t\t\t\t\t\t|                  |");

                output.Append($"\t\t\t\t\t\t|   {_player2.ActivePokemon.CurrentStats.Get(Stat.HP), 3}");
                output.AppendLine($" / {_player2.ActivePokemon.CalculatedStats.Get(Stat.HP), 3} HP   |");

                output.AppendLine($"\t\t\t\t\t\t└------------------┘");

                output.AppendLine($"┌------------------┐");

                output.AppendLine($"| {_player1.ActivePokemon!.Nickname, 16} |");
                output.AppendLine($"|           LvL{_player1.ActivePokemon.Level, -3} |");

                output.AppendLine($"|                  |");

                output.Append($"|   {_player1.ActivePokemon.CurrentStats.Get(Stat.HP), 3}");
                output.AppendLine($" / {_player1.ActivePokemon.CalculatedStats.Get(Stat.HP), 3} HP   |");

                output.AppendLine($"└------------------┘");

                return output.ToString();
            }
        }
            # endregion
        # endregion

        # region Constructors
        /// <summary>
        /// Constructor of the Battle class launching it immediately
        /// </summary>
        /// <param name="player1">Player N°1</param>
        /// <param name="player2">Player N°2</param>
        public Battle(Player player1, Player player2)
        {
            _player1 = player1;
            _player2 = player2;
            this.InitPlayer(_player1);
            this.InitPlayer(_player2);
            Console.WriteLine("A new battle is about to happen !");
            Console.WriteLine($"{this.DoBattle().Name} won the battle !");
            this.RoundOffPlayer(_player1);
            this.RoundOffPlayer(_player2);
        }
        #endregion

        # region Methods
            # region AddAllOtherPokemonsThan
        /// <summary>
        /// Adds all other pokemons than the one given in parameter to the list
        /// </summary>
        /// <param name="user">the user that should not be added</param>
        /// <param name="targets">the list to fill</param>
        private void AddAllOtherPokemonsThan(PokemonInstance user, List<PokemonInstance> targets)
        {
            foreach (var poke in user.Owner!.Pokemons)
            {
                if (poke is not null && poke != user)
                    targets.Add(poke);
            }
            foreach (var poke in OpponentOf(user.Owner!).Pokemons)
            {
                if (poke is not null)
                    targets.Add(poke);
            }
        }
            # endregion
            # region AddAllyOf
        /// <summary>
        /// Adds all other allies of the given pokemon to the list
        /// </summary>
        /// <param name="user">The pokemon whose allies should be added</param>
        /// <param name="targets">The list to fill</param>
        private void AddAllyOf(PokemonInstance user, List<PokemonInstance> targets)
        {
            var allies = new List<PokemonInstance>();
            foreach (var poke in user.Owner!.Pokemons)
            {
                if (poke is not null && poke != user)
                    allies.Add(poke);
            }
            targets.Add(allies[new Random().Next(0, allies.Count)]);
        }
            # endregion
            # region DealAilmentOrNot
        /// <summary>
        /// Deals the ailment or not to the given pokemon
        /// </summary>
        /// <param name="user">The pokemon to deal the ailment to</param>
        /// <param name="ailment">The ailment to deal</param>
        /// <param name="targets">The list of targets to deal the ailment to</param>
        private void DealAilmentOrNot(MoveInstance move, PokemonInstance target)
        {
            if (Program.Random.Next(0, 100) < move.Attributes.Ailment!.Chance || move.Attributes.Ailment!.Chance == 0)
            {
                target.Effects!.Add((Effect) move.Attributes.Ailment!.Type);
                Console.WriteLine($"{target.Nickname} received the {move.Attributes.Ailment!.Type} ailment !");
            }
        }
            # endregion
            # region DealDamage
        /// <summary>
        /// Handles the damage of a move by using the DamageHandler class
        /// </summary>
        /// <param name="attacker">The attacking pokemon</param>
        /// <param name="defender">The defending pokemon</param>
        /// <param name="move">The move used</param>
        public int DealDamage(PokemonInstance attacker, PokemonInstance defender, MoveInstance move)
        {
            // Damage Calculation
            int damage = DamageHandler.Instance.CalculateDamage(attacker, defender, move);
            move.Hurt(defender, damage);
            // return used for moves needing the damages done to heal user
            return damage;
        }

        /// <summary>
        /// Handles the damage of a one-hit-KO move (moves that one-shot)
        /// </summary>
        /// <param name="attacker">The attacking pokemon</param>
        /// <param name="defender">The defending pokemon</param>
        /// <param name="move">The move used</param>
        public int DealOhKODamage(PokemonInstance attacker, PokemonInstance defender, MoveInstance move)
        {
            move.Hurt(defender, defender.CurrentStats.Get(Stat.HP));
            return defender.CurrentStats.Get(Stat.HP);
        }
            # endregion
            # region DoBattle
        /// <summary>
        /// Handles the battle between the two players
        /// </summary>
        /// <returns></returns>
        public Player DoBattle()
        {
            int turn = 0;
            Console.WriteLine(this.Status);
            // While no player has lost
            while (this._player1.CanFight && this._player2.CanFight)
            {
                // We do the turn
                this.DoTurn();
                // And we check for KOs and if the player has lost before the next eventual turn
                if (_player1.ActivePokemon!.IsKO)
                {
                    Console.WriteLine($"{_player1.ActivePokemon.Nickname} is KO");
                }
                if (_player2.ActivePokemon!.IsKO)
                {
                    Console.WriteLine($"{_player2.ActivePokemon.Nickname} is KO");
                }
                if (_player1.CanFight)
                    _player1.CheckCanFight();
                if (_player2.CanFight)
                    _player2.CheckCanFight();

                turn++;
            }

            return this._player2.CanFight
                    ? this._player2
                    : this._player1;
        }
            # endregion
            # region DoAttack
        /// <summary>
        /// Handles an attack action depending on its Category
        /// </summary>
        /// <param name="move">The move used</param>
        /// <param name="targets">The list of targets</param>
        private void DoAttack(MoveInstance move, List<PokemonInstance> targets)
        {
            foreach (PokemonInstance target in targets)
            {
                if (this.WillHit(move, target))
                {
                    switch (move.Attributes.MoveCategory)
                    {
                        case MoveCategory.DamageAilment:
                            this.DealDamage(move.Owner, target, move);
                            this.DealAilmentOrNot(move, target);
                            break;
                        case MoveCategory.DamageHeal:
                            move.Heal(move.Owner, DealDamage(move.Owner, target, move) / 2);
                            break;
                        case MoveCategory.DamageLower:
                        case MoveCategory.DamageRaise:
                            this.DealDamage(move.Owner, target, move);
                            this.ModifyStats(move, target);
                            break;
                        case MoveCategory.Damage:
                            this.DealDamage(move.Owner, target, move);
                            break;
                        case MoveCategory.Ohko:
                            this.DealOhKODamage(move.Owner, target, move);
                            break;
                        case MoveCategory.Heal:
                            move.Heal(
                                move.Owner,
                                (int) Math.Floor(
                                        move.Owner.CalculatedStats.Get(Stat.HP)
                                        * move.Attributes.HealingPercent / 100.0));
                            break;
                        case MoveCategory.ForceSwitch:
                            if (target.Owner!.PokemonsCount > 1 && target.Owner.Pokemons.Count(p => (p != null) && (!p.IsKO)) > 1)
                                for (int i = 0; i < target.Owner.Pokemons.Length; i++)
                                    if (target.Owner.Pokemons[i] is not null && target.Owner.Pokemons[i] != target)
                                        target.Owner.SwitchPokemon(i);
                            else
                            {
                                HandleAction(6 /*Flee*/, target.Owner);
                                return;
                            }
                            break;
                        case MoveCategory.Ailment:
                            this.DealAilmentOrNot(move, target);
                            break;
                        case MoveCategory.NetGoodStats:
                            this.ModifyStats(move, target);
                            break;
                        case MoveCategory.Swagger:
                            this.ModifyStats(move, target);
                            this.DealAilmentOrNot(move, target);
                            break;
                        case MoveCategory.WholeFieldEffect:
                            // Météo pas implémentée pour le moment car pas prioritaire
                            Console.WriteLine("// Météo pas implémentée pour le moment car pas prioritaire \\\\");
                            break;
                        case MoveCategory.FieldEffect:
                            // Move au compte goutte et particuliers de shield, de dégâts au switch de pokemon, etc... agissant sur l'environnement d'un pokemon
                            Console.WriteLine("// Move au compte goutte et particuliers de shield, de dégâts au switch de pokemon, etc... agissant sur l'environnement d'un pokemon \\\\");
                            break;
                        case MoveCategory.Unique:
                            // Move extrèmement spécifiques qui peuvent difficilement être implémentées par groupe donc pas prioritaire pour le moment
                            Console.WriteLine("// Move extrèmement spécifiques qui peuvent difficilement être implémentées par groupe donc pas prioritaire pour le moment \\\\");
                            break;
                    }
                    move.Owner.CheckIsKO();
                    target.CheckIsKO();
                }
                else
                    Console.WriteLine($"{move.Owner.Nickname}'s attack missed !");
            }
        }
            # endregion
            # region DoTurn
        /// <summary>
        /// Handles a turn of the battle
        /// </summary>
        private void DoTurn()
        {
            var moveQueue = new List<MoveInstance>();
            int actionIndex1NotNull;
            int actionIndex2NotNull;
            // If Pokemon is not KO we ask for an Action Index
            if (!_player1.ActivePokemon!.IsKO)
                actionIndex1NotNull = this.MoveInput(_player1);
            // Else it has to switch
            else
                actionIndex1NotNull = 5; // Switch of pokemon      
            if (!_player2.ActivePokemon!.IsKO)
                actionIndex2NotNull = this.MoveInput(_player2);
            else
                actionIndex2NotNull = 5; // Switch of pokemon
            // Chooses what to do and calls the needed functions
            HandleAction(actionIndex1NotNull, _player1, moveQueue);
            HandleAction(actionIndex2NotNull, _player2, moveQueue);
            // Sorts the moves by priority and then by speed of the user (LINQ)
            moveQueue =
                moveQueue
                .OrderByDescending(m => (m.Attributes.Priority, m.Owner.CurrentStats.Get(Stat.SPEED)) )
                .ToList();
            // Then we do the moves
            foreach (MoveInstance move in moveQueue)
            {
                Console.WriteLine($"{move.Owner.Nickname} used {move.Attributes.Name} !");
                var targets = this.GetTargets(move);
                // Chooses the right methods to call depending on the the Move effects
                this.DoAttack(move, targets);

                Console.WriteLine(this.Status);
                // if player has not lost yet (by something else than all Pokemon being KO)
                if (_player1.CanFight)
                    // We check for KOs
                    this._player1.ActivePokemon!.CheckIsKO();
                else
                    return;
                if (_player2.CanFight)
                    this._player2.ActivePokemon!.CheckIsKO();
                else
                    return;
                // If this move knocked-up the opponent pokemon then it cannot land its next move so we skip it
                if (OpponentOf(move.Owner.Owner!).ActivePokemon!.IsKO)
                {
                    return;
                }
            }
        }
            # endregion
            # region GetTargets
        /// <summary>
        /// Gets the targets of a move depending on its target type
        /// </summary>
        /// <param name="move">The move used</param>
        /// <returns>The list of target(s)</returns>
        private List<PokemonInstance> GetTargets(MoveInstance move)
        {
            List<PokemonInstance> targets = new List<PokemonInstance>();
            // Determinates the possible targets depending on the move's target type
            switch (move.Attributes.TargetType)
            {
                // Pokemon User (1 target)
                case MoveTarget.User:
                    targets.Add(move.Owner); break;
                // All Pokemon (multiple targets)
                case MoveTarget.AllPokemon:
                    targets.AddRange(this.AllPokemons); break;
                // An Ally but not the User (1 target)
                case MoveTarget.Ally:
                    this.AddAllyOf(move.Owner, targets); break;
                // An Opponent (1 target) {Me First Not Implemented for now}
                case MoveTarget.SelectedPokemonMeFirst:
                case MoveTarget.SelectedPokemon: 
                    targets.Add(OpponentOf(move.Owner.Owner!).ActivePokemon!); break;
                // All Opponents (multiple targets)
                case MoveTarget.AllOpponents:
                    foreach (var poke in OpponentOf(move.Owner.Owner!).Pokemons) if (poke is not null) targets.Add(poke);
                    break;
                // All Pokemon but User (multiple targets)
                case MoveTarget.AllOtherPokemon:
                    this.AddAllOtherPokemonsThan(move.Owner, targets); break;
                // All Allies including User (multiple target)
                case MoveTarget.UserAndAllies:
                    foreach (var poke in move.Owner.Owner!.Pokemons)
                        if (poke is not null) targets.Add(poke);
                    break;
                // An Ally or the User
                case MoveTarget.UserOrAlly:
                    targets.Add(move.Owner); // Par défaut tant que je le change pas ce sera toujours le lanceur
                    break;
                // les autres sont trop rares pour être implémentés pour le moment
                default:
                    break;
            }
            return targets;
        }
            # endregion
            # region HandleAction
        /// <summary>
        /// Method Handling the action of a player depending on the given action index
        /// </summary>
        /// <param name="actionIndex">The index determining what action to do</param>
        /// <param name="player">The Player who chose an action</param>
        /// <param name="moveQueue">The Move Queue if action is a MoveInstance</param>
        private void HandleAction(int actionIndex, Player player, List<MoveInstance>? moveQueue = null)
        {
            // If the index represents a Move (MoveInstance)
            if ((actionIndex is >= 1 and <= 4) && (moveQueue is not null))
                moveQueue.Add(player.ActivePokemon!.Moves[actionIndex - 1]!);
            // If the index represents a Switch of Pokemon
            else if (actionIndex is 5)
            {
                int switchIndex;
                do
                {
                    switchIndex = this.SwitchInput(player);
                } while (!player.SwitchPokemon(switchIndex - 1));
                Console.WriteLine(this.Status);
            }
            // If the index represents the escape (Flee)
            else if (actionIndex is 6)
            {
                player.CanFight = false;
                Console.WriteLine($"{player.Name} fled !");
                return;
            }
            // Else there has been a problem in previous checks of the validity of the Index
            else
                throw new Exception("Invalid move index or MoveQueue is null");
        }
            # endregion
            # region InitPlayer
        /// <summary>
        /// Called at the beginning of the battle to create Battle-Only stats for the Player
        /// </summary>
        /// <param name="player">The Player whose stats are to create</param>
        private void InitPlayer(Player player)
        {
            player.ActivePokemon = player.DefaultPokemon;
            foreach (PokemonInstance? poke in player.Pokemons)
            {
                if (poke is not null)
                {
                    poke.BattleStats = new PokemonBattleStats(100, 100); // Will always be 100% at the start of a battle
                    poke.BattleStatModifiers = new PokemonBattleStats(0, 0); // Modifiers are reset at the start of a battle
                    poke.Effects = new List<Effect>();
                }
            }
        }
            # endregion
            # region ModifyStats
        /// <summary>
        /// Method used by moves who modify a stat (raise or lower)
        /// </summary>
        /// <param name="move">the move at the origin of the modification</param>
        /// <param name="target">the target whose stats are to alter</param>
        private void ModifyStats(MoveInstance move, PokemonInstance target)
        {
            if (move.Attributes.StatChanges is not null)
            {
                var statChangements = move.Attributes.StatChanges;
                // Moves modifying multiple stats exist
                foreach (var statChange in statChangements)
                {
                    // If the stat is a common stat (ATK, DEF, SP_ATK, SP_DEF or SPEED)
                    if (Enum.GetNames<Enums.Stat>().Contains(Enum.GetName<BattleStat>(statChange.Key)))
                    {
                        move.ModifyStat(target, (Stat) statChange.Key, statChange.Value); // where the modification takes place
                        # region Modify Common Stat Display Handling
                        var output = new StringBuilder();
                        output.Append($"{target.Nickname}'s ");
                        // Display adaptation depending on the stat
                        switch (statChange.Key)
                        {
                            case Enums.BattleStat.ATK:
                                output.Append("Attack");
                                break;
                            case Enums.BattleStat.DEF:
                                output.Append("Defense");
                                break;
                            case Enums.BattleStat.SP_ATK:
                                output.Append("Special Attack");
                                break;
                            case Enums.BattleStat.SP_DEF:
                                output.Append("Special Defense");
                                break;
                            case Enums.BattleStat.SPEED:
                                output.Append("Speed");
                                break;
                        }
                        if (statChange.Value >= 0)
                            output.Append(" increased");
                        else
                            output.Append(" decreased");
                        output.Append($" by {Math.Abs(statChange.Value)} stage"); // Number of stages display
                        if (statChange.Value is > 1 or < -1)
                            output.Append("s");
                        output.Append(" !");
                        Console.WriteLine(output.ToString());
                        # endregion
                    }
                    // Or if the stat is a in battle-only stat (ACCURACY or EVASION)
                    else if (Enum.GetNames<Enums.AccuracyEvasion>().Contains(Enum.GetName<BattleStat>(statChange.Key)))
                    {
                        move.ModifyBattleStat(target, (AccuracyEvasion) statChange.Key, statChange.Value);
                        # region Modify Battle Stat Display Handling
                        var output = new StringBuilder();
                        output.Append($"{target.Nickname}'s ");
                        switch (statChange.Key)
                        {
                            case Enums.BattleStat.ACCURACY:
                                output.Append("Accuracy");
                                break;
                            case Enums.BattleStat.EVASION:
                                output.Append("Evasion");
                                break;
                        }
                        if (statChange.Value >= 0)
                            output.Append(" increased");
                        else
                            output.Append(" decreased");
                        output.Append($" by {Math.Abs(statChange.Value)} stage");
                        if (statChange.Value is > 1 or < -1)
                            output.Append("s");
                        output.Append(" !");
                        Console.WriteLine(output.ToString());
                        # endregion
                    }
                    else
                        throw new Exception("Invalid stat changes"); // Error handling
                }
            }
        }
            # endregion
            # region MoveInput
        /// <summary>
        /// Handles the choice of a move to use for the given player and returns it
        /// </summary>
        /// <param name="player">The player who needs to use a move</param>
        /// <returns>The chosen move</returns>
        private int MoveInput(Player player)
        {
            int moveIndex = 0;
            while (moveIndex == 0)
            {
                if (player != PlayerAI.Instance)
                {
                    Console.WriteLine($"\t{player.Name} : Choose your move (1 2 / 3 4 / 5 6)");
                    Console.Write(player.ActivePokemon!.MovesDisplay);
                    Console.Write($"        5 : Switch Pokemon");
                    Console.WriteLine("             Flee : 6");
                    Console.WriteLine("");
        
                    int.TryParse(Console.ReadLine(), out moveIndex);
                }
                else
                {
                    // AIPlayer will use the last move available in its hand
                    int index;
                    for (index = 0; index < player.ActivePokemon!.Moves.Length; index++)
                    {
                        if (player.ActivePokemon!.Moves[index] is not null)
                            if (player.ActivePokemon!.Moves[index]!.PP > 0)
                                moveIndex = index + 1;
                    }
                    if (index >= player.ActivePokemon!.Moves.Length && moveIndex == 0)
                    {
                        throw new Exception("No Move to use !");
                    }
                }

                // If this is a move and neither switch nor flee
                if (moveIndex is >= 1 and <= 4)
                    // If this move doesn't exist we start again the input
                    if (player.ActivePokemon!.Moves[moveIndex - 1] is null)
                    {
                        Console.WriteLine("No move in this slot !");
                        moveIndex = 0;
                    }
                    // If this move exists but no PP we start again the input
                    else if (player.ActivePokemon!.Moves[moveIndex - 1]!.PP == 0)
                    {
                        Console.WriteLine("No PP left !");
                        moveIndex = 0;
                    }
                // If the entry is incorrect
                else if (moveIndex is > 6 or < 1)
                {
                    Console.WriteLine("Invalid entry !");
                    moveIndex = 0;
                }
            }
            // If everything is valid we return the index
            return moveIndex;
        }
            #endregion 
            # region RoundOffPlayer
        /// <summary>
        /// Called at the end of the battle to remove Battle-Only stats from the player attributes
        /// </summary>
        /// <param name="player">The Player whose stats are to remove</param>
        private void RoundOffPlayer(Player player)      
        {
            player.ActivePokemon = null;
            foreach (PokemonInstance? poke in player.Pokemons)
            {
                if (poke is not null)
                {
                    // Remove all Battle-Only stats
                    // (reseted at 100 at each start
                    // of battle and useless outside of it)
                    poke.BattleStats = null;
                    // Same for those stat Modifiers
                    poke.BattleStatModifiers = null;
                    // Same for the in-battle ailments
                    poke.Effects = null;
                }
            }
        }
            # endregion
            # region SwitchInput
        /// <summary>
        /// Function asking the user to choose the index of a pokemon to switch to
        /// </summary>
        /// <param name="player">Player who needs to choose</param>
        /// <returns>Index of PokemonSlot</returns>
        private int SwitchInput(Player player)
        {
            int switchIndex = 0;
            while (switchIndex == 0)
            {
                if (player != PlayerAI.Instance)
                {
                    Console.WriteLine($"\t{player.Name} : Choose your pokemon (1 2 / 3 4 / 5 6)");
                    Console.WriteLine(player.PokemonsDisplay);
        
                    int.TryParse(Console.ReadLine(), out switchIndex);
                }
                else
                {
                    // AIPlayer will use the last pokemon available in its hand
                    int index;
                    for (index = 0; index < player.Pokemons.Length; index++)
                        if (player.Pokemons[index] is not null && !player.Pokemons[index]!.IsKO)
                            switchIndex = index + 1;
                    if (index >= player.Pokemons.Length && switchIndex == 0)
                    {
                        throw new Exception("No pokemon to switch !"); // Error handling as battle should have ended
                    }
                }
                // If entry is incorrect we ask again
                if ((switchIndex is >= 1 and <= 6 && player.Pokemons[switchIndex - 1] is null)
                    || (switchIndex is > 6 or < 1))
                {
                    Console.WriteLine("Invalid entry !");
                    switchIndex = 0;
                }
            }
            // And finally we return the incoming pokemon index
            return switchIndex;
        }
            # endregion
            # region WillHit
        /// <summary>
        /// Determinates whether the move will hit or be dodged
        /// </summary>
        /// <param name="move">The move used</param>
        /// <param name="target">The targeted Pokemon</param>
        /// <returns>True or False</returns>
        public bool WillHit(MoveInstance move, PokemonInstance target)
        {
            if (move.Attributes.Accuracy == 0)
            {
                // if Accuracy = 0 it'll never hit (better prevent than heal)
                return false;
            }
            else if (move.Attributes.Accuracy is null)
            {
                // if Accuracy is null (--) it means it will always hit
                return true;
            }
            else
            {
                return  // If the random generated INT < (MoveAccuracy * attakerAccuracy% * targetEvasion%), then it will hit
                    Program.Random.Next(0, 100)
                    < ((int) (move.Attributes.Accuracy
                        * (move.Owner.BattleStats!.Get(AccuracyEvasion.ACCURACY) / 100.0)
                        * (target.BattleStats!.Get(AccuracyEvasion.EVASION) / 100.0)) );
            }
        }
            # endregion
        #endregion
    }
}