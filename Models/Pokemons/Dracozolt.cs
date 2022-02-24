using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Dracozolt Specie to store common natural stats of every {'abilities': ['volt-absorb', 'hustle', 'sand-rush'], 'base_experience': 177, 'height': 18, 'id': 880, 'moves': [], 'name': 'dracozolt', 'stats': {'hp': 90, 'attack': 100, 'defense': 90, 'special-attack': 80, 'special-defense': 70, 'speed': 75}, 'types': ['electric', 'dragon'], 'weight': 1900, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 35, 'gender_rate': -1, 'capture_rate': 45, 'color': 'green', 'shape': 'upright', 'habitat': None, 'generation': 'generation-viii', 'growth_rate': 'slow', 'egg_groups': [], 'names': {'ja-Hrkt': 'パッチラゴン', 'ko': '파치래곤', 'zh-Hant': '雷鳥龍', 'fr': 'Galvagon', 'de': 'Lectragon', 'es': 'Dracozolt', 'it': 'Dracozolt', 'en': 'Dracozolt', 'ja': 'パッチラゴン', 'zh-Hans': '雷鸟龙'}, 'genera': {'ja-Hrkt': 'かせきポケモン', 'ko': '화석포켓몬', 'zh-Hant': '化石寶可夢', 'fr': 'Pokémon Fossile', 'de': 'Fossil', 'es': 'Pokémon Fósil', 'it': 'Pokémon Fossile', 'en': 'Fossil Pokémon', 'ja': 'かせきポケモン', 'zh-Hans': '化石宝可梦'}}
	public class SpecieDracozolt : PokemonSpecie
	{
#nullable enable
		private static SpecieDracozolt? _instance = null;
#nullable restore
        public static SpecieDracozolt Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieDracozolt();
                }
                return _instance;
            }
        }

		public SpecieDracozolt() : base(
			"Dracozolt",
			90, // HPs
			100, 90, // Attack & Defense
			80, 70, // Special Attack & Defense
			75			
		) {}
	}


	//Dracozolt Pokemon Class
	public class Dracozolt : Pokemon
	{

		public Dracozolt(string nickname, int level)
		: base(
				880,
				SpecieDracozolt.Instance, // Pokemon Specie
				nickname, level,
				Electric.Instance, Dragon.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Dracozolt(int level)
		: base(
				880,
				SpecieDracozolt.Instance, // Pokemon Specie
				"Dracozolt", level,
				Electric.Instance, Dragon.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Dracozolt() : base(
			880,
			SpecieDracozolt.Instance, // Pokemon Specie
			Electric.Instance, Dragon.Instance			
		) {}
	}
}