using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Swanna Specie to store common natural stats of every {'abilities': ['keen-eye', 'big-pecks', 'hydration'], 'base_experience': 166, 'height': 13, 'id': 581, 'moves': ['wing-attack', 'fly', 'water-gun', 'surf', 'ice-beam', 'bubble-beam', 'hyper-beam', 'toxic', 'double-team', 'sky-attack', 'rest', 'substitute', 'snore', 'protect', 'icy-wind', 'swagger', 'steel-wing', 'attract', 'sleep-talk', 'return', 'frustration', 'hidden-power', 'rain-dance', 'uproar', 'hail', 'facade', 'endeavor', 'secret-power', 'dive', 'feather-dance', 'aerial-ace', 'water-sport', 'water-pulse', 'roost', 'pluck', 'tailwind', 'aqua-ring', 'air-slash', 'brave-bird', 'giga-impact', 'defog', 'round', 'scald', 'hurricane', 'confide'], 'name': 'swanna', 'stats': {'hp': 75, 'attack': 87, 'defense': 63, 'special-attack': 87, 'special-defense': 63, 'speed': 98}, 'types': ['water', 'flying'], 'weight': 242, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 20, 'gender_rate': 4, 'capture_rate': 45, 'color': 'white', 'shape': 'wings', 'habitat': None, 'generation': 'generation-v', 'growth_rate': 'medium', 'egg_groups': ['water1', 'flying'], 'names': {'ja-Hrkt': 'スワンナ', 'ko': '스완나', 'zh-Hant': '舞天鵝', 'fr': 'Lakmécygne', 'de': 'Swaroness', 'es': 'Swanna', 'it': 'Swanna', 'en': 'Swanna', 'ja': 'スワンナ', 'zh-Hans': '舞天鹅'}, 'genera': {'ja-Hrkt': 'しらとりポケモン', 'ko': '백조포켓몬', 'zh-Hant': '白鳥寶可夢', 'fr': 'Pokémon Cygne', 'de': 'Schwan', 'es': 'Pokémon Cisne', 'it': 'Pokémon Biancuccello', 'en': 'White Bird Pokémon', 'ja': 'しらとりポケモン', 'zh-Hans': '白鸟宝可梦'}}
	public class SpecieSwanna : PokemonSpecie
	{
#nullable enable
		private static SpecieSwanna? _instance = null;
#nullable restore
        public static SpecieSwanna Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieSwanna();
                }
                return _instance;
            }
        }

		public SpecieSwanna() : base(
			"Swanna",
			75, // HPs
			87, 63, // Attack & Defense
			87, 63, // Special Attack & Defense
			98			
		) {}
	}


	//Swanna Pokemon Class
	public class Swanna : Pokemon
	{

		public Swanna(string nickname, int level)
		: base(
				581,
				SpecieSwanna.Instance, // Pokemon Specie
				nickname, level,
				Water.Instance, Flying.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Swanna() : base(
			581,
			SpecieSwanna.Instance, // Pokemon Specie
			Water.Instance, Flying.Instance			
		) {}
	}
}