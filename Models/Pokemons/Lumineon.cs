using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Lumineon Specie to store common natural stats of every {'abilities': ['swift-swim', 'storm-drain', 'water-veil'], 'base_experience': 161, 'height': 12, 'id': 457, 'moves': ['pound', 'gust', 'water-gun', 'surf', 'ice-beam', 'blizzard', 'hyper-beam', 'toxic', 'double-team', 'waterfall', 'swift', 'flash', 'rest', 'substitute', 'snore', 'protect', 'icy-wind', 'endure', 'swagger', 'attract', 'sleep-talk', 'return', 'frustration', 'safeguard', 'hidden-power', 'twister', 'rain-dance', 'psych-up', 'whirlpool', 'hail', 'facade', 'secret-power', 'dive', 'air-cutter', 'silver-wind', 'signal-beam', 'bounce', 'water-pulse', 'brine', 'natural-gift', 'tailwind', 'u-turn', 'payback', 'aqua-ring', 'aqua-tail', 'giga-impact', 'defog', 'captivate', 'ominous-wind', 'soak', 'round', 'scald', 'confide'], 'name': 'lumineon', 'stats': {'hp': 69, 'attack': 69, 'defense': 76, 'special-attack': 69, 'special-defense': 86, 'speed': 91}, 'types': ['water'], 'weight': 240, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 20, 'gender_rate': 4, 'capture_rate': 75, 'color': 'blue', 'shape': 'fish', 'habitat': None, 'generation': 'generation-iv', 'growth_rate': 'slow-then-very-fast', 'egg_groups': ['water2'], 'names': {'ja-Hrkt': 'ネオラント', 'roomaji': 'Neolant', 'ko': '네오라이트', 'zh-Hant': '霓虹魚', 'fr': 'Luminéon', 'de': 'Lumineon', 'es': 'Lumineon', 'it': 'Lumineon', 'en': 'Lumineon', 'ja': 'ネオラント', 'zh-Hans': '霓虹鱼'}, 'genera': {'ja-Hrkt': 'ネオンポケモン', 'ko': '네온포켓몬', 'zh-Hant': '霓虹寶可夢', 'fr': 'Pokémon Néon', 'de': 'Neon', 'es': 'Pokémon Neón', 'it': 'Pokémon Neon', 'en': 'Neon Pokémon', 'ja': 'ネオンポケモン', 'zh-Hans': '霓虹宝可梦'}}
	public class SpecieLumineon : PokemonSpecie
	{
#nullable enable
		private static SpecieLumineon? _instance = null;
#nullable restore
        public static SpecieLumineon Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieLumineon();
                }
                return _instance;
            }
        }

		public SpecieLumineon() : base(
			"Lumineon",
			69, // HPs
			69, 76, // Attack & Defense
			69, 86, // Special Attack & Defense
			91			
		) {}
	}


	//Lumineon Pokemon Class
	public class Lumineon : Pokemon
	{

		public Lumineon(string nickname, int level)
		: base(
				457,
				SpecieLumineon.Instance, // Pokemon Specie
				nickname, level,
				Water.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Lumineon() : base(
			457,
			SpecieLumineon.Instance, // Pokemon Specie
			Water.Instance			
		) {}
	}
}