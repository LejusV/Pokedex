using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Pidgey Specie to store common natural stats of every {'abilities': ['keen-eye', 'tangled-feet', 'big-pecks'], 'base_experience': 50, 'height': 3, 'id': 16, 'moves': ['razor-wind', 'gust', 'wing-attack', 'whirlwind', 'fly', 'sand-attack', 'tackle', 'take-down', 'double-edge', 'toxic', 'agility', 'quick-attack', 'rage', 'mimic', 'double-team', 'reflect', 'bide', 'mirror-move', 'swift', 'sky-attack', 'rest', 'substitute', 'thief', 'snore', 'curse', 'protect', 'feint-attack', 'mud-slap', 'foresight', 'detect', 'endure', 'swagger', 'steel-wing', 'attract', 'sleep-talk', 'return', 'frustration', 'pursuit', 'hidden-power', 'twister', 'rain-dance', 'sunny-day', 'uproar', 'heat-wave', 'facade', 'secret-power', 'feather-dance', 'air-cutter', 'aerial-ace', 'roost', 'natural-gift', 'pluck', 'tailwind', 'u-turn', 'air-slash', 'brave-bird', 'defog', 'captivate', 'ominous-wind', 'round', 'work-up', 'hurricane', 'confide'], 'name': 'pidgey', 'stats': {'hp': 40, 'attack': 45, 'defense': 40, 'special-attack': 35, 'special-defense': 35, 'speed': 56}, 'types': ['normal', 'flying'], 'weight': 18, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 15, 'gender_rate': 4, 'capture_rate': 255, 'color': 'brown', 'shape': 'wings', 'habitat': 'forest', 'generation': 'generation-i', 'growth_rate': 'medium-slow', 'egg_groups': ['flying'], 'names': {'ja-Hrkt': 'ポッポ', 'roomaji': 'Poppo', 'ko': '구구', 'zh-Hant': '波波', 'fr': 'Roucool', 'de': 'Taubsi', 'es': 'Pidgey', 'it': 'Pidgey', 'en': 'Pidgey', 'ja': 'ポッポ', 'zh-Hans': '波波'}, 'genera': {'ja-Hrkt': 'ことりポケモン', 'ko': '아기새포켓몬', 'zh-Hant': '小鳥寶可夢', 'fr': 'Pokémon Minoiseau', 'de': 'Kleinvogel', 'es': 'Pokémon Pajarito', 'it': 'Pokémon Uccellino', 'en': 'Tiny Bird Pokémon', 'ja': 'ことりポケモン', 'zh-Hans': '小鸟宝可梦'}}
	public class SpeciePidgey : PokemonSpecie
	{
#nullable enable
		private static SpeciePidgey? _instance = null;
#nullable restore
        public static SpeciePidgey Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciePidgey();
                }
                return _instance;
            }
        }

		public SpeciePidgey() : base(
			"Pidgey",
			40, // HPs
			45, 40, // Attack & Defense
			35, 35, // Special Attack & Defense
			56			
		) {}
	}


	//Pidgey Pokemon Class
	public class Pidgey : Pokemon
	{

		public Pidgey(string nickname, int level) : base(
			16,
			SpeciePidgey.Instance, // Pokemon Specie
			nickname, level,
			Normal.Instance, Flying.Instance			
		) {}

		public Pidgey() : base(
			16,
			SpeciePidgey.Instance, // Pokemon Specie
			Normal.Instance, Flying.Instance			
		) {}
	}
}