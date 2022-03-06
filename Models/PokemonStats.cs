using System.Collections.Generic;

namespace Pokedex.Models
{
    public class PokemonStats
    {
        private Dictionary<string, int> _stats;

        public static readonly string[] Keys = {"HP", "ATK", "DEF", "SP_ATK", "SP_DEF", "SPEED"};

        public int Get(string key)
        {
            return _stats[key];
        }
        
        public void Set(string key, int value)
        {
            _stats[key] = value;
        }

        public void CopyTo(PokemonStats stats_copy)
        {
            foreach (string key in Keys) stats_copy.Set(key, this._stats[key]);
        }

        public PokemonStats(int hp, int attack, int defense, int sp_attack, int sp_defense, int speed)
        {
            _stats = new Dictionary<string, int>
            {
                {"HP", hp},
                {"ATK", attack},
                {"DEF", defense},
                {"SP_ATK", sp_attack},
                {"SP_DEF", sp_defense},
                {"SPEED", speed}
            };
        }
    }
}