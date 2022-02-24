using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Alcremie Specie to store common natural stats of every {'abilities': ['sweet-veil', 'aroma-veil'], 'base_experience': 173, 'height': 3, 'id': 869, 'moves': [], 'name': 'alcremie', 'stats': {'hp': 65, 'attack': 60, 'defense': 75, 'special-attack': 110, 'special-defense': 121, 'speed': 64}, 'types': ['fairy'], 'weight': 5, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 20, 'gender_rate': 8, 'capture_rate': 100, 'color': 'white', 'shape': 'blob', 'habitat': None, 'generation': 'generation-viii', 'growth_rate': 'medium', 'egg_groups': [], 'names': {'ja-Hrkt': 'マホイップ', 'ko': '마휘핑', 'zh-Hant': '霜奶仙', 'fr': 'Charmilly', 'de': 'Pokusan', 'es': 'Alcremie', 'it': 'Alcremie', 'en': 'Alcremie', 'ja': 'マホイップ', 'zh-Hans': '霜奶仙'}, 'genera': {'ja-Hrkt': 'クリームポケモン', 'ko': '크림포켓몬', 'zh-Hant': '鮮奶油寶可夢', 'fr': 'Pokémon Crème', 'de': 'Sahne', 'es': 'Pokémon Nata', 'it': 'Pokémon Pannafresca', 'en': 'Cream Pokémon', 'ja': 'クリームポケモン', 'zh-Hans': '鲜奶油宝可梦'}}
	public class SpecieAlcremie : PokemonSpecie
	{
#nullable enable
		private static SpecieAlcremie? _instance = null;
#nullable restore
        public static SpecieAlcremie Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieAlcremie();
                }
                return _instance;
            }
        }

		public SpecieAlcremie() : base(
			"Alcremie",
			65, // HPs
			60, 75, // Attack & Defense
			110, 121, // Special Attack & Defense
			64			
		) {}
	}


	//Alcremie Pokemon Class
	public class Alcremie : Pokemon
	{

		public Alcremie(string nickname, int level)
		: base(
				869,
				SpecieAlcremie.Instance, // Pokemon Specie
				nickname, level,
				Fairy.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Alcremie(int level)
		: base(
				869,
				SpecieAlcremie.Instance, // Pokemon Specie
				"Alcremie", level,
				Fairy.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Alcremie() : base(
			869,
			SpecieAlcremie.Instance, // Pokemon Specie
			Fairy.Instance			
		) {}
	}
}