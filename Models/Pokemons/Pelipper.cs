using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Pelipper Specie to store common natural stats of every {'abilities': ['keen-eye', 'drizzle', 'rain-dish'], 'base_experience': 154, 'height': 12, 'id': 279, 'moves': ['wing-attack', 'fly', 'double-edge', 'growl', 'supersonic', 'mist', 'water-gun', 'hydro-pump', 'surf', 'ice-beam', 'blizzard', 'hyper-beam', 'toxic', 'mimic', 'double-team', 'swift', 'sky-attack', 'rest', 'substitute', 'thief', 'snore', 'protect', 'mud-slap', 'icy-wind', 'endure', 'swagger', 'steel-wing', 'attract', 'sleep-talk', 'return', 'frustration', 'hidden-power', 'twister', 'rain-dance', 'whirlpool', 'uproar', 'stockpile', 'spit-up', 'swallow', 'hail', 'facade', 'knock-off', 'secret-power', 'air-cutter', 'aerial-ace', 'water-sport', 'shock-wave', 'water-pulse', 'roost', 'brine', 'natural-gift', 'pluck', 'tailwind', 'u-turn', 'payback', 'fling', 'seed-bomb', 'giga-impact', 'defog', 'gunk-shot', 'captivate', 'ominous-wind', 'soak', 'round', 'echoed-voice', 'scald', 'sky-drop', 'hurricane', 'confide'], 'name': 'pelipper', 'stats': {'hp': 60, 'attack': 50, 'defense': 100, 'special-attack': 95, 'special-defense': 70, 'speed': 65}, 'types': ['water', 'flying'], 'weight': 280, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 20, 'gender_rate': 4, 'capture_rate': 45, 'color': 'yellow', 'shape': 'wings', 'habitat': 'sea', 'generation': 'generation-iii', 'growth_rate': 'medium', 'egg_groups': ['water1', 'flying'], 'names': {'ja-Hrkt': 'ペリッパー', 'roomaji': 'Pelipper', 'ko': '패리퍼', 'zh-Hant': '大嘴鷗', 'fr': 'Bekipan', 'de': 'Pelipper', 'es': 'Pelipper', 'it': 'Pelipper', 'en': 'Pelipper', 'ja': 'ペリッパー', 'zh-Hans': '大嘴鸥'}, 'genera': {'ja-Hrkt': 'みずどりポケモン', 'ko': '물새포켓몬', 'zh-Hant': '水鳥寶可夢', 'fr': 'Pokémon Oiseaudo', 'de': 'Wasservogel', 'es': 'Pokémon Ave Agua', 'it': 'Pokémon Alacquatico', 'en': 'Water Bird Pokémon', 'ja': 'みずどりポケモン', 'zh-Hans': '水鸟宝可梦'}}
	public class SpeciePelipper : PokemonSpecie
	{
#nullable enable
		private static SpeciePelipper? _instance = null;
#nullable restore
        public static SpeciePelipper Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciePelipper();
                }
                return _instance;
            }
        }

		public SpeciePelipper() : base(
			"Pelipper",
			60, // HPs
			50, 100, // Attack & Defense
			95, 70, // Special Attack & Defense
			65			
		) {}
	}


	//Pelipper Pokemon Class
	public class Pelipper : Pokemon
	{

		public Pelipper(string nickname, int level)
		: base(
				279,
				SpeciePelipper.Instance, // Pokemon Specie
				nickname, level,
				Water.Instance, Flying.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Pelipper() : base(
			279,
			SpeciePelipper.Instance, // Pokemon Specie
			Water.Instance, Flying.Instance			
		) {}
	}
}