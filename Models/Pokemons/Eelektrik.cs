using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Eelektrik Specie to store common natural stats of every {'abilities': ['levitate'], 'base_experience': 142, 'height': 12, 'id': 603, 'moves': ['bind', 'headbutt', 'thrash', 'acid', 'thunderbolt', 'thunder-wave', 'thunder', 'toxic', 'double-team', 'light-screen', 'flash', 'rest', 'super-fang', 'substitute', 'snore', 'protect', 'zap-cannon', 'giga-drain', 'swagger', 'spark', 'attract', 'sleep-talk', 'return', 'frustration', 'iron-tail', 'hidden-power', 'rain-dance', 'crunch', 'facade', 'knock-off', 'secret-power', 'signal-beam', 'bounce', 'shock-wave', 'u-turn', 'gastro-acid', 'magnet-rise', 'aqua-tail', 'flash-cannon', 'discharge', 'charge-beam', 'coil', 'acid-spray', 'round', 'acrobatics', 'volt-switch', 'wild-charge', 'confide'], 'name': 'eelektrik', 'stats': {'hp': 65, 'attack': 85, 'defense': 70, 'special-attack': 75, 'special-defense': 70, 'speed': 40}, 'types': ['electric'], 'weight': 220, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 20, 'gender_rate': 4, 'capture_rate': 60, 'color': 'blue', 'shape': 'fish', 'habitat': None, 'generation': 'generation-v', 'growth_rate': 'slow', 'egg_groups': ['indeterminate'], 'names': {'ja-Hrkt': 'シビビール', 'ko': '저리릴', 'zh-Hant': '麻麻鰻', 'fr': 'Lampéroie', 'de': 'Zapplalek', 'es': 'Eelektrik', 'it': 'Eelektrik', 'en': 'Eelektrik', 'ja': 'シビビール', 'zh-Hans': '麻麻鳗'}, 'genera': {'ja-Hrkt': 'でんきうおポケモン', 'ko': '전기물고기포켓몬', 'zh-Hant': '電魚寶可夢', 'fr': 'Pokémon Électrophore', 'de': 'Stromfisch', 'es': 'Pokémon Electropez', 'it': 'Pokémon Elettropesce', 'en': 'EleFish Pokémon', 'ja': 'でんきうおポケモン', 'zh-Hans': '电鱼宝可梦'}}
	public class SpecieEelektrik : PokemonSpecie
	{
#nullable enable
		private static SpecieEelektrik? _instance = null;
#nullable restore
        public static SpecieEelektrik Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieEelektrik();
                }
                return _instance;
            }
        }

		public SpecieEelektrik() : base(
			"Eelektrik",
			65, // HPs
			85, 70, // Attack & Defense
			75, 70, // Special Attack & Defense
			40			
		) {}
	}


	//Eelektrik Pokemon Class
	public class Eelektrik : Pokemon
	{

		public Eelektrik(string nickname, int level)
		: base(
				603,
				SpecieEelektrik.Instance, // Pokemon Specie
				nickname, level,
				Electric.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Eelektrik() : base(
			603,
			SpecieEelektrik.Instance, // Pokemon Specie
			Electric.Instance			
		) {}
	}
}