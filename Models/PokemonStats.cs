using System.Collections.Generic;

namespace Pokedex.Models
{
    public class PokemonStats
    {
        private Dictionary<string, int> Stats { get; set;}

        private string[] keys = {"hp", "attack", "defense", "sp_attack", "sp_defense", "speed"};

        public string[] Keys
        {
            get {return keys;}
        }

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
                {"hp", hp},
                {"attack", attack},
                {"defense", defense},
                {"sp_attack", sp_attack},
                {"sp_defense", sp_defense},
                {"speed", speed}
            };
        }
    }
}