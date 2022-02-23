using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Taillow Specie to store common natural stats of every {'abilities': ['guts', 'scrappy'], 'base_experience': 54, 'height': 3, 'id': 276, 'moves': ['wing-attack', 'whirlwind', 'fly', 'double-edge', 'growl', 'supersonic', 'peck', 'counter', 'toxic', 'agility', 'quick-attack', 'rage', 'mimic', 'double-team', 'focus-energy', 'mirror-move', 'swift', 'sky-attack', 'rest', 'substitute', 'thief', 'snore', 'reversal', 'protect', 'mud-slap', 'endure', 'swagger', 'steel-wing', 'attract', 'sleep-talk', 'return', 'frustration', 'pursuit', 'hidden-power', 'twister', 'rain-dance', 'sunny-day', 'heat-wave', 'facade', 'endeavor', 'refresh', 'secret-power', 'air-cutter', 'aerial-ace', 'roost', 'natural-gift', 'pluck', 'tailwind', 'u-turn', 'air-slash', 'brave-bird', 'defog', 'captivate', 'ominous-wind', 'round', 'echoed-voice', 'quick-guard', 'work-up', 'hurricane', 'boomburst', 'confide'], 'name': 'taillow', 'stats': {'hp': 40, 'attack': 55, 'defense': 30, 'special-attack': 30, 'special-defense': 30, 'speed': 85}, 'types': ['normal', 'flying'], 'weight': 23, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 15, 'gender_rate': 4, 'capture_rate': 200, 'color': 'blue', 'shape': 'wings', 'habitat': 'grassland', 'generation': 'generation-iii', 'growth_rate': 'medium-slow', 'egg_groups': ['flying'], 'names': {'ja-Hrkt': 'スバメ', 'roomaji': 'Subame', 'ko': '테일로', 'zh-Hant': '傲骨燕', 'fr': 'Nirondelle', 'de': 'Schwalbini', 'es': 'Taillow', 'it': 'Taillow', 'en': 'Taillow', 'ja': 'スバメ', 'zh-Hans': '傲骨燕'}, 'genera': {'ja-Hrkt': 'こツバメポケモン', 'ko': '아기제비포켓몬', 'zh-Hant': '幼燕寶可夢', 'fr': 'Pokémon Minirondel', 'de': 'Schwälblein', 'es': 'Pokémon Pequebuche', 'it': 'Pokémon Rondinella', 'en': 'Tiny Swallow Pokémon', 'ja': 'こツバメポケモン', 'zh-Hans': '幼燕宝可梦'}}
	public class SpecieTaillow : PokemonSpecie
	{
#nullable enable
		private static SpecieTaillow? _instance = null;
#nullable restore
        public static SpecieTaillow Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieTaillow();
                }
                return _instance;
            }
        }

		public SpecieTaillow() : base(
			"Taillow",
			40, // HPs
			55, 30, // Attack & Defense
			30, 30, // Special Attack & Defense
			85			
		) {}
	}


	//Taillow Pokemon Class
	public class Taillow : Pokemon
	{

		public Taillow(string nickname, int level) : base(
			276,
			SpecieTaillow.Instance, // Pokemon Specie
			nickname, level,
			Normal.Instance, Flying.Instance			
		) {}

		public Taillow() : base(
			276,
			SpecieTaillow.Instance, // Pokemon Specie
			Normal.Instance, Flying.Instance			
		) {}
	}
}