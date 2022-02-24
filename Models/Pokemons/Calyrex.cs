using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Calyrex Specie to store common natural stats of every {'abilities': ['unnerve'], 'base_experience': 250, 'height': 11, 'id': 898, 'moves': [], 'name': 'calyrex', 'stats': {'hp': 100, 'attack': 80, 'defense': 80, 'special-attack': 80, 'special-defense': 80, 'speed': 80}, 'types': ['psychic', 'grass'], 'weight': 77, 'is_baby': False, 'is_legendary': True, 'is_mythical': False, 'hatch_counter': 120, 'gender_rate': -1, 'capture_rate': 3, 'color': 'green', 'shape': 'humanoid', 'habitat': None, 'generation': 'generation-viii', 'growth_rate': 'slow', 'egg_groups': [], 'names': {'ja-Hrkt': 'バドレックス', 'ko': '버드렉스', 'zh-Hant': '蕾冠王', 'fr': 'Sylveroy', 'de': 'Coronospa', 'es': 'Calyrex', 'it': 'Calyrex', 'en': 'Calyrex', 'ja': 'バドレックス', 'zh-Hans': '蕾冠王'}, 'genera': {'ja-Hrkt': 'キングポケモン', 'ko': '킹포켓몬', 'zh-Hant': '國王寶可夢', 'fr': 'Pokémon Roi', 'de': 'König', 'es': 'Pokémon Rey', 'it': 'Pokémon Re', 'en': 'King Pokémon', 'ja': 'キングポケモン', 'zh-Hans': '国王宝可梦'}}
	public class SpecieCalyrex : PokemonSpecie
	{
#nullable enable
		private static SpecieCalyrex? _instance = null;
#nullable restore
        public static SpecieCalyrex Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieCalyrex();
                }
                return _instance;
            }
        }

		public SpecieCalyrex() : base(
			"Calyrex",
			100, // HPs
			80, 80, // Attack & Defense
			80, 80, // Special Attack & Defense
			80			
		) {}
	}


	//Calyrex Pokemon Class
	public class Calyrex : Pokemon
	{

		public Calyrex(string nickname, int level)
		: base(
				898,
				SpecieCalyrex.Instance, // Pokemon Specie
				nickname, level,
				Psychic.Instance, Grass.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Calyrex(int level)
		: base(
				898,
				SpecieCalyrex.Instance, // Pokemon Specie
				"Calyrex", level,
				Psychic.Instance, Grass.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Calyrex() : base(
			898,
			SpecieCalyrex.Instance, // Pokemon Specie
			Psychic.Instance, Grass.Instance			
		) {}
	}
}