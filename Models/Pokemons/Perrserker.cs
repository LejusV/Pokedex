using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Perrserker Specie to store common natural stats of every {'abilities': ['battle-armor', 'tough-claws', 'steely-spirit'], 'base_experience': 154, 'height': 8, 'id': 863, 'moves': [], 'name': 'perrserker', 'stats': {'hp': 70, 'attack': 110, 'defense': 100, 'special-attack': 50, 'special-defense': 60, 'speed': 50}, 'types': ['steel'], 'weight': 280, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 20, 'gender_rate': 4, 'capture_rate': 90, 'color': 'brown', 'shape': 'upright', 'habitat': None, 'generation': 'generation-viii', 'growth_rate': 'medium', 'egg_groups': [], 'names': {'ja-Hrkt': 'ニャイキング', 'ko': '나이킹', 'zh-Hant': '喵頭目', 'fr': 'Berserkatt', 'de': 'Mauzinger', 'es': 'Perrserker', 'it': 'Perrserker', 'en': 'Perrserker', 'ja': 'ニャイキング', 'zh-Hans': '喵头目'}, 'genera': {'ja-Hrkt': 'バイキングポケモン', 'ko': '바이킹포켓몬', 'zh-Hant': '維京寶可夢', 'fr': 'Pokémon Viking', 'de': 'Wikinger', 'es': 'Pokémon Vikingo', 'it': 'Pokémon Vichingo', 'en': 'Viking Pokémon', 'ja': 'バイキングポケモン', 'zh-Hans': '维京宝可梦'}}
	public class SpeciePerrserker : PokemonSpecie
	{
#nullable enable
		private static SpeciePerrserker? _instance = null;
#nullable restore
        public static SpeciePerrserker Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciePerrserker();
                }
                return _instance;
            }
        }

		public SpeciePerrserker() : base(
			"Perrserker",
			70, // HPs
			110, 100, // Attack & Defense
			50, 60, // Special Attack & Defense
			50			
		) {}
	}


	//Perrserker Pokemon Class
	public class Perrserker : Pokemon
	{

		public Perrserker(string nickname, int level)
		: base(
				863,
				SpeciePerrserker.Instance, // Pokemon Specie
				nickname, level,
				Steel.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Perrserker() : base(
			863,
			SpeciePerrserker.Instance, // Pokemon Specie
			Steel.Instance			
		) {}
	}
}