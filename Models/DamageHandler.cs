using System;
using System.Reflection;
using System.Text;
using Pokedex.Models;

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
        public int CalculateDamage(PokemonInstance attacker, PokemonInstance defender)
        {
            // Initial Damage
            double damage = (0.4 * attacker.Level + 2) * ModuleResolveEventHandler.Power;

            // Adjust for stats
            if (move.Damage == DamageClass.Physical)
                damage *= ((double) attacker.Pokemon. //TODO J'ETAIS ICI)

        }
        # endregion
    }
}