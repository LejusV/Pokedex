using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Metapod Specie to store common natural stats of every {'abilities': ['shed-skin'], 'base_experience': 72, 'height': 7, 'id': 11, 'moves': ['string-shot', 'harden', 'iron-defense', 'bug-bite', 'electroweb'], 'name': 'metapod', 'stats': {'hp': 50, 'attack': 20, 'defense': 55, 'special-attack': 25, 'special-defense': 25, 'speed': 30}, 'types': ['bug'], 'weight': 99, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 15, 'gender_rate': 4, 'capture_rate': 120, 'color': 'green', 'shape': 'squiggle', 'habitat': 'forest', 'generation': 'generation-i', 'growth_rate': 'medium', 'egg_groups': ['bug'], 'names': {'ja-Hrkt': 'トランセル', 'roomaji': 'Trancell', 'ko': '단데기', 'zh-Hant': '鐵甲蛹', 'fr': 'Chrysacier', 'de': 'Safcon', 'es': 'Metapod', 'it': 'Metapod', 'en': 'Metapod', 'ja': 'トランセル', 'zh-Hans': '铁甲蛹'}, 'genera': {'ja-Hrkt': 'さなぎポケモン', 'ko': '번데기포켓몬', 'zh-Hant': '蛹寶可夢', 'fr': 'Pokémon Cocon', 'de': 'Kokon', 'es': 'Pokémon Capullo', 'it': 'Pokémon Bozzolo', 'en': 'Cocoon Pokémon', 'ja': 'さなぎポケモン', 'zh-Hans': '蛹宝可梦'}}
	public class SpecieMetapod : PokemonSpecie
	{
#nullable enable
		private static SpecieMetapod? _instance = null;
#nullable restore
        public static SpecieMetapod Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieMetapod();
                }
                return _instance;
            }
        }

		public SpecieMetapod() : base(
			"Metapod",
			50, // HPs
			20, 55, // Attack & Defense
			25, 25, // Special Attack & Defense
			30			
		) {}
	}


	//Metapod Pokemon Class
	public class Metapod : Pokemon
	{

		public Metapod(string nickname, int level)
		: base(
				11,
				SpecieMetapod.Instance, // Pokemon Specie
				nickname, level,
				Bug.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Metapod(int level)
		: base(
				11,
				SpecieMetapod.Instance, // Pokemon Specie
				"Metapod", level,
				Bug.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Metapod() : base(
			11,
			SpecieMetapod.Instance, // Pokemon Specie
			Bug.Instance			
		) {}
	}
}