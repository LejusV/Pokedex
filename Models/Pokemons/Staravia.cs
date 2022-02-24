using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Staravia Specie to store common natural stats of every {'abilities': ['intimidate', 'reckless'], 'base_experience': 119, 'height': 6, 'id': 397, 'moves': ['wing-attack', 'whirlwind', 'fly', 'tackle', 'take-down', 'growl', 'toxic', 'agility', 'quick-attack', 'double-team', 'swift', 'rest', 'substitute', 'thief', 'snore', 'protect', 'mud-slap', 'endure', 'swagger', 'steel-wing', 'attract', 'sleep-talk', 'return', 'frustration', 'hidden-power', 'twister', 'rain-dance', 'sunny-day', 'uproar', 'heat-wave', 'facade', 'endeavor', 'secret-power', 'air-cutter', 'aerial-ace', 'roost', 'natural-gift', 'pluck', 'tailwind', 'u-turn', 'brave-bird', 'defog', 'captivate', 'ominous-wind', 'round', 'echoed-voice', 'retaliate', 'final-gambit', 'work-up', 'confide'], 'name': 'staravia', 'stats': {'hp': 55, 'attack': 75, 'defense': 50, 'special-attack': 40, 'special-defense': 40, 'speed': 80}, 'types': ['normal', 'flying'], 'weight': 155, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 15, 'gender_rate': 4, 'capture_rate': 120, 'color': 'brown', 'shape': 'wings', 'habitat': None, 'generation': 'generation-iv', 'growth_rate': 'medium-slow', 'egg_groups': ['flying'], 'names': {'ja-Hrkt': 'ムクバード', 'roomaji': 'Mukubird', 'ko': '찌르버드', 'zh-Hant': '姆克鳥', 'fr': 'Étourvol', 'de': 'Staravia', 'es': 'Staravia', 'it': 'Staravia', 'en': 'Staravia', 'ja': 'ムクバード', 'zh-Hans': '姆克鸟'}, 'genera': {'ja-Hrkt': 'むくどりポケモン', 'ko': '찌르레기포켓몬', 'zh-Hant': '椋鳥寶可夢', 'fr': 'Pokémon Étourneau', 'de': 'Star', 'es': 'Pokémon Estornino', 'it': 'Pokémon Storno', 'en': 'Starling Pokémon', 'ja': 'むくどりポケモン', 'zh-Hans': '椋鸟宝可梦'}}
	public class SpecieStaravia : PokemonSpecie
	{
#nullable enable
		private static SpecieStaravia? _instance = null;
#nullable restore
        public static SpecieStaravia Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieStaravia();
                }
                return _instance;
            }
        }

		public SpecieStaravia() : base(
			"Staravia",
			55, // HPs
			75, 50, // Attack & Defense
			40, 40, // Special Attack & Defense
			80			
		) {}
	}


	//Staravia Pokemon Class
	public class Staravia : Pokemon
	{

		public Staravia(string nickname, int level)
		: base(
				397,
				SpecieStaravia.Instance, // Pokemon Specie
				nickname, level,
				Normal.Instance, Flying.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Staravia(int level)
		: base(
				397,
				SpecieStaravia.Instance, // Pokemon Specie
				"Staravia", level,
				Normal.Instance, Flying.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Staravia() : base(
			397,
			SpecieStaravia.Instance, // Pokemon Specie
			Normal.Instance, Flying.Instance			
		) {}
	}
}