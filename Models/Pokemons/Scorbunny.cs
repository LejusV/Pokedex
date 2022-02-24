using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Scorbunny Specie to store common natural stats of every {'abilities': ['blaze', 'libero'], 'base_experience': 62, 'height': 3, 'id': 813, 'moves': [], 'name': 'scorbunny', 'stats': {'hp': 50, 'attack': 71, 'defense': 40, 'special-attack': 40, 'special-defense': 40, 'speed': 69}, 'types': ['fire'], 'weight': 45, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 20, 'gender_rate': 1, 'capture_rate': 45, 'color': 'white', 'shape': 'upright', 'habitat': None, 'generation': 'generation-viii', 'growth_rate': 'medium-slow', 'egg_groups': [], 'names': {'ja-Hrkt': 'ヒバニー', 'ko': '염버니', 'zh-Hant': '炎兔兒', 'fr': 'Flambino', 'de': 'Hopplo', 'es': 'Scorbunny', 'it': 'Scorbunny', 'en': 'Scorbunny', 'ja': 'ヒバニー', 'zh-Hans': '炎兔儿'}, 'genera': {'ja-Hrkt': 'うさぎポケモン', 'ko': '토끼포켓몬', 'zh-Hant': '兔子寶可夢', 'fr': 'Pokémon Lapin', 'de': 'Hase', 'es': 'Pokémon Conejo', 'it': 'Pokémon Coniglio', 'en': 'Rabbit Pokémon', 'ja': 'うさぎポケモン', 'zh-Hans': '兔子宝可梦'}}
	public class SpecieScorbunny : PokemonSpecie
	{
#nullable enable
		private static SpecieScorbunny? _instance = null;
#nullable restore
        public static SpecieScorbunny Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieScorbunny();
                }
                return _instance;
            }
        }

		public SpecieScorbunny() : base(
			"Scorbunny",
			50, // HPs
			71, 40, // Attack & Defense
			40, 40, // Special Attack & Defense
			69			
		) {}
	}


	//Scorbunny Pokemon Class
	public class Scorbunny : Pokemon
	{

		public Scorbunny(string nickname, int level)
		: base(
				813,
				SpecieScorbunny.Instance, // Pokemon Specie
				nickname, level,
				Fire.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Scorbunny() : base(
			813,
			SpecieScorbunny.Instance, // Pokemon Specie
			Fire.Instance			
		) {}
	}
}