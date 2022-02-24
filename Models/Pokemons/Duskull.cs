using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Duskull Specie to store common natural stats of every {'abilities': ['levitate', 'frisk'], 'base_experience': 59, 'height': 8, 'id': 355, 'moves': ['headbutt', 'body-slam', 'double-edge', 'leer', 'disable', 'ice-beam', 'blizzard', 'toxic', 'psychic', 'night-shade', 'mimic', 'double-team', 'confuse-ray', 'haze', 'dream-eater', 'flash', 'rest', 'substitute', 'thief', 'nightmare', 'snore', 'curse', 'spite', 'protect', 'feint-attack', 'foresight', 'destiny-bond', 'icy-wind', 'endure', 'swagger', 'mean-look', 'attract', 'sleep-talk', 'return', 'frustration', 'pain-split', 'pursuit', 'hidden-power', 'rain-dance', 'sunny-day', 'psych-up', 'shadow-ball', 'future-sight', 'torment', 'will-o-wisp', 'memento', 'facade', 'taunt', 'trick', 'skill-swap', 'imprison', 'grudge', 'snatch', 'secret-power', 'astonish', 'calm-mind', 'gravity', 'natural-gift', 'payback', 'embargo', 'fling', 'sucker-punch', 'dark-pulse', 'shadow-sneak', 'trick-room', 'captivate', 'charge-beam', 'ominous-wind', 'wonder-room', 'telekinesis', 'round', 'hex', 'confide', 'infestation'], 'name': 'duskull', 'stats': {'hp': 20, 'attack': 40, 'defense': 90, 'special-attack': 30, 'special-defense': 90, 'speed': 25}, 'types': ['ghost'], 'weight': 150, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 25, 'gender_rate': 4, 'capture_rate': 190, 'color': 'black', 'shape': 'arms', 'habitat': 'forest', 'generation': 'generation-iii', 'growth_rate': 'fast', 'egg_groups': ['indeterminate'], 'names': {'ja-Hrkt': 'ヨマワル', 'roomaji': 'Yomawaru', 'ko': '해골몽', 'zh-Hant': '夜巡靈', 'fr': 'Skelénox', 'de': 'Zwirrlicht', 'es': 'Duskull', 'it': 'Duskull', 'en': 'Duskull', 'ja': 'ヨマワル', 'zh-Hans': '夜巡灵'}, 'genera': {'ja-Hrkt': 'おむかえポケモン', 'ko': '마중포켓몬', 'zh-Hant': '渡魂寶可夢', 'fr': 'Pokémon Requiem', 'de': 'Requiem', 'es': 'Pokémon Réquiem', 'it': 'Pokémon Requiem', 'en': 'Requiem Pokémon', 'ja': 'おむかえポケモン', 'zh-Hans': '渡魂宝可梦'}}
	public class SpecieDuskull : PokemonSpecie
	{
#nullable enable
		private static SpecieDuskull? _instance = null;
#nullable restore
        public static SpecieDuskull Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieDuskull();
                }
                return _instance;
            }
        }

		public SpecieDuskull() : base(
			"Duskull",
			20, // HPs
			40, 90, // Attack & Defense
			30, 90, // Special Attack & Defense
			25			
		) {}
	}


	//Duskull Pokemon Class
	public class Duskull : Pokemon
	{

		public Duskull(string nickname, int level)
		: base(
				355,
				SpecieDuskull.Instance, // Pokemon Specie
				nickname, level,
				Ghost.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Duskull(int level)
		: base(
				355,
				SpecieDuskull.Instance, // Pokemon Specie
				"Duskull", level,
				Ghost.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Duskull() : base(
			355,
			SpecieDuskull.Instance, // Pokemon Specie
			Ghost.Instance			
		) {}
	}
}