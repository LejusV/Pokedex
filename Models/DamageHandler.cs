using System;
using System.Reflection;
using System.Text;
using Pokedex.Enums;

namespace Pokedex.Models
{
    internal class DamageHandler
    {
        # region Variables
        # nullable enable
        private static DamageHandler? _instance;
        # nullable restore
        # endregion

        # region Attributes
        public static DamageHandler Instance => _instance ?? (_instance = new DamageHandler());
        # endregion

        # region Constructor
        private DamageHandler()
        {}
        # endregion

        # region Methods
        public int CalculateDamage(PokemonInstance attacker, PokemonInstance defender, MoveInstance move)
        {
            // Initial Damage
            double damage = (0.4 * attacker.Level + 2) * move.Attributes.Power ?? 1;

            // Adjust for stats
            damage *= move.Attributes.Category == MoveCategory.Physical
                    ? (double) attacker.CurrentStats.Get("ATK") / defender.CurrentStats.Get("DEF")
                    : (double) attacker.CurrentStats.Get("SP_ATK") / defender.CurrentStats.Get("SP_DEF");
            
            damage = damage / 50 + 2;
            
            // STAB
            if (move.Attributes.Type == attacker.Species.Types.Item1
                || move.Attributes.Type == attacker.Species.Types.Item2)
                    damage *= 1.5;

            // Effectiveness on the Type1 and eventual Type2 of defender
            double effectiveness = 1;
            effectiveness *= move.Attributes.Type.EffectOn.ContainsKey(defender.Species.Types.Item1.Name)
                    ? move.Attributes.Type.EffectOn[defender.Species.Types.Item1.Name]
                    : 1 ;
            if (defender.Species.Types.Item2 != null)
            {
                effectiveness *= move.Attributes.Type.EffectOn.ContainsKey(defender.Species.Types.Item2.Name)
                        ? move.Attributes.Type.EffectOn[defender.Species.Types.Item2.Name]
                        : 1 ;
            }
            if (effectiveness == 0)
                Console.WriteLine($"\tIt is not effective at all");
            else if (effectiveness == 0.25)
                Console.WriteLine($"\tIt is not effective");
            else if (effectiveness == 0.5)
                Console.WriteLine($"\tIt is not very effective");
            else if (effectiveness == 1)
                Console.WriteLine($"\tIt is effective");
            else if (effectiveness == 2)
                Console.WriteLine($"\tIt is super effective");
            else if (effectiveness == 4)
                Console.WriteLine($"\tIt is ultra effective");
            damage *= effectiveness;

            // Is Attacker Burned ? (dmg reduced by 2 if so)
            damage *= attacker.IsBurned ? 0.5 : 1 ;

            // Random
            Random rnd = Program.Random;
            damage *= ((double) rnd.Next(85, 101)) / 100 ;
            

            return (int) damage;
        }
        # endregion
    }
}