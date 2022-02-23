using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Raikou Specie to store common natural stats of every {'abilities': ['pressure', 'inner-focus'], 'base_experience': 261, 'height': 19, 'id': 243, 'moves': ['cut', 'headbutt', 'body-slam', 'double-edge', 'leer', 'bite', 'roar', 'hyper-beam', 'strength', 'thunder-shock', 'thunderbolt', 'thunder-wave', 'thunder', 'dig', 'toxic', 'quick-attack', 'mimic', 'double-team', 'light-screen', 'reflect', 'swift', 'flash', 'rest', 'substitute', 'snore', 'curse', 'protect', 'mud-slap', 'zap-cannon', 'detect', 'sandstorm', 'endure', 'swagger', 'spark', 'sleep-talk', 'return', 'frustration', 'iron-tail', 'hidden-power', 'rain-dance', 'sunny-day', 'crunch', 'psych-up', 'shadow-ball', 'rock-smash', 'facade', 'secret-power', 'signal-beam', 'extrasensory', 'calm-mind', 'shock-wave', 'natural-gift', 'magnet-rise', 'giga-impact', 'thunder-fang', 'rock-climb', 'discharge', 'iron-head', 'charge-beam', 'round', 'quash', 'volt-switch', 'bulldoze', 'wild-charge', 'snarl', 'confide'], 'name': 'raikou', 'stats': {'hp': 90, 'attack': 85, 'defense': 75, 'special-attack': 115, 'special-defense': 100, 'speed': 115}, 'types': ['electric'], 'weight': 1780, 'is_baby': False, 'is_legendary': True, 'is_mythical': False, 'hatch_counter': 80, 'gender_rate': -1, 'capture_rate': 3, 'color': 'yellow', 'shape': 'quadruped', 'habitat': 'grassland', 'generation': 'generation-ii', 'growth_rate': 'slow', 'egg_groups': ['no-eggs'], 'names': {'ja-Hrkt': 'ライコウ', 'roomaji': 'Raikou', 'ko': '라이코', 'zh-Hant': '雷公', 'fr': 'Raikou', 'de': 'Raikou', 'es': 'Raikou', 'it': 'Raikou', 'en': 'Raikou', 'ja': 'ライコウ', 'zh-Hans': '雷公'}, 'genera': {'ja-Hrkt': 'いかずちポケモン', 'ko': '우뢰포켓몬', 'zh-Hant': '天雷寶可夢', 'fr': 'Pokémon Foudre', 'de': 'Donner', 'es': 'Pokémon Trueno', 'it': 'Pokémon Tuono', 'en': 'Thunder Pokémon', 'ja': 'いかずちポケモン', 'zh-Hans': '天雷宝可梦'}}
	public class SpecieRaikou : PokemonSpecie
	{
#nullable enable
		private static SpecieRaikou? _instance = null;
#nullable restore
        public static SpecieRaikou Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieRaikou();
                }
                return _instance;
            }
        }

		public SpecieRaikou() : base(
			"Raikou",
			90, // HPs
			85, 75, // Attack & Defense
			115, 100, // Special Attack & Defense
			115			
		) {}
	}


	//Raikou Pokemon Class
	public class Raikou : Pokemon
	{

		public Raikou(string nickname, int level) : base(
			243,
			SpecieRaikou.Instance, // Pokemon Specie
			nickname, level,
			Electric.Instance			
		) {}

		public Raikou() : base(
			243,
			SpecieRaikou.Instance, // Pokemon Specie
			Electric.Instance			
		) {}
	}
}