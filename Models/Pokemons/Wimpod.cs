using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Wimpod Specie to store common natural stats of every {'abilities': ['wimp-out'], 'base_experience': 46, 'height': 5, 'id': 767, 'moves': ['sand-attack', 'surf', 'toxic', 'double-team', 'harden', 'waterfall', 'leech-life', 'rest', 'substitute', 'protect', 'spikes', 'swagger', 'attract', 'sleep-talk', 'return', 'frustration', 'metal-claw', 'hidden-power', 'rain-dance', 'hail', 'facade', 'taunt', 'aqua-jet', 'wide-guard', 'round', 'scald', 'struggle-bug', 'confide'], 'name': 'wimpod', 'stats': {'hp': 25, 'attack': 35, 'defense': 40, 'special-attack': 20, 'special-defense': 30, 'speed': 80}, 'types': ['bug', 'water'], 'weight': 120, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 20, 'gender_rate': 4, 'capture_rate': 90, 'color': 'gray', 'shape': 'tentacles', 'habitat': None, 'generation': 'generation-vii', 'growth_rate': 'medium', 'egg_groups': ['bug', 'water3'], 'names': {'ja-Hrkt': 'コソクムシ', 'ko': '꼬시레', 'zh-Hant': '膽小蟲', 'fr': 'Sovkipou', 'de': 'Reißlaus', 'es': 'Wimpod', 'it': 'Wimpod', 'en': 'Wimpod', 'ja': 'コソクムシ', 'zh-Hans': '胆小虫'}, 'genera': {'ja-Hrkt': 'そうこうポケモン', 'ko': '주행포켓몬', 'zh-Hant': '疾行寶可夢', 'fr': 'Pokémon Cavaleur', 'de': 'Laufschritt', 'es': 'Pokémon Huidizo', 'it': 'Pokémon Lestopode', 'en': 'Turn Tail Pokémon', 'ja': 'そうこうポケモン', 'zh-Hans': '疾行宝可梦'}}
	public class SpecieWimpod : PokemonSpecie
	{
#nullable enable
		private static SpecieWimpod? _instance = null;
#nullable restore
        public static SpecieWimpod Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieWimpod();
                }
                return _instance;
            }
        }

		public SpecieWimpod() : base(
			"Wimpod",
			25, // HPs
			35, 40, // Attack & Defense
			20, 30, // Special Attack & Defense
			80			
		) {}
	}


	//Wimpod Pokemon Class
	public class Wimpod : Pokemon
	{

		public Wimpod(string nickname, int level)
		: base(
				767,
				SpecieWimpod.Instance, // Pokemon Specie
				nickname, level,
				Bug.Instance, Water.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Wimpod(int level)
		: base(
				767,
				SpecieWimpod.Instance, // Pokemon Specie
				"Wimpod", level,
				Bug.Instance, Water.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Wimpod() : base(
			767,
			SpecieWimpod.Instance, // Pokemon Specie
			Bug.Instance, Water.Instance			
		) {}
	}
}