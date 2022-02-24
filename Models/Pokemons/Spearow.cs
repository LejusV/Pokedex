using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Spearow Specie to store common natural stats of every {'abilities': ['keen-eye', 'sniper'], 'base_experience': 52, 'height': 3, 'id': 21, 'moves': ['razor-wind', 'whirlwind', 'fly', 'fury-attack', 'take-down', 'double-edge', 'leer', 'growl', 'peck', 'drill-peck', 'toxic', 'agility', 'quick-attack', 'rage', 'mimic', 'double-team', 'focus-energy', 'bide', 'mirror-move', 'swift', 'sky-attack', 'rest', 'tri-attack', 'substitute', 'thief', 'snore', 'curse', 'protect', 'scary-face', 'feint-attack', 'mud-slap', 'detect', 'endure', 'false-swipe', 'swagger', 'steel-wing', 'attract', 'sleep-talk', 'return', 'frustration', 'pursuit', 'hidden-power', 'twister', 'rain-dance', 'sunny-day', 'uproar', 'heat-wave', 'facade', 'secret-power', 'feather-dance', 'astonish', 'air-cutter', 'aerial-ace', 'roost', 'natural-gift', 'pluck', 'tailwind', 'u-turn', 'assurance', 'defog', 'captivate', 'ominous-wind', 'round', 'echoed-voice', 'work-up', 'drill-run', 'confide'], 'name': 'spearow', 'stats': {'hp': 40, 'attack': 60, 'defense': 30, 'special-attack': 31, 'special-defense': 31, 'speed': 70}, 'types': ['normal', 'flying'], 'weight': 20, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 15, 'gender_rate': 4, 'capture_rate': 255, 'color': 'brown', 'shape': 'wings', 'habitat': 'rough-terrain', 'generation': 'generation-i', 'growth_rate': 'medium', 'egg_groups': ['flying'], 'names': {'ja-Hrkt': 'オニスズメ', 'roomaji': 'Onisuzume', 'ko': '깨비참', 'zh-Hant': '烈雀', 'fr': 'Piafabec', 'de': 'Habitak', 'es': 'Spearow', 'it': 'Spearow', 'en': 'Spearow', 'ja': 'オニスズメ', 'zh-Hans': '烈雀'}, 'genera': {'ja-Hrkt': 'ことりポケモン', 'ko': '아기새포켓몬', 'zh-Hant': '小鳥寶可夢', 'fr': 'Pokémon Minoiseau', 'de': 'Kleinvogel', 'es': 'Pokémon Pajarito', 'it': 'Pokémon Uccellino', 'en': 'Tiny Bird Pokémon', 'ja': 'ことりポケモン', 'zh-Hans': '小鸟宝可梦'}}
	public class SpecieSpearow : PokemonSpecie
	{
#nullable enable
		private static SpecieSpearow? _instance = null;
#nullable restore
        public static SpecieSpearow Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieSpearow();
                }
                return _instance;
            }
        }

		public SpecieSpearow() : base(
			"Spearow",
			40, // HPs
			60, 30, // Attack & Defense
			31, 31, // Special Attack & Defense
			70			
		) {}
	}


	//Spearow Pokemon Class
	public class Spearow : Pokemon
	{

		public Spearow(string nickname, int level)
		: base(
				21,
				SpecieSpearow.Instance, // Pokemon Specie
				nickname, level,
				Normal.Instance, Flying.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Spearow(int level)
		: base(
				21,
				SpecieSpearow.Instance, // Pokemon Specie
				"Spearow", level,
				Normal.Instance, Flying.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Spearow() : base(
			21,
			SpecieSpearow.Instance, // Pokemon Specie
			Normal.Instance, Flying.Instance			
		) {}
	}
}