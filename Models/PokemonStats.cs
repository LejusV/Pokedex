using System;
using System.Collections.Generic;
using System.Text;
using Pokedex.Enums;

namespace Pokedex.Models
{
    public class PokemonStats
    {
        private Dictionary<Stat, int> _stats;

        public int Get(Stat key)
        {
            return _stats[key];
        }
        
        public void Set(Stat key, int value)
        {
            _stats[key] = value;
        }

        public void Add(Stat key, int value)
        {
            _stats[key] += value;
        }

        public void CopyTo(PokemonStats stats_copy)
        {
            foreach (Stat key in Enum.GetValues<Stat>()) stats_copy.Set(key, this._stats[key]);
        }

        public PokemonStats(int hp, int attack, int defense, int sp_attack, int sp_defense, int speed)
        {
            _stats = new Dictionary<Stat, int>
            {
                {Stat.HP, hp},
                {Stat.ATK, attack},
                {Stat.DEF, defense},
                {Stat.SP_ATK, sp_attack},
                {Stat.SP_DEF, sp_defense},
                {Stat.SPEED, speed}
            };
        }
    }
}