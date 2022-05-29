using System;
using System.Collections.Generic;
using Pokedex.Enums;

namespace Pokedex.Models
{
    public class PokemonBattleStats
    {
        private Dictionary<AccuracyEvasion, int> _stats;

        public int Get(AccuracyEvasion key)
        {
            return _stats[key];
        }
        
        public void Set(AccuracyEvasion key, int value)
        {
            _stats[key] = value;
        }

        public void Add(AccuracyEvasion key, int value)
        {
            _stats[key] += value;
        }
        
        public PokemonBattleStats(int accuracy, int evasion)
        {
            _stats = new Dictionary<AccuracyEvasion, int>
            {
                {AccuracyEvasion.ACCURACY, accuracy},
                {AccuracyEvasion.EVASION, evasion}
            };
        }
    }
}