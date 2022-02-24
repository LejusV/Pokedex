using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Klang Specie to store common natural stats of every {'abilities': ['plus', 'minus', 'clear-body'], 'base_experience': 154, 'height': 6, 'id': 600, 'moves': ['vice-grip', 'bind', 'hyper-beam', 'thunder-shock', 'thunderbolt', 'thunder-wave', 'toxic', 'screech', 'double-team', 'rest', 'substitute', 'snore', 'protect', 'zap-cannon', 'lock-on', 'sandstorm', 'swagger', 'sleep-talk', 'return', 'frustration', 'hidden-power', 'rock-smash', 'uproar', 'facade', 'charge', 'magic-coat', 'recycle', 'secret-power', 'metal-sound', 'signal-beam', 'iron-defense', 'shock-wave', 'gravity', 'magnet-rise', 'rock-polish', 'mirror-shot', 'flash-cannon', 'discharge', 'charge-beam', 'autotomize', 'round', 'shift-gear', 'volt-switch', 'wild-charge', 'gear-grind', 'confide'], 'name': 'klang', 'stats': {'hp': 60, 'attack': 80, 'defense': 95, 'special-attack': 70, 'special-defense': 85, 'speed': 50}, 'types': ['steel'], 'weight': 510, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 20, 'gender_rate': -1, 'capture_rate': 60, 'color': 'gray', 'shape': 'heads', 'habitat': None, 'generation': 'generation-v', 'growth_rate': 'medium-slow', 'egg_groups': ['mineral'], 'names': {'ja-Hrkt': 'ギギアル', 'ko': '기기어르', 'zh-Hant': '齒輪組', 'fr': 'Clic', 'de': 'Kliklak', 'es': 'Klang', 'it': 'Klang', 'en': 'Klang', 'ja': 'ギギアル', 'zh-Hans': '齿轮组'}, 'genera': {'ja-Hrkt': 'はぐるまポケモン', 'ko': '톱니바퀴포켓몬', 'zh-Hant': '齒輪寶可夢', 'fr': 'Pokémon Engrenage', 'de': 'Getriebe', 'es': 'Pokémon Engranaje', 'it': 'Pokémon Ingranaggio', 'en': 'Gear Pokémon', 'ja': 'はぐるまポケモン', 'zh-Hans': '齿轮宝可梦'}}
	public class SpecieKlang : PokemonSpecie
	{
#nullable enable
		private static SpecieKlang? _instance = null;
#nullable restore
        public static SpecieKlang Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieKlang();
                }
                return _instance;
            }
        }

		public SpecieKlang() : base(
			"Klang",
			60, // HPs
			80, 95, // Attack & Defense
			70, 85, // Special Attack & Defense
			50			
		) {}
	}


	//Klang Pokemon Class
	public class Klang : Pokemon
	{

		public Klang(string nickname, int level)
		: base(
				600,
				SpecieKlang.Instance, // Pokemon Specie
				nickname, level,
				Steel.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Klang(int level)
		: base(
				600,
				SpecieKlang.Instance, // Pokemon Specie
				"Klang", level,
				Steel.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Klang() : base(
			600,
			SpecieKlang.Instance, // Pokemon Specie
			Steel.Instance			
		) {}
	}
}