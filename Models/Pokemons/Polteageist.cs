using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Polteageist Specie to store common natural stats of every {'abilities': ['weak-armor', 'cursed-body'], 'base_experience': 178, 'height': 2, 'id': 855, 'moves': [], 'name': 'polteageist', 'stats': {'hp': 60, 'attack': 65, 'defense': 65, 'special-attack': 134, 'special-defense': 114, 'speed': 70}, 'types': ['ghost'], 'weight': 4, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 20, 'gender_rate': -1, 'capture_rate': 60, 'color': 'purple', 'shape': 'ball', 'habitat': None, 'generation': 'generation-viii', 'growth_rate': 'medium', 'egg_groups': [], 'names': {'ja-Hrkt': 'ポットデス', 'ko': '포트데스', 'zh-Hant': '怖思壺', 'fr': 'Polthégeist', 'de': 'Mortipot', 'es': 'Polteageist', 'it': 'Polteageist', 'en': 'Polteageist', 'ja': 'ポットデス', 'zh-Hans': '怖思壶'}, 'genera': {'ja-Hrkt': 'こうちゃポケモン', 'ko': '홍차포켓몬', 'zh-Hant': '紅茶寶可夢', 'fr': 'Pokémon Thé Noir', 'de': 'Schwarztee', 'es': 'Pokémon Té', 'it': 'Pokémon Tè', 'en': 'Black Tea Pokémon', 'ja': 'こうちゃポケモン', 'zh-Hans': '红茶宝可梦'}}
	public class SpeciePolteageist : PokemonSpecie
	{
#nullable enable
		private static SpeciePolteageist? _instance = null;
#nullable restore
        public static SpeciePolteageist Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciePolteageist();
                }
                return _instance;
            }
        }

		public SpeciePolteageist() : base(
			"Polteageist",
			60, // HPs
			65, 65, // Attack & Defense
			134, 114, // Special Attack & Defense
			70			
		) {}
	}


	//Polteageist Pokemon Class
	public class Polteageist : Pokemon
	{

		public Polteageist(string nickname, int level)
		: base(
				855,
				SpeciePolteageist.Instance, // Pokemon Specie
				nickname, level,
				Ghost.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Polteageist(int level)
		: base(
				855,
				SpeciePolteageist.Instance, // Pokemon Specie
				"Polteageist", level,
				Ghost.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Polteageist() : base(
			855,
			SpeciePolteageist.Instance, // Pokemon Specie
			Ghost.Instance			
		) {}
	}
}