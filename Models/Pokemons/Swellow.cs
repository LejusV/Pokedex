using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Swellow Specie to store common natural stats of every {'abilities': ['guts', 'scrappy'], 'base_experience': 159, 'height': 7, 'id': 277, 'moves': ['wing-attack', 'fly', 'double-edge', 'growl', 'hyper-beam', 'peck', 'counter', 'toxic', 'agility', 'quick-attack', 'mimic', 'double-team', 'focus-energy', 'swift', 'sky-attack', 'rest', 'substitute', 'thief', 'snore', 'reversal', 'protect', 'mud-slap', 'endure', 'swagger', 'steel-wing', 'attract', 'sleep-talk', 'return', 'frustration', 'hidden-power', 'twister', 'rain-dance', 'sunny-day', 'heat-wave', 'facade', 'endeavor', 'secret-power', 'air-cutter', 'aerial-ace', 'roost', 'natural-gift', 'pluck', 'tailwind', 'u-turn', 'air-slash', 'brave-bird', 'giga-impact', 'defog', 'captivate', 'ominous-wind', 'round', 'echoed-voice', 'quick-guard', 'work-up', 'confide'], 'name': 'swellow', 'stats': {'hp': 60, 'attack': 85, 'defense': 60, 'special-attack': 75, 'special-defense': 50, 'speed': 125}, 'types': ['normal', 'flying'], 'weight': 198, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 15, 'gender_rate': 4, 'capture_rate': 45, 'color': 'blue', 'shape': 'wings', 'habitat': 'grassland', 'generation': 'generation-iii', 'growth_rate': 'medium-slow', 'egg_groups': ['flying'], 'names': {'ja-Hrkt': 'オオスバメ', 'roomaji': 'Ohsubame', 'ko': '스왈로', 'zh-Hant': '大王燕', 'fr': 'Hélédelle', 'de': 'Schwalboss', 'es': 'Swellow', 'it': 'Swellow', 'en': 'Swellow', 'ja': 'オオスバメ', 'zh-Hans': '大王燕'}, 'genera': {'ja-Hrkt': 'ツバメポケモン', 'ko': '제비포켓몬', 'zh-Hant': '燕子寶可夢', 'fr': 'Pokémon Hirondelle', 'de': 'Schwalbe', 'es': 'Pokémon Buche', 'it': 'Pokémon Rondine', 'en': 'Swallow Pokémon', 'ja': 'ツバメポケモン', 'zh-Hans': '燕子宝可梦'}}
	public class SpecieSwellow : PokemonSpecie
	{
#nullable enable
		private static SpecieSwellow? _instance = null;
#nullable restore
        public static SpecieSwellow Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieSwellow();
                }
                return _instance;
            }
        }

		public SpecieSwellow() : base(
			"Swellow",
			60, // HPs
			85, 60, // Attack & Defense
			75, 50, // Special Attack & Defense
			125			
		) {}
	}


	//Swellow Pokemon Class
	public class Swellow : Pokemon
	{

		public Swellow(string nickname, int level)
		: base(
				277,
				SpecieSwellow.Instance, // Pokemon Specie
				nickname, level,
				Normal.Instance, Flying.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Swellow() : base(
			277,
			SpecieSwellow.Instance, // Pokemon Specie
			Normal.Instance, Flying.Instance			
		) {}
	}
}