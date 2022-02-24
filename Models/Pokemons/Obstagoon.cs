using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Obstagoon Specie to store common natural stats of every {'abilities': ['reckless', 'guts', 'defiant'], 'base_experience': 260, 'height': 16, 'id': 862, 'moves': [], 'name': 'obstagoon', 'stats': {'hp': 93, 'attack': 90, 'defense': 101, 'special-attack': 60, 'special-defense': 81, 'speed': 95}, 'types': ['dark', 'normal'], 'weight': 460, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 15, 'gender_rate': 4, 'capture_rate': 45, 'color': 'gray', 'shape': 'upright', 'habitat': None, 'generation': 'generation-viii', 'growth_rate': 'medium', 'egg_groups': [], 'names': {'ja-Hrkt': 'タチフサグマ', 'ko': '가로막구리', 'zh-Hant': '堵攔熊', 'fr': 'Ixon', 'de': 'Barrikadax', 'es': 'Obstagoon', 'it': 'Obstagoon', 'en': 'Obstagoon', 'ja': 'タチフサグマ', 'zh-Hans': '堵拦熊'}, 'genera': {'ja-Hrkt': 'ていしポケモン', 'ko': '정지포켓몬', 'zh-Hant': '停止寶可夢', 'fr': 'Pokémon Barrage', 'de': 'Barrikade', 'es': 'Pokémon Bloqueador', 'it': 'Pokémon Bloccaggio', 'en': 'Blocking Pokémon', 'ja': 'ていしポケモン', 'zh-Hans': '停止宝可梦'}}
	public class SpecieObstagoon : PokemonSpecie
	{
#nullable enable
		private static SpecieObstagoon? _instance = null;
#nullable restore
        public static SpecieObstagoon Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieObstagoon();
                }
                return _instance;
            }
        }

		public SpecieObstagoon() : base(
			"Obstagoon",
			93, // HPs
			90, 101, // Attack & Defense
			60, 81, // Special Attack & Defense
			95			
		) {}
	}


	//Obstagoon Pokemon Class
	public class Obstagoon : Pokemon
	{

		public Obstagoon(string nickname, int level)
		: base(
				862,
				SpecieObstagoon.Instance, // Pokemon Specie
				nickname, level,
				Dark.Instance, Normal.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Obstagoon(int level)
		: base(
				862,
				SpecieObstagoon.Instance, // Pokemon Specie
				"Obstagoon", level,
				Dark.Instance, Normal.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Obstagoon() : base(
			862,
			SpecieObstagoon.Instance, // Pokemon Specie
			Dark.Instance, Normal.Instance			
		) {}
	}
}