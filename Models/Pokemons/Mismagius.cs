using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Mismagius Specie to store common natural stats of every {'abilities': ['levitate'], 'base_experience': 173, 'height': 9, 'id': 429, 'moves': ['headbutt', 'growl', 'hyper-beam', 'thunderbolt', 'thunder-wave', 'thunder', 'toxic', 'psychic', 'double-team', 'swift', 'dream-eater', 'flash', 'psywave', 'rest', 'substitute', 'thief', 'snore', 'spite', 'protect', 'icy-wind', 'endure', 'swagger', 'attract', 'sleep-talk', 'heal-bell', 'return', 'frustration', 'pain-split', 'hidden-power', 'rain-dance', 'sunny-day', 'psych-up', 'shadow-ball', 'uproar', 'torment', 'will-o-wisp', 'facade', 'taunt', 'trick', 'magic-coat', 'skill-swap', 'snatch', 'secret-power', 'hyper-voice', 'astonish', 'aerial-ace', 'magical-leaf', 'calm-mind', 'shock-wave', 'natural-gift', 'payback', 'embargo', 'lucky-chant', 'sucker-punch', 'dark-pulse', 'power-gem', 'energy-ball', 'giga-impact', 'trick-room', 'captivate', 'charge-beam', 'ominous-wind', 'wonder-room', 'telekinesis', 'magic-room', 'foul-play', 'round', 'echoed-voice', 'phantom-force', 'confide', 'mystical-fire', 'dazzling-gleam'], 'name': 'mismagius', 'stats': {'hp': 60, 'attack': 60, 'defense': 60, 'special-attack': 105, 'special-defense': 105, 'speed': 105}, 'types': ['ghost'], 'weight': 44, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 25, 'gender_rate': 4, 'capture_rate': 45, 'color': 'purple', 'shape': 'ball', 'habitat': None, 'generation': 'generation-iv', 'growth_rate': 'fast', 'egg_groups': ['indeterminate'], 'names': {'ja-Hrkt': 'ムウマージ', 'roomaji': 'Mumage', 'ko': '무우마직', 'zh-Hant': '夢妖魔', 'fr': 'Magirêve', 'de': 'Traunmagil', 'es': 'Mismagius', 'it': 'Mismagius', 'en': 'Mismagius', 'ja': 'ムウマージ', 'zh-Hans': '梦妖魔'}, 'genera': {'ja-Hrkt': 'マジカルポケモン', 'ko': '매지컬포켓몬', 'zh-Hant': '魔法寶可夢', 'fr': 'Pokémon Magique', 'de': 'Magisch', 'es': 'Pokémon Mágico', 'it': 'Pokémon Stregone', 'en': 'Magical Pokémon', 'ja': 'マジカルポケモン', 'zh-Hans': '魔法宝可梦'}}
	public class SpecieMismagius : PokemonSpecie
	{
#nullable enable
		private static SpecieMismagius? _instance = null;
#nullable restore
        public static SpecieMismagius Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieMismagius();
                }
                return _instance;
            }
        }

		public SpecieMismagius() : base(
			"Mismagius",
			60, // HPs
			60, 60, // Attack & Defense
			105, 105, // Special Attack & Defense
			105			
		) {}
	}


	//Mismagius Pokemon Class
	public class Mismagius : Pokemon
	{

		public Mismagius(string nickname, int level)
		: base(
				429,
				SpecieMismagius.Instance, // Pokemon Specie
				nickname, level,
				Ghost.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Mismagius(int level)
		: base(
				429,
				SpecieMismagius.Instance, // Pokemon Specie
				"Mismagius", level,
				Ghost.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Mismagius() : base(
			429,
			SpecieMismagius.Instance, // Pokemon Specie
			Ghost.Instance			
		) {}
	}
}