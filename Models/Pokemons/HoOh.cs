using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Ho-Oh Specie to store common natural stats of every {'abilities': ['pressure', 'regenerator'], 'base_experience': 306, 'height': 38, 'id': 250, 'moves': ['gust', 'whirlwind', 'fly', 'double-edge', 'roar', 'flamethrower', 'hyper-beam', 'strength', 'solar-beam', 'thunderbolt', 'thunder-wave', 'thunder', 'earthquake', 'toxic', 'psychic', 'mimic', 'double-team', 'recover', 'light-screen', 'reflect', 'fire-blast', 'swift', 'dream-eater', 'sky-attack', 'flash', 'rest', 'substitute', 'nightmare', 'snore', 'curse', 'protect', 'mud-slap', 'zap-cannon', 'detect', 'sandstorm', 'giga-drain', 'endure', 'swagger', 'steel-wing', 'sleep-talk', 'return', 'frustration', 'safeguard', 'sacred-fire', 'dragon-breath', 'hidden-power', 'twister', 'rain-dance', 'sunny-day', 'psych-up', 'ancient-power', 'shadow-ball', 'future-sight', 'rock-smash', 'heat-wave', 'will-o-wisp', 'facade', 'secret-power', 'hyper-voice', 'weather-ball', 'air-cutter', 'overheat', 'signal-beam', 'extrasensory', 'aerial-ace', 'calm-mind', 'shock-wave', 'roost', 'natural-gift', 'pluck', 'tailwind', 'punishment', 'brave-bird', 'earth-power', 'giga-impact', 'zen-headbutt', 'defog', 'iron-head', 'charge-beam', 'ominous-wind', 'flame-charge', 'round', 'echoed-voice', 'sky-drop', 'incinerate', 'bulldoze', 'confide'], 'name': 'ho-oh', 'stats': {'hp': 106, 'attack': 130, 'defense': 90, 'special-attack': 110, 'special-defense': 154, 'speed': 90}, 'types': ['fire', 'flying'], 'weight': 1990, 'is_baby': False, 'is_legendary': True, 'is_mythical': False, 'hatch_counter': 120, 'gender_rate': -1, 'capture_rate': 3, 'color': 'red', 'shape': 'wings', 'habitat': 'rare', 'generation': 'generation-ii', 'growth_rate': 'slow', 'egg_groups': ['no-eggs'], 'names': {'ja-Hrkt': 'ホウオウ', 'roomaji': 'Houou', 'ko': '칠색조', 'zh-Hant': '鳳王', 'fr': 'Ho-Oh', 'de': 'Ho-Oh', 'es': 'Ho-Oh', 'it': 'Ho-Oh', 'en': 'Ho-Oh', 'ja': 'ホウオウ', 'zh-Hans': '凤王'}, 'genera': {'ja-Hrkt': 'にじいろポケモン', 'ko': '무지개색포켓몬', 'zh-Hant': '虹色寶可夢', 'fr': 'Pokémon Arcenciel', 'de': 'Regenbogen', 'es': 'Pokémon Arcoíris', 'it': 'Pokémon Arcobaleno', 'en': 'Rainbow Pokémon', 'ja': 'にじいろポケモン', 'zh-Hans': '虹色宝可梦'}}
	public class SpecieHoOh : PokemonSpecie
	{
#nullable enable
		private static SpecieHoOh? _instance = null;
#nullable restore
        public static SpecieHoOh Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieHoOh();
                }
                return _instance;
            }
        }

		public SpecieHoOh() : base(
			"Ho-Oh",
			106, // HPs
			130, 90, // Attack & Defense
			110, 154, // Special Attack & Defense
			90			
		) {}
	}


	//Ho-Oh Pokemon Class
	public class HoOh : Pokemon
	{

		public HoOh(string nickname, int level)
		: base(
				250,
				SpecieHoOh.Instance, // Pokemon Specie
				nickname, level,
				Fire.Instance, Flying.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public HoOh() : base(
			250,
			SpecieHoOh.Instance, // Pokemon Specie
			Fire.Instance, Flying.Instance			
		) {}
	}
}