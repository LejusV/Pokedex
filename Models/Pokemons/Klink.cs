using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Klink Specie to store common natural stats of every {'abilities': ['plus', 'minus', 'clear-body'], 'base_experience': 60, 'height': 3, 'id': 599, 'moves': ['vice-grip', 'bind', 'hyper-beam', 'thunder-shock', 'thunderbolt', 'thunder-wave', 'toxic', 'screech', 'double-team', 'rest', 'substitute', 'snore', 'protect', 'zap-cannon', 'lock-on', 'sandstorm', 'swagger', 'sleep-talk', 'return', 'frustration', 'hidden-power', 'rock-smash', 'uproar', 'facade', 'charge', 'magic-coat', 'recycle', 'secret-power', 'metal-sound', 'signal-beam', 'iron-defense', 'shock-wave', 'gravity', 'magnet-rise', 'rock-polish', 'mirror-shot', 'flash-cannon', 'discharge', 'charge-beam', 'autotomize', 'round', 'shift-gear', 'volt-switch', 'wild-charge', 'gear-grind', 'confide'], 'name': 'klink', 'stats': {'hp': 40, 'attack': 55, 'defense': 70, 'special-attack': 45, 'special-defense': 60, 'speed': 30}, 'types': ['steel'], 'weight': 210, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 20, 'gender_rate': -1, 'capture_rate': 130, 'color': 'gray', 'shape': 'heads', 'habitat': None, 'generation': 'generation-v', 'growth_rate': 'medium-slow', 'egg_groups': ['mineral'], 'names': {'ja-Hrkt': 'ギアル', 'ko': '기어르', 'zh-Hant': '齒輪兒', 'fr': 'Tic', 'de': 'Klikk', 'es': 'Klink', 'it': 'Klink', 'en': 'Klink', 'ja': 'ギアル', 'zh-Hans': '齿轮儿'}, 'genera': {'ja-Hrkt': 'はぐるまポケモン', 'ko': '톱니바퀴포켓몬', 'zh-Hant': '齒輪寶可夢', 'fr': 'Pokémon Engrenage', 'de': 'Getriebe', 'es': 'Pokémon Engranaje', 'it': 'Pokémon Ingranaggio', 'en': 'Gear Pokémon', 'ja': 'はぐるまポケモン', 'zh-Hans': '齿轮宝可梦'}}
	public class SpecieKlink : PokemonSpecie
	{
#nullable enable
		private static SpecieKlink? _instance = null;
#nullable restore
        public static SpecieKlink Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieKlink();
                }
                return _instance;
            }
        }

		public SpecieKlink() : base(
			"Klink",
			40, // HPs
			55, 70, // Attack & Defense
			45, 60, // Special Attack & Defense
			30			
		) {}
	}


	//Klink Pokemon Class
	public class Klink : Pokemon
	{

		public Klink(string nickname, int level)
		: base(
				599,
				SpecieKlink.Instance, // Pokemon Specie
				nickname, level,
				Steel.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Klink(int level)
		: base(
				599,
				SpecieKlink.Instance, // Pokemon Specie
				"Klink", level,
				Steel.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Klink() : base(
			599,
			SpecieKlink.Instance, // Pokemon Specie
			Steel.Instance			
		) {}
	}
}