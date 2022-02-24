using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Cinderace Specie to store common natural stats of every {'abilities': ['blaze', 'libero'], 'base_experience': 265, 'height': 14, 'id': 815, 'moves': [], 'name': 'cinderace', 'stats': {'hp': 80, 'attack': 116, 'defense': 75, 'special-attack': 65, 'special-defense': 75, 'speed': 119}, 'types': ['fire'], 'weight': 330, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 20, 'gender_rate': 1, 'capture_rate': 45, 'color': 'white', 'shape': 'upright', 'habitat': None, 'generation': 'generation-viii', 'growth_rate': 'medium-slow', 'egg_groups': [], 'names': {'ja-Hrkt': 'エースバーン', 'ko': '에이스번', 'zh-Hant': '閃焰王牌', 'fr': 'Pyrobut', 'de': 'Liberlo', 'es': 'Cinderace', 'it': 'Cinderace', 'en': 'Cinderace', 'ja': 'エースバーン', 'zh-Hans': '闪焰王牌'}, 'genera': {'ja-Hrkt': 'ストライカーポケモン', 'ko': '스트라이커포켓몬', 'zh-Hant': '前鋒寶可夢', 'fr': 'Pokémon Buteur', 'de': 'Torschütze', 'es': 'Pokémon Delantero', 'it': 'Pokémon Cannoniere', 'en': 'Striker Pokémon', 'ja': 'ストライカーポケモン', 'zh-Hans': '前锋宝可梦'}}
	public class SpecieCinderace : PokemonSpecie
	{
#nullable enable
		private static SpecieCinderace? _instance = null;
#nullable restore
        public static SpecieCinderace Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieCinderace();
                }
                return _instance;
            }
        }

		public SpecieCinderace() : base(
			"Cinderace",
			80, // HPs
			116, 75, // Attack & Defense
			65, 75, // Special Attack & Defense
			119			
		) {}
	}


	//Cinderace Pokemon Class
	public class Cinderace : Pokemon
	{

		public Cinderace(string nickname, int level)
		: base(
				815,
				SpecieCinderace.Instance, // Pokemon Specie
				nickname, level,
				Fire.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Cinderace(int level)
		: base(
				815,
				SpecieCinderace.Instance, // Pokemon Specie
				"Cinderace", level,
				Fire.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Cinderace() : base(
			815,
			SpecieCinderace.Instance, // Pokemon Specie
			Fire.Instance			
		) {}
	}
}