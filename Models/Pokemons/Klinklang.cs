using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Klinklang Specie to store common natural stats of every {'abilities': ['plus', 'minus', 'clear-body'], 'base_experience': 234, 'height': 6, 'id': 601, 'moves': ['vice-grip', 'bind', 'hyper-beam', 'thunder-shock', 'thunderbolt', 'thunder-wave', 'thunder', 'toxic', 'screech', 'double-team', 'rest', 'substitute', 'snore', 'protect', 'zap-cannon', 'lock-on', 'sandstorm', 'swagger', 'sleep-talk', 'return', 'frustration', 'hidden-power', 'rock-smash', 'uproar', 'facade', 'charge', 'magic-coat', 'recycle', 'secret-power', 'metal-sound', 'signal-beam', 'iron-defense', 'shock-wave', 'gravity', 'magnet-rise', 'rock-polish', 'giga-impact', 'mirror-shot', 'flash-cannon', 'trick-room', 'discharge', 'charge-beam', 'autotomize', 'round', 'shift-gear', 'volt-switch', 'wild-charge', 'gear-grind', 'confide', 'magnetic-flux', 'gear-up'], 'name': 'klinklang', 'stats': {'hp': 60, 'attack': 100, 'defense': 115, 'special-attack': 70, 'special-defense': 85, 'speed': 90}, 'types': ['steel'], 'weight': 810, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 20, 'gender_rate': -1, 'capture_rate': 30, 'color': 'gray', 'shape': 'heads', 'habitat': None, 'generation': 'generation-v', 'growth_rate': 'medium-slow', 'egg_groups': ['mineral'], 'names': {'ja-Hrkt': 'ギギギアル', 'ko': '기기기어르', 'zh-Hant': '齒輪怪', 'fr': 'Cliticlic', 'de': 'Klikdiklak', 'es': 'Klinklang', 'it': 'Klinklang', 'en': 'Klinklang', 'ja': 'ギギギアル', 'zh-Hans': '齿轮怪'}, 'genera': {'ja-Hrkt': 'はぐるまポケモン', 'ko': '톱니바퀴포켓몬', 'zh-Hant': '齒輪寶可夢', 'fr': 'Pokémon Engrenage', 'de': 'Getriebe', 'es': 'Pokémon Engranaje', 'it': 'Pokémon Ingranaggio', 'en': 'Gear Pokémon', 'ja': 'はぐるまポケモン', 'zh-Hans': '齿轮宝可梦'}}
	public class SpecieKlinklang : PokemonSpecie
	{
#nullable enable
		private static SpecieKlinklang? _instance = null;
#nullable restore
        public static SpecieKlinklang Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieKlinklang();
                }
                return _instance;
            }
        }

		public SpecieKlinklang() : base(
			"Klinklang",
			60, // HPs
			100, 115, // Attack & Defense
			70, 85, // Special Attack & Defense
			90			
		) {}
	}


	//Klinklang Pokemon Class
	public class Klinklang : Pokemon
	{

		public Klinklang(string nickname, int level) : base(
			601,
			SpecieKlinklang.Instance, // Pokemon Specie
			nickname, level,
			Steel.Instance			
		) {}

		public Klinklang() : base(
			601,
			SpecieKlinklang.Instance, // Pokemon Specie
			Steel.Instance			
		) {}
	}
}