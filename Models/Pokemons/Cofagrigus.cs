using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Cofagrigus Specie to store common natural stats of every {'abilities': ['mummy'], 'base_experience': 169, 'height': 17, 'id': 563, 'moves': ['disable', 'hyper-beam', 'toxic', 'psychic', 'night-shade', 'double-team', 'haze', 'dream-eater', 'flash', 'rest', 'substitute', 'thief', 'snore', 'curse', 'spite', 'protect', 'scary-face', 'destiny-bond', 'swagger', 'mean-look', 'attract', 'sleep-talk', 'return', 'frustration', 'safeguard', 'pain-split', 'hidden-power', 'rain-dance', 'psych-up', 'shadow-ball', 'will-o-wisp', 'facade', 'trick', 'role-play', 'magic-coat', 'knock-off', 'skill-swap', 'grudge', 'snatch', 'secret-power', 'astonish', 'iron-defense', 'block', 'calm-mind', 'shock-wave', 'payback', 'embargo', 'dark-pulse', 'energy-ball', 'giga-impact', 'zen-headbutt', 'trick-room', 'grass-knot', 'ominous-wind', 'guard-split', 'power-split', 'wonder-room', 'telekinesis', 'after-you', 'round', 'hex', 'confide', 'infestation'], 'name': 'cofagrigus', 'stats': {'hp': 58, 'attack': 50, 'defense': 145, 'special-attack': 95, 'special-defense': 105, 'speed': 30}, 'types': ['ghost'], 'weight': 765, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 25, 'gender_rate': 4, 'capture_rate': 90, 'color': 'yellow', 'shape': 'blob', 'habitat': None, 'generation': 'generation-v', 'growth_rate': 'medium', 'egg_groups': ['mineral', 'indeterminate'], 'names': {'ja-Hrkt': 'デスカーン', 'ko': '데스니칸', 'zh-Hant': '死神棺', 'fr': 'Tutankafer', 'de': 'Echnatoll', 'es': 'Cofagrigus', 'it': 'Cofagrigus', 'en': 'Cofagrigus', 'ja': 'デスカーン', 'zh-Hans': '死神棺'}, 'genera': {'ja-Hrkt': 'かんおけポケモン', 'ko': '관포켓몬', 'zh-Hant': '棺木寶可夢', 'fr': 'Pokémon Cercueil', 'de': 'Sarkophag', 'es': 'Pokémon Sepultura', 'it': 'Pokémon Bara', 'en': 'Coffin Pokémon', 'ja': 'かんおけポケモン', 'zh-Hans': '棺木宝可梦'}}
	public class SpecieCofagrigus : PokemonSpecie
	{
#nullable enable
		private static SpecieCofagrigus? _instance = null;
#nullable restore
        public static SpecieCofagrigus Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieCofagrigus();
                }
                return _instance;
            }
        }

		public SpecieCofagrigus() : base(
			"Cofagrigus",
			58, // HPs
			50, 145, // Attack & Defense
			95, 105, // Special Attack & Defense
			30			
		) {}
	}


	//Cofagrigus Pokemon Class
	public class Cofagrigus : Pokemon
	{

		public Cofagrigus(string nickname, int level)
		: base(
				563,
				SpecieCofagrigus.Instance, // Pokemon Specie
				nickname, level,
				Ghost.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Cofagrigus(int level)
		: base(
				563,
				SpecieCofagrigus.Instance, // Pokemon Specie
				"Cofagrigus", level,
				Ghost.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Cofagrigus() : base(
			563,
			SpecieCofagrigus.Instance, // Pokemon Specie
			Ghost.Instance			
		) {}
	}
}