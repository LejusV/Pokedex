using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Vespiquen Specie to store common natural stats of every {'abilities': ['pressure', 'unnerve'], 'base_experience': 166, 'height': 12, 'id': 416, 'moves': ['cut', 'gust', 'poison-sting', 'hyper-beam', 'string-shot', 'toxic', 'double-team', 'confuse-ray', 'swift', 'flash', 'fury-swipes', 'rest', 'slash', 'substitute', 'thief', 'snore', 'protect', 'sludge-bomb', 'mud-slap', 'destiny-bond', 'endure', 'swagger', 'fury-cutter', 'attract', 'sleep-talk', 'return', 'frustration', 'pursuit', 'sweet-scent', 'hidden-power', 'rain-dance', 'sunny-day', 'facade', 'endeavor', 'secret-power', 'air-cutter', 'silver-wind', 'signal-beam', 'aerial-ace', 'roost', 'natural-gift', 'tailwind', 'u-turn', 'fling', 'air-slash', 'x-scissor', 'power-gem', 'giga-impact', 'defog', 'captivate', 'bug-bite', 'attack-order', 'defend-order', 'heal-order', 'ominous-wind', 'hone-claws', 'venoshock', 'round', 'quash', 'acrobatics', 'struggle-bug', 'fell-stinger', 'confide', 'infestation'], 'name': 'vespiquen', 'stats': {'hp': 70, 'attack': 80, 'defense': 102, 'special-attack': 80, 'special-defense': 102, 'speed': 40}, 'types': ['bug', 'flying'], 'weight': 385, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 15, 'gender_rate': 8, 'capture_rate': 45, 'color': 'yellow', 'shape': 'bug-wings', 'habitat': None, 'generation': 'generation-iv', 'growth_rate': 'medium-slow', 'egg_groups': ['bug'], 'names': {'ja-Hrkt': 'ビークイン', 'roomaji': 'Beequeen', 'ko': '비퀸', 'zh-Hant': '蜂女王', 'fr': 'Apireine', 'de': 'Honweisel', 'es': 'Vespiquen', 'it': 'Vespiquen', 'en': 'Vespiquen', 'ja': 'ビークイン', 'zh-Hans': '蜂女王'}, 'genera': {'ja-Hrkt': 'はちのすポケモン', 'ko': '벌집포켓몬', 'zh-Hant': '蜂巢寶可夢', 'fr': 'Pokémon Ruche', 'de': 'Bienenstock', 'es': 'Pokémon Colmena', 'it': 'Pokémon Alveare', 'en': 'Beehive Pokémon', 'ja': 'はちのすポケモン', 'zh-Hans': '蜂巢宝可梦'}}
	public class SpecieVespiquen : PokemonSpecie
	{
#nullable enable
		private static SpecieVespiquen? _instance = null;
#nullable restore
        public static SpecieVespiquen Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieVespiquen();
                }
                return _instance;
            }
        }

		public SpecieVespiquen() : base(
			"Vespiquen",
			70, // HPs
			80, 102, // Attack & Defense
			80, 102, // Special Attack & Defense
			40			
		) {}
	}


	//Vespiquen Pokemon Class
	public class Vespiquen : Pokemon
	{

		public Vespiquen(string nickname, int level)
		: base(
				416,
				SpecieVespiquen.Instance, // Pokemon Specie
				nickname, level,
				Bug.Instance, Flying.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Vespiquen(int level)
		: base(
				416,
				SpecieVespiquen.Instance, // Pokemon Specie
				"Vespiquen", level,
				Bug.Instance, Flying.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Vespiquen() : base(
			416,
			SpecieVespiquen.Instance, // Pokemon Specie
			Bug.Instance, Flying.Instance			
		) {}
	}
}