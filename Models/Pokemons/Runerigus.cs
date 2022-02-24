using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Runerigus Specie to store common natural stats of every {'abilities': ['wandering-spirit'], 'base_experience': 169, 'height': 16, 'id': 867, 'moves': [], 'name': 'runerigus', 'stats': {'hp': 58, 'attack': 95, 'defense': 145, 'special-attack': 50, 'special-defense': 105, 'speed': 30}, 'types': ['ground', 'ghost'], 'weight': 666, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 25, 'gender_rate': 4, 'capture_rate': 90, 'color': 'gray', 'shape': 'blob', 'habitat': None, 'generation': 'generation-viii', 'growth_rate': 'medium', 'egg_groups': [], 'names': {'ja-Hrkt': 'デスバーン', 'ko': '데스판', 'zh-Hant': '死神板', 'fr': 'Tutétékri', 'de': 'Oghnatoll', 'es': 'Runerigus', 'it': 'Runerigus', 'en': 'Runerigus', 'ja': 'デスバーン', 'zh-Hans': '死神板'}, 'genera': {'ja-Hrkt': 'おんねんポケモン', 'ko': '원념포켓몬', 'zh-Hant': '怨念寶可夢', 'fr': 'Pokémon Rancune', 'de': 'Gram', 'es': 'Pokémon Resquemor', 'it': 'Pokémon Rancore', 'en': 'Grudge Pokémon', 'ja': 'おんねんポケモン', 'zh-Hans': '怨念宝可梦'}}
	public class SpecieRunerigus : PokemonSpecie
	{
#nullable enable
		private static SpecieRunerigus? _instance = null;
#nullable restore
        public static SpecieRunerigus Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieRunerigus();
                }
                return _instance;
            }
        }

		public SpecieRunerigus() : base(
			"Runerigus",
			58, // HPs
			95, 145, // Attack & Defense
			50, 105, // Special Attack & Defense
			30			
		) {}
	}


	//Runerigus Pokemon Class
	public class Runerigus : Pokemon
	{

		public Runerigus(string nickname, int level)
		: base(
				867,
				SpecieRunerigus.Instance, // Pokemon Specie
				nickname, level,
				Ground.Instance, Ghost.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Runerigus() : base(
			867,
			SpecieRunerigus.Instance, // Pokemon Specie
			Ground.Instance, Ghost.Instance			
		) {}
	}
}