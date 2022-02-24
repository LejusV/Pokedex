using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Mothim Specie to store common natural stats of every {'abilities': ['swarm', 'tinted-lens'], 'base_experience': 148, 'height': 9, 'id': 414, 'moves': ['gust', 'tackle', 'psybeam', 'hyper-beam', 'solar-beam', 'poison-powder', 'string-shot', 'toxic', 'confusion', 'psychic', 'double-team', 'swift', 'dream-eater', 'flash', 'rest', 'substitute', 'thief', 'snore', 'protect', 'mud-slap', 'giga-drain', 'endure', 'swagger', 'attract', 'sleep-talk', 'return', 'frustration', 'safeguard', 'hidden-power', 'twister', 'rain-dance', 'sunny-day', 'psych-up', 'shadow-ball', 'facade', 'skill-swap', 'secret-power', 'camouflage', 'air-cutter', 'silver-wind', 'signal-beam', 'aerial-ace', 'roost', 'natural-gift', 'tailwind', 'u-turn', 'air-slash', 'bug-buzz', 'energy-ball', 'giga-impact', 'defog', 'captivate', 'bug-bite', 'ominous-wind', 'venoshock', 'quiver-dance', 'round', 'acrobatics', 'struggle-bug', 'electroweb', 'confide', 'infestation', 'lunge'], 'name': 'mothim', 'stats': {'hp': 70, 'attack': 94, 'defense': 50, 'special-attack': 94, 'special-defense': 50, 'speed': 66}, 'types': ['bug', 'flying'], 'weight': 233, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 15, 'gender_rate': 0, 'capture_rate': 45, 'color': 'yellow', 'shape': 'bug-wings', 'habitat': None, 'generation': 'generation-iv', 'growth_rate': 'medium', 'egg_groups': ['bug'], 'names': {'ja-Hrkt': 'ガーメイル', 'roomaji': 'Garmeil', 'ko': '나메일', 'zh-Hant': '紳士蛾', 'fr': 'Papilord', 'de': 'Moterpel', 'es': 'Mothim', 'it': 'Mothim', 'en': 'Mothim', 'ja': 'ガーメイル', 'zh-Hans': '绅士蛾'}, 'genera': {'ja-Hrkt': 'ミノガポケモン', 'ko': '나방포켓몬', 'zh-Hant': '蓑衣蛾寶可夢', 'fr': 'Pokémon Phalène', 'de': 'Motte', 'es': 'Pokémon Polilla', 'it': 'Pokémon Falena', 'en': 'Moth Pokémon', 'ja': 'ミノガポケモン', 'zh-Hans': '蓑衣蛾宝可梦'}}
	public class SpecieMothim : PokemonSpecie
	{
#nullable enable
		private static SpecieMothim? _instance = null;
#nullable restore
        public static SpecieMothim Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieMothim();
                }
                return _instance;
            }
        }

		public SpecieMothim() : base(
			"Mothim",
			70, // HPs
			94, 50, // Attack & Defense
			94, 50, // Special Attack & Defense
			66			
		) {}
	}


	//Mothim Pokemon Class
	public class Mothim : Pokemon
	{

		public Mothim(string nickname, int level)
		: base(
				414,
				SpecieMothim.Instance, // Pokemon Specie
				nickname, level,
				Bug.Instance, Flying.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Mothim(int level)
		: base(
				414,
				SpecieMothim.Instance, // Pokemon Specie
				"Mothim", level,
				Bug.Instance, Flying.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Mothim() : base(
			414,
			SpecieMothim.Instance, // Pokemon Specie
			Bug.Instance, Flying.Instance			
		) {}
	}
}