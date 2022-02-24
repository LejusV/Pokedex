using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Ducklett Specie to store common natural stats of every {'abilities': ['keen-eye', 'big-pecks', 'hydration'], 'base_experience': 61, 'height': 5, 'id': 580, 'moves': ['gust', 'wing-attack', 'fly', 'water-gun', 'surf', 'ice-beam', 'bubble-beam', 'toxic', 'double-team', 'mirror-move', 'rest', 'substitute', 'snore', 'protect', 'icy-wind', 'swagger', 'steel-wing', 'attract', 'sleep-talk', 'return', 'frustration', 'hidden-power', 'rain-dance', 'uproar', 'hail', 'facade', 'endeavor', 'secret-power', 'dive', 'feather-dance', 'mud-sport', 'air-cutter', 'aerial-ace', 'water-sport', 'water-pulse', 'roost', 'brine', 'pluck', 'tailwind', 'lucky-chant', 'me-first', 'aqua-ring', 'air-slash', 'brave-bird', 'defog', 'aqua-jet', 'round', 'scald', 'hurricane', 'confide'], 'name': 'ducklett', 'stats': {'hp': 62, 'attack': 44, 'defense': 50, 'special-attack': 44, 'special-defense': 50, 'speed': 55}, 'types': ['water', 'flying'], 'weight': 55, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 20, 'gender_rate': 4, 'capture_rate': 190, 'color': 'blue', 'shape': 'wings', 'habitat': None, 'generation': 'generation-v', 'growth_rate': 'medium', 'egg_groups': ['water1', 'flying'], 'names': {'ja-Hrkt': 'コアルヒー', 'ko': '꼬지보리', 'zh-Hant': '鴨寶寶', 'fr': 'Couaneton', 'de': 'Piccolente', 'es': 'Ducklett', 'it': 'Ducklett', 'en': 'Ducklett', 'ja': 'コアルヒー', 'zh-Hans': '鸭宝宝'}, 'genera': {'ja-Hrkt': 'みずどりポケモン', 'ko': '물새포켓몬', 'zh-Hant': '水鳥寶可夢', 'fr': 'Pokémon Oiseaudo', 'de': 'Wasservogel', 'es': 'Pokémon Ave Agua', 'it': 'Pokémon Alacquatico', 'en': 'Water Bird Pokémon', 'ja': 'みずどりポケモン', 'zh-Hans': '水鸟宝可梦'}}
	public class SpecieDucklett : PokemonSpecie
	{
#nullable enable
		private static SpecieDucklett? _instance = null;
#nullable restore
        public static SpecieDucklett Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieDucklett();
                }
                return _instance;
            }
        }

		public SpecieDucklett() : base(
			"Ducklett",
			62, // HPs
			44, 50, // Attack & Defense
			44, 50, // Special Attack & Defense
			55			
		) {}
	}


	//Ducklett Pokemon Class
	public class Ducklett : Pokemon
	{

		public Ducklett(string nickname, int level)
		: base(
				580,
				SpecieDucklett.Instance, // Pokemon Specie
				nickname, level,
				Water.Instance, Flying.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Ducklett(int level)
		: base(
				580,
				SpecieDucklett.Instance, // Pokemon Specie
				"Ducklett", level,
				Water.Instance, Flying.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Ducklett() : base(
			580,
			SpecieDucklett.Instance, // Pokemon Specie
			Water.Instance, Flying.Instance			
		) {}
	}
}