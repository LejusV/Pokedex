using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Sawk Specie to store common natural stats of every {'abilities': ['sturdy', 'inner-focus', 'mold-breaker'], 'base_experience': 163, 'height': 14, 'id': 539, 'moves': ['karate-chop', 'fire-punch', 'ice-punch', 'thunder-punch', 'double-kick', 'leer', 'low-kick', 'counter', 'strength', 'earthquake', 'dig', 'toxic', 'double-team', 'focus-energy', 'bide', 'rest', 'rock-slide', 'substitute', 'snore', 'reversal', 'protect', 'endure', 'swagger', 'attract', 'sleep-talk', 'return', 'frustration', 'pain-split', 'hidden-power', 'rain-dance', 'sunny-day', 'rock-smash', 'facade', 'focus-punch', 'taunt', 'helping-hand', 'superpower', 'brick-break', 'knock-off', 'secret-power', 'rock-tomb', 'block', 'bulk-up', 'close-combat', 'payback', 'fling', 'poison-jab', 'focus-blast', 'giga-impact', 'zen-headbutt', 'stone-edge', 'grass-knot', 'low-sweep', 'round', 'quick-guard', 'retaliate', 'bulldoze', 'work-up', 'dual-chop', 'confide', 'power-up-punch'], 'name': 'sawk', 'stats': {'hp': 75, 'attack': 125, 'defense': 75, 'special-attack': 30, 'special-defense': 75, 'speed': 85}, 'types': ['fighting'], 'weight': 510, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 20, 'gender_rate': 0, 'capture_rate': 45, 'color': 'blue', 'shape': 'humanoid', 'habitat': None, 'generation': 'generation-v', 'growth_rate': 'medium', 'egg_groups': ['humanshape'], 'names': {'ja-Hrkt': 'ダゲキ', 'ko': '타격귀', 'zh-Hant': '打擊鬼', 'fr': 'Karaclée', 'de': 'Karadonis', 'es': 'Sawk', 'it': 'Sawk', 'en': 'Sawk', 'ja': 'ダゲキ', 'zh-Hans': '打击鬼'}, 'genera': {'ja-Hrkt': 'からてポケモン', 'ko': '태권도포켓몬', 'zh-Hant': '空手道寶可夢', 'fr': 'Pokémon Karaté', 'de': 'Karate', 'es': 'Pokémon Kárate', 'it': 'Pokémon Karate', 'en': 'Karate Pokémon', 'ja': 'からてポケモン', 'zh-Hans': '空手道宝可梦'}}
	public class SpecieSawk : PokemonSpecie
	{
#nullable enable
		private static SpecieSawk? _instance = null;
#nullable restore
        public static SpecieSawk Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieSawk();
                }
                return _instance;
            }
        }

		public SpecieSawk() : base(
			"Sawk",
			75, // HPs
			125, 75, // Attack & Defense
			30, 75, // Special Attack & Defense
			85			
		) {}
	}


	//Sawk Pokemon Class
	public class Sawk : Pokemon
	{

		public Sawk(string nickname, int level)
		: base(
				539,
				SpecieSawk.Instance, // Pokemon Specie
				nickname, level,
				Fighting.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Sawk(int level)
		: base(
				539,
				SpecieSawk.Instance, // Pokemon Specie
				"Sawk", level,
				Fighting.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Sawk() : base(
			539,
			SpecieSawk.Instance, // Pokemon Specie
			Fighting.Instance			
		) {}
	}
}