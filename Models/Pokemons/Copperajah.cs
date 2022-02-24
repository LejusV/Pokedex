using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Copperajah Specie to store common natural stats of every {'abilities': ['sheer-force', 'heavy-metal'], 'base_experience': 175, 'height': 30, 'id': 879, 'moves': [], 'name': 'copperajah', 'stats': {'hp': 122, 'attack': 130, 'defense': 69, 'special-attack': 80, 'special-defense': 69, 'speed': 30}, 'types': ['steel'], 'weight': 6500, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 25, 'gender_rate': 4, 'capture_rate': 90, 'color': 'green', 'shape': 'quadruped', 'habitat': None, 'generation': 'generation-viii', 'growth_rate': 'medium', 'egg_groups': [], 'names': {'ja-Hrkt': 'ダイオウドウ', 'ko': '대왕끼리동', 'zh-Hant': '大王銅象', 'fr': 'Pachyradjah', 'de': 'Patinaraja', 'es': 'Copperajah', 'it': 'Copperajah', 'en': 'Copperajah', 'ja': 'ダイオウドウ', 'zh-Hans': '大王铜象'}, 'genera': {'ja-Hrkt': 'どうぞうポケモン', 'ko': '동상포켓몬', 'zh-Hant': '像銅寶可夢', 'fr': 'Pokémon Pachycuivre', 'de': 'Kupferfant', 'es': 'Pokémon Broncefante', 'it': 'Pokémon Bronzofante', 'en': 'Copperderm Pokémon', 'ja': 'どうぞうポケモン', 'zh-Hans': '像铜宝可梦'}}
	public class SpecieCopperajah : PokemonSpecie
	{
#nullable enable
		private static SpecieCopperajah? _instance = null;
#nullable restore
        public static SpecieCopperajah Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieCopperajah();
                }
                return _instance;
            }
        }

		public SpecieCopperajah() : base(
			"Copperajah",
			122, // HPs
			130, 69, // Attack & Defense
			80, 69, // Special Attack & Defense
			30			
		) {}
	}


	//Copperajah Pokemon Class
	public class Copperajah : Pokemon
	{

		public Copperajah(string nickname, int level)
		: base(
				879,
				SpecieCopperajah.Instance, // Pokemon Specie
				nickname, level,
				Steel.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Copperajah() : base(
			879,
			SpecieCopperajah.Instance, // Pokemon Specie
			Steel.Instance			
		) {}
	}
}