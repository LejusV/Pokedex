using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Stonjourner Specie to store common natural stats of every {'abilities': ['power-spot'], 'base_experience': 165, 'height': 25, 'id': 874, 'moves': [], 'name': 'stonjourner', 'stats': {'hp': 100, 'attack': 125, 'defense': 135, 'special-attack': 20, 'special-defense': 20, 'speed': 70}, 'types': ['rock'], 'weight': 5200, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 25, 'gender_rate': 4, 'capture_rate': 60, 'color': 'gray', 'shape': 'legs', 'habitat': None, 'generation': 'generation-viii', 'growth_rate': 'slow', 'egg_groups': [], 'names': {'ja-Hrkt': 'イシヘンジン', 'ko': '돌헨진', 'zh-Hant': '巨石丁', 'fr': 'Dolman', 'de': 'Humanolith', 'es': 'Stonjourner', 'it': 'Stonjourner', 'en': 'Stonjourner', 'ja': 'イシヘンジン', 'zh-Hans': '巨石丁'}, 'genera': {'ja-Hrkt': 'きょせきポケモン', 'ko': '거석포켓몬', 'zh-Hant': '巨石寶可夢', 'fr': 'Pokémon Mégalithe', 'de': 'Megalith', 'es': 'Pokémon Megalito', 'it': 'Pokémon Megalito', 'en': 'Big Rock Pokémon', 'ja': 'きょせきポケモン', 'zh-Hans': '巨石宝可梦'}}
	public class SpecieStonjourner : PokemonSpecie
	{
#nullable enable
		private static SpecieStonjourner? _instance = null;
#nullable restore
        public static SpecieStonjourner Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieStonjourner();
                }
                return _instance;
            }
        }

		public SpecieStonjourner() : base(
			"Stonjourner",
			100, // HPs
			125, 135, // Attack & Defense
			20, 20, // Special Attack & Defense
			70			
		) {}
	}


	//Stonjourner Pokemon Class
	public class Stonjourner : Pokemon
	{

		public Stonjourner(string nickname, int level)
		: base(
				874,
				SpecieStonjourner.Instance, // Pokemon Specie
				nickname, level,
				Rock.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Stonjourner(int level)
		: base(
				874,
				SpecieStonjourner.Instance, // Pokemon Specie
				"Stonjourner", level,
				Rock.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Stonjourner() : base(
			874,
			SpecieStonjourner.Instance, // Pokemon Specie
			Rock.Instance			
		) {}
	}
}