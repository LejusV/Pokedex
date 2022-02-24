using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Cufant Specie to store common natural stats of every {'abilities': ['sheer-force', 'heavy-metal'], 'base_experience': 66, 'height': 12, 'id': 878, 'moves': [], 'name': 'cufant', 'stats': {'hp': 72, 'attack': 80, 'defense': 49, 'special-attack': 40, 'special-defense': 49, 'speed': 40}, 'types': ['steel'], 'weight': 1000, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 25, 'gender_rate': 4, 'capture_rate': 190, 'color': 'yellow', 'shape': 'quadruped', 'habitat': None, 'generation': 'generation-viii', 'growth_rate': 'medium', 'egg_groups': [], 'names': {'ja-Hrkt': 'ゾウドウ', 'ko': '끼리동', 'zh-Hant': '銅象', 'fr': 'Charibari', 'de': 'Kupfanti', 'es': 'Cufant', 'it': 'Cufant', 'en': 'Cufant', 'ja': 'ゾウドウ', 'zh-Hans': '铜象'}, 'genera': {'ja-Hrkt': 'どうぞうポケモン', 'ko': '동상포켓몬', 'zh-Hant': '像銅寶可夢', 'fr': 'Pokémon Pachycuivre', 'de': 'Kupferfant', 'es': 'Pokémon Broncefante', 'it': 'Pokémon Bronzofante', 'en': 'Copperderm Pokémon', 'ja': 'どうぞうポケモン', 'zh-Hans': '像铜宝可梦'}}
	public class SpecieCufant : PokemonSpecie
	{
#nullable enable
		private static SpecieCufant? _instance = null;
#nullable restore
        public static SpecieCufant Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieCufant();
                }
                return _instance;
            }
        }

		public SpecieCufant() : base(
			"Cufant",
			72, // HPs
			80, 49, // Attack & Defense
			40, 49, // Special Attack & Defense
			40			
		) {}
	}


	//Cufant Pokemon Class
	public class Cufant : Pokemon
	{

		public Cufant(string nickname, int level)
		: base(
				878,
				SpecieCufant.Instance, // Pokemon Specie
				nickname, level,
				Steel.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Cufant(int level)
		: base(
				878,
				SpecieCufant.Instance, // Pokemon Specie
				"Cufant", level,
				Steel.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Cufant() : base(
			878,
			SpecieCufant.Instance, // Pokemon Specie
			Steel.Instance			
		) {}
	}
}