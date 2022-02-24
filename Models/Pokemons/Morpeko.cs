using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Morpeko Specie to store common natural stats of every {'abilities': ['hunger-switch'], 'base_experience': 153, 'height': 3, 'id': 877, 'moves': [], 'name': 'morpeko', 'stats': {'hp': 58, 'attack': 95, 'defense': 58, 'special-attack': 70, 'special-defense': 58, 'speed': 97}, 'types': ['electric', 'dark'], 'weight': 30, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 10, 'gender_rate': 4, 'capture_rate': 180, 'color': 'yellow', 'shape': 'humanoid', 'habitat': None, 'generation': 'generation-viii', 'growth_rate': 'medium', 'egg_groups': [], 'names': {'ja-Hrkt': 'モルペコ', 'ko': '모르페코', 'zh-Hant': '莫魯貝可', 'fr': 'Morpeko', 'de': 'Morpeko', 'es': 'Morpeko', 'it': 'Morpeko', 'en': 'Morpeko', 'ja': 'モルペコ', 'zh-Hans': '莫鲁贝可'}, 'genera': {'ja-Hrkt': 'にめんポケモン', 'ko': '양면포켓몬', 'zh-Hant': '雙面寶可夢', 'fr': 'Pokémon Volt Face', 'de': 'Alter Ego', 'es': 'Pokémon Dos Caras', 'it': 'Pokémon Doppiafaccia', 'en': 'Two-Sided Pokémon', 'ja': 'にめんポケモン', 'zh-Hans': '双面宝可梦'}}
	public class SpecieMorpeko : PokemonSpecie
	{
#nullable enable
		private static SpecieMorpeko? _instance = null;
#nullable restore
        public static SpecieMorpeko Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieMorpeko();
                }
                return _instance;
            }
        }

		public SpecieMorpeko() : base(
			"Morpeko",
			58, // HPs
			95, 58, // Attack & Defense
			70, 58, // Special Attack & Defense
			97			
		) {}
	}


	//Morpeko Pokemon Class
	public class Morpeko : Pokemon
	{

		public Morpeko(string nickname, int level)
		: base(
				877,
				SpecieMorpeko.Instance, // Pokemon Specie
				nickname, level,
				Electric.Instance, Dark.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Morpeko() : base(
			877,
			SpecieMorpeko.Instance, // Pokemon Specie
			Electric.Instance, Dark.Instance			
		) {}
	}
}