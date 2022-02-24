using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Wooloo Specie to store common natural stats of every {'abilities': ['fluffy', 'run-away', 'bulletproof'], 'base_experience': 122, 'height': 6, 'id': 831, 'moves': [], 'name': 'wooloo', 'stats': {'hp': 42, 'attack': 40, 'defense': 55, 'special-attack': 40, 'special-defense': 45, 'speed': 48}, 'types': ['normal'], 'weight': 60, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 15, 'gender_rate': 4, 'capture_rate': 255, 'color': 'white', 'shape': 'quadruped', 'habitat': None, 'generation': 'generation-viii', 'growth_rate': 'medium', 'egg_groups': [], 'names': {'ja-Hrkt': 'ウールー', 'ko': '우르', 'zh-Hant': '毛辮羊', 'fr': 'Moumouton', 'de': 'Wolly', 'es': 'Wooloo', 'it': 'Wooloo', 'en': 'Wooloo', 'ja': 'ウールー', 'zh-Hans': '毛辫羊'}, 'genera': {'ja-Hrkt': 'ひつじポケモン', 'ko': '양포켓몬', 'zh-Hant': '綿羊寶可夢', 'fr': 'Pokémon Mouton', 'de': 'Schaf', 'es': 'Pokémon Oveja', 'it': 'Pokémon Pecora', 'en': 'Sheep Pokémon', 'ja': 'ひつじポケモン', 'zh-Hans': '绵羊宝可梦'}}
	public class SpecieWooloo : PokemonSpecie
	{
#nullable enable
		private static SpecieWooloo? _instance = null;
#nullable restore
        public static SpecieWooloo Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieWooloo();
                }
                return _instance;
            }
        }

		public SpecieWooloo() : base(
			"Wooloo",
			42, // HPs
			40, 55, // Attack & Defense
			40, 45, // Special Attack & Defense
			48			
		) {}
	}


	//Wooloo Pokemon Class
	public class Wooloo : Pokemon
	{

		public Wooloo(string nickname, int level)
		: base(
				831,
				SpecieWooloo.Instance, // Pokemon Specie
				nickname, level,
				Normal.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Wooloo(int level)
		: base(
				831,
				SpecieWooloo.Instance, // Pokemon Specie
				"Wooloo", level,
				Normal.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Wooloo() : base(
			831,
			SpecieWooloo.Instance, // Pokemon Specie
			Normal.Instance			
		) {}
	}
}