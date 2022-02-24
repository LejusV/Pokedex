using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Pidgeot Specie to store common natural stats of every {'abilities': ['keen-eye', 'tangled-feet', 'big-pecks'], 'base_experience': 216, 'height': 15, 'id': 18, 'moves': ['razor-wind', 'gust', 'wing-attack', 'whirlwind', 'fly', 'sand-attack', 'tackle', 'take-down', 'double-edge', 'hyper-beam', 'toxic', 'agility', 'quick-attack', 'rage', 'mimic', 'double-team', 'reflect', 'bide', 'mirror-move', 'swift', 'sky-attack', 'rest', 'substitute', 'thief', 'snore', 'curse', 'protect', 'mud-slap', 'detect', 'endure', 'swagger', 'steel-wing', 'attract', 'sleep-talk', 'return', 'frustration', 'hidden-power', 'twister', 'rain-dance', 'sunny-day', 'uproar', 'heat-wave', 'facade', 'secret-power', 'feather-dance', 'air-cutter', 'aerial-ace', 'roost', 'natural-gift', 'pluck', 'tailwind', 'u-turn', 'air-slash', 'giga-impact', 'defog', 'captivate', 'ominous-wind', 'round', 'work-up', 'hurricane', 'confide'], 'name': 'pidgeot', 'stats': {'hp': 83, 'attack': 80, 'defense': 75, 'special-attack': 70, 'special-defense': 70, 'speed': 101}, 'types': ['normal', 'flying'], 'weight': 395, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 15, 'gender_rate': 4, 'capture_rate': 45, 'color': 'brown', 'shape': 'wings', 'habitat': 'forest', 'generation': 'generation-i', 'growth_rate': 'medium-slow', 'egg_groups': ['flying'], 'names': {'ja-Hrkt': 'ピジョット', 'roomaji': 'Pigeot', 'ko': '피죤투', 'zh-Hant': '大比鳥', 'fr': 'Roucarnage', 'de': 'Tauboss', 'es': 'Pidgeot', 'it': 'Pidgeot', 'en': 'Pidgeot', 'ja': 'ピジョット', 'zh-Hans': '大比鸟'}, 'genera': {'ja-Hrkt': 'とりポケモン', 'ko': '새포켓몬', 'zh-Hant': '鳥寶可夢', 'fr': 'Pokémon Oiseau', 'de': 'Vogel', 'es': 'Pokémon Pájaro', 'it': 'Pokémon Uccello', 'en': 'Bird Pokémon', 'ja': 'とりポケモン', 'zh-Hans': '鸟宝可梦'}}
	public class SpeciePidgeot : PokemonSpecie
	{
#nullable enable
		private static SpeciePidgeot? _instance = null;
#nullable restore
        public static SpeciePidgeot Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciePidgeot();
                }
                return _instance;
            }
        }

		public SpeciePidgeot() : base(
			"Pidgeot",
			83, // HPs
			80, 75, // Attack & Defense
			70, 70, // Special Attack & Defense
			101			
		) {}
	}


	//Pidgeot Pokemon Class
	public class Pidgeot : Pokemon
	{

		public Pidgeot(string nickname, int level)
		: base(
				18,
				SpeciePidgeot.Instance, // Pokemon Specie
				nickname, level,
				Normal.Instance, Flying.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Pidgeot() : base(
			18,
			SpeciePidgeot.Instance, // Pokemon Specie
			Normal.Instance, Flying.Instance			
		) {}
	}
}