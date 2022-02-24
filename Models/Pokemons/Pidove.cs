using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Pidove Specie to store common natural stats of every {'abilities': ['big-pecks', 'super-luck', 'rivalry'], 'base_experience': 53, 'height': 3, 'id': 519, 'moves': ['razor-wind', 'gust', 'fly', 'leer', 'growl', 'toxic', 'hypnosis', 'quick-attack', 'double-team', 'sky-attack', 'rest', 'substitute', 'snore', 'protect', 'detect', 'swagger', 'steel-wing', 'attract', 'sleep-talk', 'return', 'frustration', 'morning-sun', 'hidden-power', 'rain-dance', 'sunny-day', 'uproar', 'heat-wave', 'facade', 'taunt', 'wish', 'secret-power', 'feather-dance', 'air-cutter', 'aerial-ace', 'roost', 'pluck', 'tailwind', 'u-turn', 'lucky-chant', 'night-slash', 'air-slash', 'round', 'echoed-voice', 'bestow', 'work-up', 'confide'], 'name': 'pidove', 'stats': {'hp': 50, 'attack': 55, 'defense': 50, 'special-attack': 36, 'special-defense': 30, 'speed': 43}, 'types': ['normal', 'flying'], 'weight': 21, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 15, 'gender_rate': 4, 'capture_rate': 255, 'color': 'gray', 'shape': 'wings', 'habitat': None, 'generation': 'generation-v', 'growth_rate': 'medium-slow', 'egg_groups': ['flying'], 'names': {'ja-Hrkt': 'マメパト', 'ko': '콩둘기', 'zh-Hant': '豆豆鴿', 'fr': 'Poichigeon', 'de': 'Dusselgurr', 'es': 'Pidove', 'it': 'Pidove', 'en': 'Pidove', 'ja': 'マメパト', 'zh-Hans': '豆豆鸽'}, 'genera': {'ja-Hrkt': 'こばとポケモン', 'ko': '아기비둘기포켓몬', 'zh-Hant': '小鴿寶可夢', 'fr': 'Pokémon Tipigeon', 'de': 'Täubchen', 'es': 'Pokémon Pichón', 'it': 'Pokémon Piccione', 'en': 'Tiny Pigeon Pokémon', 'ja': 'こばとポケモン', 'zh-Hans': '小鸽宝可梦'}}
	public class SpeciePidove : PokemonSpecie
	{
#nullable enable
		private static SpeciePidove? _instance = null;
#nullable restore
        public static SpeciePidove Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciePidove();
                }
                return _instance;
            }
        }

		public SpeciePidove() : base(
			"Pidove",
			50, // HPs
			55, 50, // Attack & Defense
			36, 30, // Special Attack & Defense
			43			
		) {}
	}


	//Pidove Pokemon Class
	public class Pidove : Pokemon
	{

		public Pidove(string nickname, int level)
		: base(
				519,
				SpeciePidove.Instance, // Pokemon Specie
				nickname, level,
				Normal.Instance, Flying.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Pidove(int level)
		: base(
				519,
				SpeciePidove.Instance, // Pokemon Specie
				"Pidove", level,
				Normal.Instance, Flying.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Pidove() : base(
			519,
			SpeciePidove.Instance, // Pokemon Specie
			Normal.Instance, Flying.Instance			
		) {}
	}
}