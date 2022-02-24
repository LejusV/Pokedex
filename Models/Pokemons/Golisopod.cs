using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Golisopod Specie to store common natural stats of every {'abilities': ['emergency-exit'], 'base_experience': 186, 'height': 20, 'id': 768, 'moves': ['swords-dance', 'sand-attack', 'pin-missile', 'surf', 'ice-beam', 'blizzard', 'toxic', 'double-team', 'waterfall', 'leech-life', 'rest', 'rock-slide', 'slash', 'substitute', 'spite', 'protect', 'sludge-bomb', 'false-swipe', 'swagger', 'fury-cutter', 'attract', 'sleep-talk', 'return', 'frustration', 'hidden-power', 'rain-dance', 'psych-up', 'rock-smash', 'hail', 'facade', 'taunt', 'brick-break', 'rock-tomb', 'aerial-ace', 'iron-defense', 'bulk-up', 'payback', 'fling', 'sucker-punch', 'poison-jab', 'dark-pulse', 'x-scissor', 'focus-blast', 'giga-impact', 'shadow-claw', 'bug-bite', 'venoshock', 'sludge-wave', 'round', 'scald', 'struggle-bug', 'frost-breath', 'razor-shell', 'snarl', 'confide', 'first-impression', 'liquidation'], 'name': 'golisopod', 'stats': {'hp': 75, 'attack': 125, 'defense': 140, 'special-attack': 60, 'special-defense': 90, 'speed': 40}, 'types': ['bug', 'water'], 'weight': 1080, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 20, 'gender_rate': 4, 'capture_rate': 45, 'color': 'gray', 'shape': 'humanoid', 'habitat': None, 'generation': 'generation-vii', 'growth_rate': 'medium', 'egg_groups': ['bug', 'water3'], 'names': {'ja-Hrkt': 'グソクムシャ', 'ko': '갑주무사', 'zh-Hant': '具甲武者', 'fr': 'Sarmuraï', 'de': 'Tectass', 'es': 'Golisopod', 'it': 'Golisopod', 'en': 'Golisopod', 'ja': 'グソクムシャ', 'zh-Hans': '具甲武者'}, 'genera': {'ja-Hrkt': 'そうこうポケモン', 'ko': '장갑포켓몬', 'zh-Hant': '裝甲寶可夢', 'fr': 'Pokémon Blindé', 'de': 'Rüstung', 'es': 'Pokémon Blindaje', 'it': 'Pokémon Blindato', 'en': 'Hard Scale Pokémon', 'ja': 'そうこうポケモン', 'zh-Hans': '装甲宝可梦'}}
	public class SpecieGolisopod : PokemonSpecie
	{
#nullable enable
		private static SpecieGolisopod? _instance = null;
#nullable restore
        public static SpecieGolisopod Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieGolisopod();
                }
                return _instance;
            }
        }

		public SpecieGolisopod() : base(
			"Golisopod",
			75, // HPs
			125, 140, // Attack & Defense
			60, 90, // Special Attack & Defense
			40			
		) {}
	}


	//Golisopod Pokemon Class
	public class Golisopod : Pokemon
	{

		public Golisopod(string nickname, int level)
		: base(
				768,
				SpecieGolisopod.Instance, // Pokemon Specie
				nickname, level,
				Bug.Instance, Water.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Golisopod(int level)
		: base(
				768,
				SpecieGolisopod.Instance, // Pokemon Specie
				"Golisopod", level,
				Bug.Instance, Water.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Golisopod() : base(
			768,
			SpecieGolisopod.Instance, // Pokemon Specie
			Bug.Instance, Water.Instance			
		) {}
	}
}