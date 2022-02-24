using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Pidgeotto Specie to store common natural stats of every {'abilities': ['keen-eye', 'tangled-feet', 'big-pecks'], 'base_experience': 122, 'height': 11, 'id': 17, 'moves': ['razor-wind', 'gust', 'wing-attack', 'whirlwind', 'fly', 'sand-attack', 'tackle', 'take-down', 'double-edge', 'toxic', 'agility', 'quick-attack', 'rage', 'mimic', 'double-team', 'reflect', 'bide', 'mirror-move', 'swift', 'sky-attack', 'rest', 'substitute', 'thief', 'snore', 'curse', 'protect', 'mud-slap', 'detect', 'endure', 'swagger', 'steel-wing', 'attract', 'sleep-talk', 'return', 'frustration', 'hidden-power', 'twister', 'rain-dance', 'sunny-day', 'uproar', 'heat-wave', 'facade', 'secret-power', 'feather-dance', 'air-cutter', 'aerial-ace', 'roost', 'natural-gift', 'pluck', 'tailwind', 'u-turn', 'air-slash', 'defog', 'captivate', 'ominous-wind', 'round', 'work-up', 'hurricane', 'confide'], 'name': 'pidgeotto', 'stats': {'hp': 63, 'attack': 60, 'defense': 55, 'special-attack': 50, 'special-defense': 50, 'speed': 71}, 'types': ['normal', 'flying'], 'weight': 300, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 15, 'gender_rate': 4, 'capture_rate': 120, 'color': 'brown', 'shape': 'wings', 'habitat': 'forest', 'generation': 'generation-i', 'growth_rate': 'medium-slow', 'egg_groups': ['flying'], 'names': {'ja-Hrkt': 'ピジョン', 'roomaji': 'Pigeon', 'ko': '피죤', 'zh-Hant': '比比鳥', 'fr': 'Roucoups', 'de': 'Tauboga', 'es': 'Pidgeotto', 'it': 'Pidgeotto', 'en': 'Pidgeotto', 'ja': 'ピジョン', 'zh-Hans': '比比鸟'}, 'genera': {'ja-Hrkt': 'とりポケモン', 'ko': '새포켓몬', 'zh-Hant': '鳥寶可夢', 'fr': 'Pokémon Oiseau', 'de': 'Vogel', 'es': 'Pokémon Pájaro', 'it': 'Pokémon Uccello', 'en': 'Bird Pokémon', 'ja': 'とりポケモン', 'zh-Hans': '鸟宝可梦'}}
	public class SpeciePidgeotto : PokemonSpecie
	{
#nullable enable
		private static SpeciePidgeotto? _instance = null;
#nullable restore
        public static SpeciePidgeotto Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciePidgeotto();
                }
                return _instance;
            }
        }

		public SpeciePidgeotto() : base(
			"Pidgeotto",
			63, // HPs
			60, 55, // Attack & Defense
			50, 50, // Special Attack & Defense
			71			
		) {}
	}


	//Pidgeotto Pokemon Class
	public class Pidgeotto : Pokemon
	{

		public Pidgeotto(string nickname, int level)
		: base(
				17,
				SpeciePidgeotto.Instance, // Pokemon Specie
				nickname, level,
				Normal.Instance, Flying.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Pidgeotto() : base(
			17,
			SpeciePidgeotto.Instance, // Pokemon Specie
			Normal.Instance, Flying.Instance			
		) {}
	}
}