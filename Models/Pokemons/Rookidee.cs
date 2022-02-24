using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Rookidee Specie to store common natural stats of every {'abilities': ['keen-eye', 'unnerve', 'big-pecks'], 'base_experience': 49, 'height': 2, 'id': 821, 'moves': [], 'name': 'rookidee', 'stats': {'hp': 38, 'attack': 47, 'defense': 35, 'special-attack': 33, 'special-defense': 35, 'speed': 57}, 'types': ['flying'], 'weight': 18, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 15, 'gender_rate': 4, 'capture_rate': 255, 'color': 'blue', 'shape': 'wings', 'habitat': None, 'generation': 'generation-viii', 'growth_rate': 'medium-slow', 'egg_groups': [], 'names': {'ja-Hrkt': 'ココガラ', 'ko': '파라꼬', 'zh-Hant': '稚山雀', 'fr': 'Minisange', 'de': 'Meikro', 'es': 'Rookidee', 'it': 'Rookidee', 'en': 'Rookidee', 'ja': 'ココガラ', 'zh-Hans': '稚山雀'}, 'genera': {'ja-Hrkt': 'ことりポケモン', 'ko': '아기새포켓몬', 'zh-Hant': '小鳥寶可夢', 'fr': 'Pokémon Minoiseau', 'de': 'Kleinvogel', 'es': 'Pokémon Pajarito', 'it': 'Pokémon Uccellino', 'en': 'Tiny Bird Pokémon', 'ja': 'ことりポケモン', 'zh-Hans': '小鸟宝可梦'}}
	public class SpecieRookidee : PokemonSpecie
	{
#nullable enable
		private static SpecieRookidee? _instance = null;
#nullable restore
        public static SpecieRookidee Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieRookidee();
                }
                return _instance;
            }
        }

		public SpecieRookidee() : base(
			"Rookidee",
			38, // HPs
			47, 35, // Attack & Defense
			33, 35, // Special Attack & Defense
			57			
		) {}
	}


	//Rookidee Pokemon Class
	public class Rookidee : Pokemon
	{

		public Rookidee(string nickname, int level)
		: base(
				821,
				SpecieRookidee.Instance, // Pokemon Specie
				nickname, level,
				Flying.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Rookidee(int level)
		: base(
				821,
				SpecieRookidee.Instance, // Pokemon Specie
				"Rookidee", level,
				Flying.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Rookidee() : base(
			821,
			SpecieRookidee.Instance, // Pokemon Specie
			Flying.Instance			
		) {}
	}
}