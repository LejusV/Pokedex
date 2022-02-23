using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Frillish Specie to store common natural stats of every {'abilities': ['water-absorb', 'cursed-body', 'damp'], 'base_experience': 67, 'height': 12, 'id': 592, 'moves': ['bind', 'mist', 'hydro-pump', 'surf', 'ice-beam', 'blizzard', 'bubble-beam', 'absorb', 'toxic', 'psychic', 'night-shade', 'double-team', 'recover', 'confuse-ray', 'waterfall', 'constrict', 'dream-eater', 'bubble', 'flash', 'acid-armor', 'rest', 'substitute', 'snore', 'spite', 'protect', 'sludge-bomb', 'icy-wind', 'giga-drain', 'swagger', 'attract', 'sleep-talk', 'return', 'frustration', 'safeguard', 'pain-split', 'hidden-power', 'rain-dance', 'psych-up', 'shadow-ball', 'hail', 'will-o-wisp', 'facade', 'taunt', 'trick', 'magic-coat', 'secret-power', 'dive', 'water-spout', 'water-sport', 'shock-wave', 'water-pulse', 'brine', 'wring-out', 'dark-pulse', 'energy-ball', 'trick-room', 'ominous-wind', 'sludge-wave', 'round', 'scald', 'hex', 'confide', 'dazzling-gleam'], 'name': 'frillish', 'stats': {'hp': 55, 'attack': 40, 'defense': 50, 'special-attack': 65, 'special-defense': 85, 'speed': 40}, 'types': ['water', 'ghost'], 'weight': 330, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 20, 'gender_rate': 4, 'capture_rate': 190, 'color': 'white', 'shape': 'tentacles', 'habitat': None, 'generation': 'generation-v', 'growth_rate': 'medium', 'egg_groups': ['indeterminate'], 'names': {'ja-Hrkt': 'プルリル', 'ko': '탱그릴', 'zh-Hant': '輕飄飄', 'fr': 'Viskuse', 'de': 'Quabbel', 'es': 'Frillish', 'it': 'Frillish', 'en': 'Frillish', 'ja': 'プルリル', 'zh-Hans': '轻飘飘'}, 'genera': {'ja-Hrkt': 'ふゆうポケモン', 'ko': '부유포켓몬', 'zh-Hant': '漂浮寶可夢', 'fr': 'Pokémon Flottaison', 'de': 'Gleit', 'es': 'Pokémon Ingrávido', 'it': 'Pokémon Fluttuante', 'en': 'Floating Pokémon', 'ja': 'ふゆうポケモン', 'zh-Hans': '漂浮宝可梦'}}
	public class SpecieFrillish : PokemonSpecie
	{
#nullable enable
		private static SpecieFrillish? _instance = null;
#nullable restore
        public static SpecieFrillish Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieFrillish();
                }
                return _instance;
            }
        }

		public SpecieFrillish() : base(
			"Frillish",
			55, // HPs
			40, 50, // Attack & Defense
			65, 85, // Special Attack & Defense
			40			
		) {}
	}


	//Frillish Pokemon Class
	public class Frillish : Pokemon
	{

		public Frillish(string nickname, int level) : base(
			592,
			SpecieFrillish.Instance, // Pokemon Specie
			nickname, level,
			Water.Instance, Ghost.Instance			
		) {}

		public Frillish() : base(
			592,
			SpecieFrillish.Instance, // Pokemon Specie
			Water.Instance, Ghost.Instance			
		) {}
	}
}