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
        private DamageHandler? _instance;
        # nullable restore
        # endregion

        # region Attributes
        public DamageHandler Instance => this._instance ?? (this._instance = new DamageHandler());
        # endregion

        # region Constructor
        public DamageHandler()
        { }
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

            return 1;
        }
        # endregion
    }
}