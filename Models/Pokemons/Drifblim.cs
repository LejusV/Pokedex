using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Drifblim Specie to store common natural stats of every {'abilities': ['aftermath', 'unburden', 'flare-boost'], 'base_experience': 174, 'height': 12, 'id': 426, 'moves': ['cut', 'gust', 'fly', 'bind', 'hyper-beam', 'thunderbolt', 'thunder-wave', 'thunder', 'toxic', 'psychic', 'double-team', 'minimize', 'focus-energy', 'swift', 'constrict', 'amnesia', 'dream-eater', 'flash', 'explosion', 'rest', 'substitute', 'thief', 'snore', 'spite', 'protect', 'mud-slap', 'icy-wind', 'endure', 'rollout', 'swagger', 'attract', 'sleep-talk', 'return', 'frustration', 'pain-split', 'baton-pass', 'hidden-power', 'rain-dance', 'sunny-day', 'psych-up', 'shadow-ball', 'stockpile', 'spit-up', 'swallow', 'will-o-wisp', 'facade', 'trick', 'magic-coat', 'recycle', 'knock-off', 'skill-swap', 'secret-power', 'astonish', 'air-cutter', 'silver-wind', 'calm-mind', 'shock-wave', 'gyro-ball', 'natural-gift', 'tailwind', 'payback', 'embargo', 'sucker-punch', 'giga-impact', 'defog', 'captivate', 'charge-beam', 'ominous-wind', 'telekinesis', 'round', 'hex', 'acrobatics', 'phantom-force', 'confide'], 'name': 'drifblim', 'stats': {'hp': 150, 'attack': 80, 'defense': 44, 'special-attack': 90, 'special-defense': 54, 'speed': 80}, 'types': ['ghost', 'flying'], 'weight': 150, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 30, 'gender_rate': 4, 'capture_rate': 60, 'color': 'purple', 'shape': 'arms', 'habitat': None, 'generation': 'generation-iv', 'growth_rate': 'fast-then-very-slow', 'egg_groups': ['indeterminate'], 'names': {'ja-Hrkt': 'フワライド', 'roomaji': 'Fuwaride', 'ko': '둥실라이드', 'zh-Hant': '隨風球', 'fr': 'Grodrive', 'de': 'Drifzepeli', 'es': 'Drifblim', 'it': 'Drifblim', 'en': 'Drifblim', 'ja': 'フワライド', 'zh-Hans': '随风球'}, 'genera': {'ja-Hrkt': 'ききゅうポケモン', 'ko': '기구포켓몬', 'zh-Hant': '熱氣球寶可夢', 'fr': 'Pokémon Ballon', 'de': 'Luftschiff', 'es': 'Pokémon Dirigible', 'it': 'Pokémon Dirigibile', 'en': 'Blimp Pokémon', 'ja': 'ききゅうポケモン', 'zh-Hans': '热气球宝可梦'}}
	public class SpecieDrifblim : PokemonSpecie
	{
#nullable enable
		private static SpecieDrifblim? _instance = null;
#nullable restore
        public static SpecieDrifblim Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieDrifblim();
                }
                return _instance;
            }
        }

		public SpecieDrifblim() : base(
			"Drifblim",
			150, // HPs
			80, 44, // Attack & Defense
			90, 54, // Special Attack & Defense
			80			
		) {}
	}


	//Drifblim Pokemon Class
	public class Drifblim : Pokemon
	{

		public Drifblim(string nickname, int level) : base(
			426,
			SpecieDrifblim.Instance, // Pokemon Specie
			nickname, level,
			Ghost.Instance, Flying.Instance			
		) {}

		public Drifblim() : base(
			426,
			SpecieDrifblim.Instance, // Pokemon Specie
			Ghost.Instance, Flying.Instance			
		) {}
	}
}