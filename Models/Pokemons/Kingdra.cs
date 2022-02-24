using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Kingdra Specie to store common natural stats of every {'abilities': ['swift-swim', 'sniper', 'damp'], 'base_experience': 243, 'height': 18, 'id': 230, 'moves': ['headbutt', 'body-slam', 'double-edge', 'leer', 'water-gun', 'hydro-pump', 'surf', 'ice-beam', 'blizzard', 'bubble-beam', 'hyper-beam', 'toxic', 'agility', 'mimic', 'double-team', 'smokescreen', 'focus-energy', 'waterfall', 'swift', 'bubble', 'rest', 'substitute', 'snore', 'curse', 'protect', 'icy-wind', 'outrage', 'endure', 'swagger', 'attract', 'sleep-talk', 'return', 'frustration', 'dragon-breath', 'hidden-power', 'twister', 'rain-dance', 'whirlpool', 'hail', 'facade', 'yawn', 'secret-power', 'dive', 'signal-beam', 'bounce', 'dragon-dance', 'water-pulse', 'brine', 'natural-gift', 'dragon-pulse', 'giga-impact', 'flash-cannon', 'draco-meteor', 'iron-head', 'captivate', 'round', 'scald', 'quash', 'confide'], 'name': 'kingdra', 'stats': {'hp': 75, 'attack': 95, 'defense': 95, 'special-attack': 95, 'special-defense': 95, 'speed': 85}, 'types': ['water', 'dragon'], 'weight': 1520, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 20, 'gender_rate': 4, 'capture_rate': 45, 'color': 'blue', 'shape': 'blob', 'habitat': 'sea', 'generation': 'generation-ii', 'growth_rate': 'medium', 'egg_groups': ['water1', 'dragon'], 'names': {'ja-Hrkt': 'キングドラ', 'roomaji': 'Kingdra', 'ko': '킹드라', 'zh-Hant': '刺龍王', 'fr': 'Hyporoi', 'de': 'Seedraking', 'es': 'Kingdra', 'it': 'Kingdra', 'en': 'Kingdra', 'ja': 'キングドラ', 'zh-Hans': '刺龙王'}, 'genera': {'ja-Hrkt': 'ドラゴンポケモン', 'ko': '드래곤포켓몬', 'zh-Hant': '龍寶可夢', 'fr': 'Pokémon Dragon', 'de': 'Drache', 'es': 'Pokémon Dragón', 'it': 'Pokémon Drago', 'en': 'Dragon Pokémon', 'ja': 'ドラゴンポケモン', 'zh-Hans': '龙宝可梦'}}
	public class SpecieKingdra : PokemonSpecie
	{
#nullable enable
		private static SpecieKingdra? _instance = null;
#nullable restore
        public static SpecieKingdra Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieKingdra();
                }
                return _instance;
            }
        }

		public SpecieKingdra() : base(
			"Kingdra",
			75, // HPs
			95, 95, // Attack & Defense
			95, 95, // Special Attack & Defense
			85			
		) {}
	}


	//Kingdra Pokemon Class
	public class Kingdra : Pokemon
	{

		public Kingdra(string nickname, int level)
		: base(
				230,
				SpecieKingdra.Instance, // Pokemon Specie
				nickname, level,
				Water.Instance, Dragon.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Kingdra() : base(
			230,
			SpecieKingdra.Instance, // Pokemon Specie
			Water.Instance, Dragon.Instance			
		) {}
	}
}