using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Nickit Specie to store common natural stats of every {'abilities': ['run-away', 'unburden', 'stakeout'], 'base_experience': 49, 'height': 6, 'id': 827, 'moves': [], 'name': 'nickit', 'stats': {'hp': 40, 'attack': 28, 'defense': 28, 'special-attack': 47, 'special-defense': 52, 'speed': 50}, 'types': ['dark'], 'weight': 89, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 15, 'gender_rate': 4, 'capture_rate': 255, 'color': 'brown', 'shape': 'quadruped', 'habitat': None, 'generation': 'generation-viii', 'growth_rate': 'fast', 'egg_groups': [], 'names': {'ja-Hrkt': 'クスネ', 'ko': '훔처우', 'zh-Hant': '偷兒狐', 'fr': 'Goupilou', 'de': 'Kleptifux', 'es': 'Nickit', 'it': 'Nickit', 'en': 'Nickit', 'ja': 'クスネ', 'zh-Hans': '偷儿狐'}, 'genera': {'ja-Hrkt': 'きつねポケモン', 'ko': '여우포켓몬', 'zh-Hant': '狐狸寶可夢', 'fr': 'Pokémon Renard', 'de': 'Fuchs', 'es': 'Pokémon Zorro', 'it': 'Pokémon Volpe', 'en': 'Fox Pokémon', 'ja': 'きつねポケモン', 'zh-Hans': '狐狸宝可梦'}}
	public class SpecieNickit : PokemonSpecie
	{
#nullable enable
		private static SpecieNickit? _instance = null;
#nullable restore
        public static SpecieNickit Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieNickit();
                }
                return _instance;
            }
        }

		public SpecieNickit() : base(
			"Nickit",
			40, // HPs
			28, 28, // Attack & Defense
			47, 52, // Special Attack & Defense
			50			
		) {}
	}


	//Nickit Pokemon Class
	public class Nickit : Pokemon
	{

		public Nickit(string nickname, int level)
		: base(
				827,
				SpecieNickit.Instance, // Pokemon Specie
				nickname, level,
				Dark.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Nickit(int level)
		: base(
				827,
				SpecieNickit.Instance, // Pokemon Specie
				"Nickit", level,
				Dark.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Nickit() : base(
			827,
			SpecieNickit.Instance, // Pokemon Specie
			Dark.Instance			
		) {}
	}
}