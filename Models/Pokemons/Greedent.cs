using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Greedent Specie to store common natural stats of every {'abilities': ['cheek-pouch', 'gluttony'], 'base_experience': 161, 'height': 6, 'id': 820, 'moves': [], 'name': 'greedent', 'stats': {'hp': 120, 'attack': 95, 'defense': 95, 'special-attack': 55, 'special-defense': 75, 'speed': 20}, 'types': ['normal'], 'weight': 60, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 20, 'gender_rate': 4, 'capture_rate': 90, 'color': 'brown', 'shape': 'upright', 'habitat': None, 'generation': 'generation-viii', 'growth_rate': 'medium', 'egg_groups': [], 'names': {'ja-Hrkt': 'ヨクバリス', 'ko': '요씽리스', 'zh-Hant': '藏飽栗鼠', 'fr': 'Rongrigou', 'de': 'Schlaraffel', 'es': 'Greedent', 'it': 'Greedent', 'en': 'Greedent', 'ja': 'ヨクバリス', 'zh-Hans': '藏饱栗鼠'}, 'genera': {'ja-Hrkt': 'よくばりポケモン', 'ko': '욕심쟁이포켓몬', 'zh-Hant': '貪慾寶可夢', 'fr': 'Pokémon Goulu', 'de': 'Gierschlund', 'es': 'Pokémon Avaricia', 'it': 'Pokémon Ingordigia', 'en': 'Greedy Pokémon', 'ja': 'よくばりポケモン', 'zh-Hans': '贪欲宝可梦'}}
	public class SpecieGreedent : PokemonSpecie
	{
#nullable enable
		private static SpecieGreedent? _instance = null;
#nullable restore
        public static SpecieGreedent Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieGreedent();
                }
                return _instance;
            }
        }

		public SpecieGreedent() : base(
			"Greedent",
			120, // HPs
			95, 95, // Attack & Defense
			55, 75, // Special Attack & Defense
			20			
		) {}
	}


	//Greedent Pokemon Class
	public class Greedent : Pokemon
	{

		public Greedent(string nickname, int level)
		: base(
				820,
				SpecieGreedent.Instance, // Pokemon Specie
				nickname, level,
				Normal.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Greedent(int level)
		: base(
				820,
				SpecieGreedent.Instance, // Pokemon Specie
				"Greedent", level,
				Normal.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Greedent() : base(
			820,
			SpecieGreedent.Instance, // Pokemon Specie
			Normal.Instance			
		) {}
	}
}