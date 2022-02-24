using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Silcoon Specie to store common natural stats of every {'abilities': ['shed-skin'], 'base_experience': 72, 'height': 6, 'id': 266, 'moves': ['string-shot', 'harden', 'iron-defense', 'bug-bite', 'electroweb'], 'name': 'silcoon', 'stats': {'hp': 50, 'attack': 35, 'defense': 55, 'special-attack': 25, 'special-defense': 25, 'speed': 15}, 'types': ['bug'], 'weight': 100, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 15, 'gender_rate': 4, 'capture_rate': 120, 'color': 'white', 'shape': 'ball', 'habitat': 'forest', 'generation': 'generation-iii', 'growth_rate': 'medium', 'egg_groups': ['bug'], 'names': {'ja-Hrkt': 'カラサリス', 'roomaji': 'Karasalis', 'ko': '실쿤', 'zh-Hant': '甲殼繭', 'fr': 'Armulys', 'de': 'Schaloko', 'es': 'Silcoon', 'it': 'Silcoon', 'en': 'Silcoon', 'ja': 'カラサリス', 'zh-Hans': '甲壳茧'}, 'genera': {'ja-Hrkt': 'さなぎポケモン', 'ko': '번데기포켓몬', 'zh-Hant': '蛹寶可夢', 'fr': 'Pokémon Cocon', 'de': 'Kokon', 'es': 'Pokémon Capullo', 'it': 'Pokémon Bozzolo', 'en': 'Cocoon Pokémon', 'ja': 'さなぎポケモン', 'zh-Hans': '蛹宝可梦'}}
	public class SpecieSilcoon : PokemonSpecie
	{
#nullable enable
		private static SpecieSilcoon? _instance = null;
#nullable restore
        public static SpecieSilcoon Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieSilcoon();
                }
                return _instance;
            }
        }

		public SpecieSilcoon() : base(
			"Silcoon",
			50, // HPs
			35, 55, // Attack & Defense
			25, 25, // Special Attack & Defense
			15			
		) {}
	}


	//Silcoon Pokemon Class
	public class Silcoon : Pokemon
	{

		public Silcoon(string nickname, int level)
		: base(
				266,
				SpecieSilcoon.Instance, // Pokemon Specie
				nickname, level,
				Bug.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Silcoon(int level)
		: base(
				266,
				SpecieSilcoon.Instance, // Pokemon Specie
				"Silcoon", level,
				Bug.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Silcoon() : base(
			266,
			SpecieSilcoon.Instance, // Pokemon Specie
			Bug.Instance			
		) {}
	}
}