using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Drifloon Specie to store common natural stats of every {'abilities': ['aftermath', 'unburden', 'flare-boost'], 'base_experience': 70, 'height': 4, 'id': 425, 'moves': ['cut', 'gust', 'bind', 'body-slam', 'disable', 'thunderbolt', 'thunder-wave', 'thunder', 'toxic', 'psychic', 'hypnosis', 'double-team', 'minimize', 'haze', 'focus-energy', 'swift', 'constrict', 'amnesia', 'dream-eater', 'flash', 'explosion', 'rest', 'substitute', 'thief', 'snore', 'spite', 'protect', 'mud-slap', 'destiny-bond', 'icy-wind', 'endure', 'rollout', 'swagger', 'attract', 'sleep-talk', 'return', 'frustration', 'pain-split', 'baton-pass', 'hidden-power', 'rain-dance', 'sunny-day', 'psych-up', 'shadow-ball', 'stockpile', 'spit-up', 'swallow', 'will-o-wisp', 'memento', 'facade', 'trick', 'magic-coat', 'recycle', 'knock-off', 'skill-swap', 'secret-power', 'astonish', 'weather-ball', 'air-cutter', 'silver-wind', 'calm-mind', 'shock-wave', 'gyro-ball', 'natural-gift', 'tailwind', 'payback', 'embargo', 'sucker-punch', 'defog', 'captivate', 'charge-beam', 'ominous-wind', 'telekinesis', 'round', 'clear-smog', 'hex', 'acrobatics', 'confide'], 'name': 'drifloon', 'stats': {'hp': 90, 'attack': 50, 'defense': 34, 'special-attack': 60, 'special-defense': 44, 'speed': 70}, 'types': ['ghost', 'flying'], 'weight': 12, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 30, 'gender_rate': 4, 'capture_rate': 125, 'color': 'purple', 'shape': 'arms', 'habitat': None, 'generation': 'generation-iv', 'growth_rate': 'fast-then-very-slow', 'egg_groups': ['indeterminate'], 'names': {'ja-Hrkt': 'フワンテ', 'roomaji': 'Fuwante', 'ko': '흔들풍손', 'zh-Hant': '飄飄球', 'fr': 'Baudrive', 'de': 'Driftlon', 'es': 'Drifloon', 'it': 'Drifloon', 'en': 'Drifloon', 'ja': 'フワンテ', 'zh-Hans': '飘飘球'}, 'genera': {'ja-Hrkt': 'ふうせんポケモン', 'ko': '풍선포켓몬', 'zh-Hant': '氣球寶可夢', 'fr': 'Pokémon Bouboule', 'de': 'Ballon', 'es': 'Pokémon Globo', 'it': 'Pokémon Pallone', 'en': 'Balloon Pokémon', 'ja': 'ふうせんポケモン', 'zh-Hans': '气球宝可梦'}}
	public class SpecieDrifloon : PokemonSpecie
	{
#nullable enable
		private static SpecieDrifloon? _instance = null;
#nullable restore
        public static SpecieDrifloon Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieDrifloon();
                }
                return _instance;
            }
        }

		public SpecieDrifloon() : base(
			"Drifloon",
			90, // HPs
			50, 34, // Attack & Defense
			60, 44, // Special Attack & Defense
			70			
		) {}
	}


	//Drifloon Pokemon Class
	public class Drifloon : Pokemon
	{

		public Drifloon(string nickname, int level)
		: base(
				425,
				SpecieDrifloon.Instance, // Pokemon Specie
				nickname, level,
				Ghost.Instance, Flying.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Drifloon(int level)
		: base(
				425,
				SpecieDrifloon.Instance, // Pokemon Specie
				"Drifloon", level,
				Ghost.Instance, Flying.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Drifloon() : base(
			425,
			SpecieDrifloon.Instance, // Pokemon Specie
			Ghost.Instance, Flying.Instance			
		) {}
	}
}