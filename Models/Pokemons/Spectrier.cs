using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Spectrier Specie to store common natural stats of every {'abilities': ['grim-neigh'], 'base_experience': 290, 'height': 20, 'id': 897, 'moves': [], 'name': 'spectrier', 'stats': {'hp': 100, 'attack': 65, 'defense': 60, 'special-attack': 145, 'special-defense': 80, 'speed': 130}, 'types': ['ghost'], 'weight': 445, 'is_baby': False, 'is_legendary': True, 'is_mythical': False, 'hatch_counter': 120, 'gender_rate': -1, 'capture_rate': 3, 'color': 'black', 'shape': 'quadruped', 'habitat': None, 'generation': 'generation-viii', 'growth_rate': 'slow', 'egg_groups': [], 'names': {'ja-Hrkt': 'レイスポス', 'ko': '레이스포스', 'zh-Hant': '靈幽馬', 'fr': 'Spectreval', 'de': 'Phantoross', 'es': 'Spectrier', 'it': 'Spectrier', 'en': 'Spectrier', 'ja': 'レイスポス', 'zh-Hans': '灵幽马'}, 'genera': {'ja-Hrkt': 'しゅんばポケモン', 'ko': '빠른말포켓몬', 'zh-Hant': '駿馬寶可夢', 'fr': 'Pokémon Cheval Vif', 'de': 'Flinkblut', 'es': 'Pokémon Corcel Veloz', 'it': 'Pokémon Sveltequino', 'en': 'Swift Horse Pokémon', 'ja': 'しゅんばポケモン', 'zh-Hans': '骏马宝可梦'}}
	public class SpecieSpectrier : PokemonSpecie
	{
#nullable enable
		private static SpecieSpectrier? _instance = null;
#nullable restore
        public static SpecieSpectrier Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieSpectrier();
                }
                return _instance;
            }
        }

		public SpecieSpectrier() : base(
			"Spectrier",
			100, // HPs
			65, 60, // Attack & Defense
			145, 80, // Special Attack & Defense
			130			
		) {}
	}


	//Spectrier Pokemon Class
	public class Spectrier : Pokemon
	{

		public Spectrier(string nickname, int level)
		: base(
				897,
				SpecieSpectrier.Instance, // Pokemon Specie
				nickname, level,
				Ghost.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Spectrier(int level)
		: base(
				897,
				SpecieSpectrier.Instance, // Pokemon Specie
				"Spectrier", level,
				Ghost.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Spectrier() : base(
			897,
			SpecieSpectrier.Instance, // Pokemon Specie
			Ghost.Instance			
		) {}
	}
}