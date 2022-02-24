using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Milcery Specie to store common natural stats of every {'abilities': ['sweet-veil', 'aroma-veil'], 'base_experience': 54, 'height': 2, 'id': 868, 'moves': [], 'name': 'milcery', 'stats': {'hp': 45, 'attack': 40, 'defense': 40, 'special-attack': 50, 'special-defense': 61, 'speed': 34}, 'types': ['fairy'], 'weight': 3, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 20, 'gender_rate': 8, 'capture_rate': 200, 'color': 'white', 'shape': 'ball', 'habitat': None, 'generation': 'generation-viii', 'growth_rate': 'medium', 'egg_groups': [], 'names': {'ja-Hrkt': 'マホミル', 'ko': '마빌크', 'zh-Hant': '小仙奶', 'fr': 'Crèmy', 'de': 'Hokumil', 'es': 'Milcery', 'it': 'Milcery', 'en': 'Milcery', 'ja': 'マホミル', 'zh-Hans': '小仙奶'}, 'genera': {'ja-Hrkt': 'クリームポケモン', 'ko': '크림포켓몬', 'zh-Hant': '鮮奶油寶可夢', 'fr': 'Pokémon Crème', 'de': 'Sahne', 'es': 'Pokémon Nata', 'it': 'Pokémon Pannafresca', 'en': 'Cream Pokémon', 'ja': 'クリームポケモン', 'zh-Hans': '鲜奶油宝可梦'}}
	public class SpecieMilcery : PokemonSpecie
	{
#nullable enable
		private static SpecieMilcery? _instance = null;
#nullable restore
        public static SpecieMilcery Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieMilcery();
                }
                return _instance;
            }
        }

		public SpecieMilcery() : base(
			"Milcery",
			45, // HPs
			40, 40, // Attack & Defense
			50, 61, // Special Attack & Defense
			34			
		) {}
	}


	//Milcery Pokemon Class
	public class Milcery : Pokemon
	{

		public Milcery(string nickname, int level)
		: base(
				868,
				SpecieMilcery.Instance, // Pokemon Specie
				nickname, level,
				Fairy.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Milcery(int level)
		: base(
				868,
				SpecieMilcery.Instance, // Pokemon Specie
				"Milcery", level,
				Fairy.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Milcery() : base(
			868,
			SpecieMilcery.Instance, // Pokemon Specie
			Fairy.Instance			
		) {}
	}
}