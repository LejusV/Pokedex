using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Horsea Specie to store common natural stats of every {'abilities': ['swift-swim', 'sniper', 'damp'], 'base_experience': 59, 'height': 4, 'id': 116, 'moves': ['razor-wind', 'headbutt', 'take-down', 'double-edge', 'leer', 'disable', 'water-gun', 'hydro-pump', 'surf', 'ice-beam', 'blizzard', 'bubble-beam', 'aurora-beam', 'dragon-rage', 'toxic', 'agility', 'rage', 'mimic', 'double-team', 'smokescreen', 'focus-energy', 'bide', 'waterfall', 'swift', 'skull-bash', 'bubble', 'splash', 'rest', 'substitute', 'snore', 'curse', 'flail', 'protect', 'octazooka', 'icy-wind', 'outrage', 'endure', 'swagger', 'attract', 'sleep-talk', 'return', 'frustration', 'dragon-breath', 'hidden-power', 'twister', 'rain-dance', 'whirlpool', 'hail', 'facade', 'secret-power', 'dive', 'signal-beam', 'muddy-water', 'bounce', 'dragon-dance', 'water-pulse', 'brine', 'natural-gift', 'dragon-pulse', 'flash-cannon', 'captivate', 'round', 'clear-smog', 'scald', 'confide'], 'name': 'horsea', 'stats': {'hp': 30, 'attack': 40, 'defense': 70, 'special-attack': 70, 'special-defense': 25, 'speed': 60}, 'types': ['water'], 'weight': 80, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 20, 'gender_rate': 4, 'capture_rate': 225, 'color': 'blue', 'shape': 'blob', 'habitat': 'sea', 'generation': 'generation-i', 'growth_rate': 'medium', 'egg_groups': ['water1', 'dragon'], 'names': {'ja-Hrkt': 'タッツー', 'roomaji': 'Tattu', 'ko': '쏘드라', 'zh-Hant': '墨海馬', 'fr': 'Hypotrempe', 'de': 'Seeper', 'es': 'Horsea', 'it': 'Horsea', 'en': 'Horsea', 'ja': 'タッツー', 'zh-Hans': '墨海马'}, 'genera': {'ja-Hrkt': 'ドラゴンポケモン', 'ko': '드래곤포켓몬', 'zh-Hant': '龍寶可夢', 'fr': 'Pokémon Dragon', 'de': 'Drache', 'es': 'Pokémon Dragón', 'it': 'Pokémon Drago', 'en': 'Dragon Pokémon', 'ja': 'ドラゴンポケモン', 'zh-Hans': '龙宝可梦'}}
	public class SpecieHorsea : PokemonSpecie
	{
#nullable enable
		private static SpecieHorsea? _instance = null;
#nullable restore
        public static SpecieHorsea Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieHorsea();
                }
                return _instance;
            }
        }

		public SpecieHorsea() : base(
			"Horsea",
			30, // HPs
			40, 70, // Attack & Defense
			70, 25, // Special Attack & Defense
			60			
		) {}
	}


	//Horsea Pokemon Class
	public class Horsea : Pokemon
	{

		public Horsea(string nickname, int level)
		: base(
				116,
				SpecieHorsea.Instance, // Pokemon Specie
				nickname, level,
				Water.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Horsea() : base(
			116,
			SpecieHorsea.Instance, // Pokemon Specie
			Water.Instance			
		) {}
	}
}